namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            menuStrip2 = new MenuStrip();
            моделированиеToolStripMenuItem = new ToolStripMenuItem();
            записьДанныхВФайлToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            textBox7 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(418, 372);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "10";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(418, 429);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 15;
            button2.Text = "Моделирование";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(418, 400);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 23);
            textBox2.TabIndex = 16;
            textBox2.Text = "20";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 376);
            label3.Name = "label3";
            label3.Size = new Size(352, 19);
            label3.TabIndex = 17;
            label3.Text = "Количество контейнеров на разгрузку/погрузку (q):";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(52, 404);
            label4.Name = "label4";
            label4.Size = new Size(310, 19);
            label4.TabIndex = 18;
            label4.Text = "Количество контейнерных мест в поезде (n):";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(82, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(410, 120);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.WindowText;
            textBox4.Location = new Point(41, 30);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(504, 65);
            textBox4.TabIndex = 22;
            textBox4.Text = "Моделирование продолжительности выполнения грузовых операций на станции";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { моделированиеToolStripMenuItem, записьДанныхВФайлToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(595, 24);
            menuStrip2.TabIndex = 23;
            menuStrip2.Text = "menuStrip2";
            // 
            // моделированиеToolStripMenuItem
            // 
            моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            моделированиеToolStripMenuItem.Size = new Size(50, 20);
            моделированиеToolStripMenuItem.Text = "Карта";
            моделированиеToolStripMenuItem.Click += моделированиеToolStripMenuItem_Click;
            // 
            // записьДанныхВФайлToolStripMenuItem
            // 
            записьДанныхВФайлToolStripMenuItem.Name = "записьДанныхВФайлToolStripMenuItem";
            записьДанныхВФайлToolStripMenuItem.Size = new Size(143, 20);
            записьДанныхВФайлToolStripMenuItem.Text = "Запись данных в файл";
            записьДанныхВФайлToolStripMenuItem.Visible = false;
            записьДанныхВФайлToolStripMenuItem.Click += записьДанныхВФайлToolStripMenuItem_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.BackColor = SystemColors.Control;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location = new Point(52, 534);
            listView1.Name = "listView1";
            listView1.Size = new Size(493, 184);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(52, 429);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 433);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(309, 17);
            label1.TabIndex = 26;
            label1.Text = "- контейнерное место участвующее в операциях";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 467);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 17);
            label2.TabIndex = 28;
            label2.Text = "- контейнерное место не участвующее в операциях";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(52, 463);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(432, 512);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 23);
            comboBox1.TabIndex = 29;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(418, 458);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 30;
            button1.Text = "Моделирование из файла";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 494);
            label5.Name = "label5";
            label5.Size = new Size(171, 17);
            label5.TabIndex = 31;
            label5.Text = "Сумма по всем станциям:";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(52, 510);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(131, 20);
            textBox5.TabIndex = 32;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(228, 510);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(131, 20);
            textBox6.TabIndex = 34;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(228, 494);
            label6.Name = "label6";
            label6.Size = new Size(183, 17);
            label6.TabIndex = 33;
            label6.Text = "Ср. знач. по всем станциям:";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(493, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(418, 344);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(128, 23);
            textBox7.TabIndex = 38;
            textBox7.Text = "10";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 348);
            label7.Name = "label7";
            label7.Size = new Size(290, 19);
            label7.TabIndex = 37;
            label7.Text = "Количество станций для моделирования:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(595, 732);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(listView1);
            Controls.Add(menuStrip2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            MinimumSize = new Size(610, 764);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModelingRail";
            FormClosing += Form2_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem моделированиеToolStripMenuItem;
        private ListView listView1;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private ToolStripMenuItem записьДанныхВФайлToolStripMenuItem;
        private PictureBox pictureBox2;
        private TextBox textBox7;
        private Label label7;
    }
}