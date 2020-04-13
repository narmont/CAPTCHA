using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPTCHA
{
    public struct TwoPoints
    {
        public Point point1;
        public Point point2;
        public TwoPoints(Point point1, Point point2)
        {

            this.point1 = point1;
            this.point2 = point2;
        }
    } 

    public partial class BitmapForma : Form
    {
        private Bitmap image;
        private Point startpoint;
        private Point endpoint;
        public static bool can_write = false;
        private List<TwoPoints> m_list;
        private string str = string.Empty;
        Graphics g;
        Paint.MyDelegate d;
        Point p;
        bool canMove = true;
        public BitmapForma(Paint.MyDelegate sender)
        {
            InitializeComponent();
            g = pictureBox.CreateGraphics();
            d= sender;

        }

        public Image m_Image
        {

            get
            {

                return pictureBox.Image;
            }
            set
            {

                pictureBox.Image = value;
            }
        }
        public ToolsClass tool { get; set; }

        private void BitmapForma_Load(object sender, EventArgs e)
        {
            pictureBox.AllowDrop = true;
            m_list = new List<TwoPoints>();
            image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (var graphics = Graphics.FromImage(image))
            {

                graphics.Clear(Color.White);
            }

            pictureBox.Image = image;
            
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            canMove = true;
            p = e.Location;
               if (e.Button == MouseButtons.Left)
               {
                    m_list.Clear();
                    can_write = true;
                    startpoint = e.Location;
                    pictureBox.Paint += OnPaint;
                   
                }
        }
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int keys);
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (tool is LineTool || tool is RectangleTool || tool is EllipseTool)
            {

                if (can_write)
                {
                    endpoint = e.Location;
                    pictureBox.Invalidate();
                }
            }
            else
            {
                if (can_write)
                {
                    endpoint = e.Location;
                    try
                    {
                        tool.Draw(m_list, startpoint, endpoint);
                        startpoint = e.Location;
                    }
                    catch
                    {

                    }
                    pictureBox.Invalidate();
                }
            }

            if (GetAsyncKeyState(18) != 0 && (canMove))
            {
                
                pictureBox = (PictureBox)sender;
                pictureBox.Top += e.Y - p.Y;
                pictureBox.Left += e.X - p.X;

            }
        }
     
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            canMove = false;
                try
                {
                    pictureBox.Paint -= OnPaint;
                    can_write = false;
                    m_list.Add(new TwoPoints(startpoint, endpoint));
                    tool.Draw(m_list, startpoint, endpoint);
                    pictureBox.Invalidate();
                }
                catch { 
                
                }
        }



        private void OnPaint(object sender, PaintEventArgs e)
        {
            try
            {
           
                tool.Draw(m_list, startpoint, endpoint, e.Graphics);
            }
            catch
            {
                
            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {

            int x = this.PointToClient(new Point(e.X, e.Y)).X;

            int y = this.PointToClient(new Point(e.X, e.Y)).Y;

            if (x >= pictureBox.Location.X && x <= pictureBox.Location.X + pictureBox.Width && y >= pictureBox.Location.Y && y <= pictureBox.Location.Y + pictureBox.Height) // проверка границ
            {

                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                pictureBox.Image = Image.FromFile(files[0]);

                d(files[0]);
                
            }     
        }
    }
}























/* Paint p = new Paint();



 string[] imagePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
 foreach (string path in imagePaths)
 {
     g.DrawImage(Image.FromFile(path), new Point(0, 0));
                
 }


 string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
 foreach (string file in files)
 {
  //   MessageBox.Show(file);
     p.label12(file);
 } */