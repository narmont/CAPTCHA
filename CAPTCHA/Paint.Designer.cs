namespace CAPTCHA
{
    partial class Paint
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.PencilItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EraserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem,
            this.Tools,
            this.WindowsItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(842, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileItem
            // 
            this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.OpenItem,
            this.SaveItem,
            this.SaveAsItem,
            this.toolStripMenuItem1,
            this.CloseItem,
            this.toolStripMenuItem2,
            this.ExitItem});
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(48, 20);
            this.FileItem.Text = "&Файл";
            // 
            // NewItem
            // 
            this.NewItem.Image = ((System.Drawing.Image)(resources.GetObject("NewItem.Image")));
            this.NewItem.Name = "NewItem";
            this.NewItem.Size = new System.Drawing.Size(153, 22);
            this.NewItem.Text = "&Новый";
            this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
            // 
            // OpenItem
            // 
            this.OpenItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenItem.Image")));
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.Size = new System.Drawing.Size(153, 22);
            this.OpenItem.Text = "&Открыть";
            this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
            // 
            // SaveItem
            // 
            this.SaveItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveItem.Image")));
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(153, 22);
            this.SaveItem.Text = "&Сохранить";
            this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // SaveAsItem
            // 
            this.SaveAsItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsItem.Image")));
            this.SaveAsItem.Name = "SaveAsItem";
            this.SaveAsItem.Size = new System.Drawing.Size(153, 22);
            this.SaveAsItem.Text = "Сохранить &как";
            this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // CloseItem
            // 
            this.CloseItem.Image = ((System.Drawing.Image)(resources.GetObject("CloseItem.Image")));
            this.CloseItem.Name = "CloseItem";
            this.CloseItem.Size = new System.Drawing.Size(153, 22);
            this.CloseItem.Text = "&Закрыть";
            this.CloseItem.Click += new System.EventHandler(this.CloseItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // ExitItem
            // 
            this.ExitItem.Image = ((System.Drawing.Image)(resources.GetObject("ExitItem.Image")));
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(153, 22);
            this.ExitItem.Text = "&Выход";
            this.ExitItem.Click += new System.EventHandler(this.ExitItem_Click);
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearItem,
            this.toolStripMenuItem3,
            this.PencilItem,
            this.EraserItem,
            this.LineItem,
            this.RectangleItem,
            this.EllipseItem,
            this.размерToolStripMenuItem,
            this.цветToolStripMenuItem,
            this.толщинаToolStripMenuItem});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(95, 20);
            this.Tools.Text = "&Инструменты";
            // 
            // ClearItem
            // 
            this.ClearItem.Image = ((System.Drawing.Image)(resources.GetObject("ClearItem.Image")));
            this.ClearItem.Name = "ClearItem";
            this.ClearItem.Size = new System.Drawing.Size(163, 22);
            this.ClearItem.Text = "&Очистить";
            this.ClearItem.Click += new System.EventHandler(this.ClearItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(160, 6);
            // 
            // PencilItem
            // 
            this.PencilItem.Image = ((System.Drawing.Image)(resources.GetObject("PencilItem.Image")));
            this.PencilItem.Name = "PencilItem";
            this.PencilItem.Size = new System.Drawing.Size(163, 22);
            this.PencilItem.Text = "&Карандаш";
            this.PencilItem.Click += new System.EventHandler(this.PencilItem_Click);
            // 
            // EraserItem
            // 
            this.EraserItem.Image = ((System.Drawing.Image)(resources.GetObject("EraserItem.Image")));
            this.EraserItem.Name = "EraserItem";
            this.EraserItem.Size = new System.Drawing.Size(163, 22);
            this.EraserItem.Text = "&Резинка";
            this.EraserItem.Click += new System.EventHandler(this.EraserItem_Click);
            // 
            // LineItem
            // 
            this.LineItem.Image = ((System.Drawing.Image)(resources.GetObject("LineItem.Image")));
            this.LineItem.Name = "LineItem";
            this.LineItem.Size = new System.Drawing.Size(163, 22);
            this.LineItem.Text = "&Линия";
            this.LineItem.Click += new System.EventHandler(this.LineItem_Click);
            // 
            // RectangleItem
            // 
            this.RectangleItem.Image = ((System.Drawing.Image)(resources.GetObject("RectangleItem.Image")));
            this.RectangleItem.Name = "RectangleItem";
            this.RectangleItem.Size = new System.Drawing.Size(163, 22);
            this.RectangleItem.Text = "Пря&моугольник";
            this.RectangleItem.Click += new System.EventHandler(this.RectangleItem_Click);
            // 
            // EllipseItem
            // 
            this.EllipseItem.Image = ((System.Drawing.Image)(resources.GetObject("EllipseItem.Image")));
            this.EllipseItem.Name = "EllipseItem";
            this.EllipseItem.Size = new System.Drawing.Size(163, 22);
            this.EllipseItem.Text = "Эллип&с";
            this.EllipseItem.Click += new System.EventHandler(this.EllipseItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.размерToolStripMenuItem_Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.цветToolStripMenuItem.Text = "Цвет";
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.цветToolStripMenuItem_Click);
            // 
            // толщинаToolStripMenuItem
            // 
            this.толщинаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.толщинаToolStripMenuItem.Name = "толщинаToolStripMenuItem";
            this.толщинаToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.толщинаToolStripMenuItem.Text = "Толщина";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "5";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "10";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "15";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // WindowsItem
            // 
            this.WindowsItem.Name = "WindowsItem";
            this.WindowsItem.Size = new System.Drawing.Size(48, 20);
            this.WindowsItem.Text = "&Окно";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "...";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рисовалка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Paint_FormClosing);
            this.Load += new System.EventHandler(this.Paint_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CloseItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem WindowsItem;
        private System.Windows.Forms.ToolStripMenuItem ClearItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem PencilItem;
        private System.Windows.Forms.ToolStripMenuItem EraserItem;
        private System.Windows.Forms.ToolStripMenuItem LineItem;
        private System.Windows.Forms.ToolStripMenuItem RectangleItem;
        private System.Windows.Forms.ToolStripMenuItem EllipseItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толщинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        public System.Windows.Forms.Label label1;
    }
}

