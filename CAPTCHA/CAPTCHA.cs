using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPTCHA
{
    public partial class CAPTCHA : Form
    {
        public CAPTCHA()
        {
            InitializeComponent();
        }
        private bool f = true;
        public int g = 1;
        private string text = String.Empty;
        int[] numbers = new int[100];
        private void CAPTCHA_Load(object sender, EventArgs e)
        {
            int j = 0;
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image.Save("image" + j + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //создаем изображение
            Bitmap result = new Bitmap(Width, Height);

            //позиция текста
            int Xpos = 10;
            int Ypos = 10;

            //различные цвета для текста
            Brush[] colors = {
             Brushes.Black,
             Brushes.Red,
             Brushes.RoyalBlue,
             Brushes.Green,
             Brushes.Yellow,
             Brushes.White, 
             Brushes.Tomato,
             Brushes.Sienna,
             Brushes.Pink };

            //различные цвета для линий
            Pen[] colorpens = {
             Pens.Black,
             Pens.Red,
             Pens.RoyalBlue,
             Pens.Green,
             Pens.Yellow,
             Pens.White, 
             Pens.Tomato,
             Pens.Sienna,
             Pens.Pink };

            //случайный стиль для текста
            FontStyle[] fontstyle = {
             FontStyle.Bold,
             FontStyle.Italic,
             FontStyle.Regular,
             FontStyle.Strikeout,
             FontStyle.Underline};

            //различные углы поворота текста
            Int16[] rotate = { 1, -1, 2, -2, 3, -3, 4, -4, 5, -5, 6, -6 };

            //указываем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //фон
            g.Clear(Color.Gray);

            //делаем случайный угол поворота текста
            g.RotateTransform(rnd.Next(rotate.Length));
            
            //генерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            string RUS = "1234567890АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЧЦЪЫЬЭЮЯ";
            if (f == true)
            {
                for (int i = 0; i < 5; ++i)
                    text += ALF[rnd.Next(ALF.Length)];
            }
            else
            {
                for (int j = 0; j < 5; ++j)
                    text += RUS[rnd.Next(RUS.Length)];
            }

            //рисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 25, fontstyle[rnd.Next(fontstyle.Length)]),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //помехи
            //линии из углов
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(colorpens[rnd.Next(colorpens.Length)],
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            //белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                f = false;
            }
            else
            {
                f = true;
            }
            pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paint p = new Paint();

            if (f == true)
            {
                f = false;
            }
            else { f = true; }

            if (textBox1.Text == this.text)
            {
                MessageBox.Show("Верно! Вы вошли в программу!!!");
                //  pictureBox1.Image.Save("D:\\Капча/captcha" + g + ".png");
                pictureBox1.Image.Save("image" + g + ".png", System.Drawing.Imaging.ImageFormat.Png);
                g++;
                this.Hide();
                p.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ошибка!");
                pictureBox1.Image = this.CreateImage(pictureBox1.Width, pictureBox1.Height);
                this.textBox1.Clear();
                pictureBox1.Image.Save("image" + g + ".png", System.Drawing.Imaging.ImageFormat.Png);
                //  pictureBox1.Image.Save("D:\\Капча/captcha" + g + ".png");
                g++;
            }
        }


    }
}
