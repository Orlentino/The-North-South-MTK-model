namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            моделированиеToolStripMenuItem = new ToolStripMenuItem();
            математическоеМоделированиеToolStripMenuItem = new ToolStripMenuItem();
            движениеПоездаToolStripMenuItem = new ToolStripMenuItem();
            движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem = new ToolStripMenuItem();
            движениеПоездаПоЗападномуМаршрутуToolStripMenuItem = new ToolStripMenuItem();
            моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem = new ToolStripMenuItem();
            hScrollBar1 = new HScrollBar();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gMapControl1
            // 
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gMapControl1.AutoSize = true;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(116, 24);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(658, 472);
            gMapControl1.TabIndex = 0;
            gMapControl1.Zoom = 0D;
            gMapControl1.OnMarkerClick += gMapControl1_OnMarkerClick;
            gMapControl1.Load += gMapControl1_Load;
            gMapControl1.MouseMove += gMapControl1_MouseMove;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 27);
            button1.Name = "button1";
            button1.Size = new Size(92, 40);
            button1.TabIndex = 2;
            button1.Text = "Векторная крата";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 75);
            button2.Name = "button2";
            button2.Size = new Size(92, 41);
            button2.TabIndex = 3;
            button2.Text = "Спутниковая карта";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 122);
            button3.Name = "button3";
            button3.Size = new Size(92, 40);
            button3.TabIndex = 4;
            button3.Text = "Гибридная карта";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(651, 453);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(651, 468);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { моделированиеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(776, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // моделированиеToolStripMenuItem
            // 
            моделированиеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { математическоеМоделированиеToolStripMenuItem, движениеПоездаToolStripMenuItem, движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem, движениеПоездаПоЗападномуМаршрутуToolStripMenuItem, моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem });
            моделированиеToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            моделированиеToolStripMenuItem.Size = new Size(101, 20);
            моделированиеToolStripMenuItem.Text = "Моделирование";
            // 
            // математическоеМоделированиеToolStripMenuItem
            // 
            математическоеМоделированиеToolStripMenuItem.Name = "математическоеМоделированиеToolStripMenuItem";
            математическоеМоделированиеToolStripMenuItem.Size = new Size(441, 22);
            математическоеМоделированиеToolStripMenuItem.Text = "Математическое моделирование выгрузки/погрузки";
            математическоеМоделированиеToolStripMenuItem.Click += математическоеМоделированиеToolStripMenuItem_Click;
            // 
            // движениеПоездаToolStripMenuItem
            // 
            движениеПоездаToolStripMenuItem.Name = "движениеПоездаToolStripMenuItem";
            движениеПоездаToolStripMenuItem.Size = new Size(441, 22);
            движениеПоездаToolStripMenuItem.Text = "Моделирование движения по восточному маршруту через Серахс";
            движениеПоездаToolStripMenuItem.Click += движениеПоездаToolStripMenuItem_Click;
            // 
            // движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem
            // 
            движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem.Name = "движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem";
            движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem.Size = new Size(441, 22);
            движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem.Text = "Моделирование движения по восточному маршруту через Инче-Бурун";
            движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem.Click += движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem_Click;
            // 
            // движениеПоездаПоЗападномуМаршрутуToolStripMenuItem
            // 
            движениеПоездаПоЗападномуМаршрутуToolStripMenuItem.Name = "движениеПоездаПоЗападномуМаршрутуToolStripMenuItem";
            движениеПоездаПоЗападномуМаршрутуToolStripMenuItem.Size = new Size(441, 22);
            движениеПоездаПоЗападномуМаршрутуToolStripMenuItem.Text = "Моделирование движения по западному маршруту";
            движениеПоездаПоЗападномуМаршрутуToolStripMenuItem.Click += движениеПоездаПоЗападномуМаршрутуToolStripMenuItem_Click;
            // 
            // моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem
            // 
            моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem.Name = "моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem";
            моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem.Size = new Size(441, 22);
            моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem.Text = "Моделирование движения по транскаспийскому маршруту";
            моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem.Click += моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            hScrollBar1.Location = new Point(18, 458);
            hScrollBar1.Maximum = 24;
            hScrollBar1.Minimum = 2;
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(80, 25);
            hScrollBar1.TabIndex = 11;
            hScrollBar1.Value = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            hScrollBar1.MouseCaptureChanged += hScrollBar1_MouseCaptureChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Аккистау", "Аксарайский", "Актау", "Алтын Сяхря", "Анисовка", "Априн", "Артезиан", "Артык", "Астара (Азербайджан)", "Астара (Иран)", "Астрахань", "Аткарск", "Атырау", "Ашулук", "Бад", "Баджестан", "Байрамалы", "Баку", "Бами", "Бафк", "Бахарден", "Бахрам", "Баш-Алят", "Бейнеу", "Белиджи", "Бендер-Аббас", "Бендер-Энзели", "Берекет", "Берикей", "Богоявленск", "Бойныузын", "Бологое", "Бусловская", "Вертуновская", "Верхний Баскунчак", "Выборг", "Вышний Волочек ", "Гаджи-Зейналабдин", "Гамышоба", "Ганюшкино", "Гарыбата", "Гёкдепе", "Гермсар", "Гмелинская", "Гобустан", "Гол Гохар", "Горган", "Гыпджак", "Дашогуз", "Дербент", "Джалилабад", "Доссор", "Ералиево", "Жаслык", "Железнодорожная станция Дины Нурпеисовой", "Жетыбай", "Захмет", "Зензели", "Зергер", "Избербаш", "Инче-Барун", "Йезд", "Казвин", "Кака", "Канлыкуль", "Карадаг", "Кашан", "Каэмшехр", "Келята", "Кизилюрт", "Кизляр", "Килязи", "Кирсанов", "Кочубей", "Красный Кут", "Кульсары", "Кум", "Кунград", "Курык ", "Кусарчай", "Кхондж", "Лавак", "Ленкорань", "Лиман", "Макат", "Малая Вишера ", "Манас", "Мангистау ", "Мары", "Масаллы", "Махачкала", "Машхад", "Мейбод", "Милославское", "Михайлов", "Мичуринск-Уральский ", "Молланепес", "Москва Павелецкая ", "Мотахари", "Найманкуль", "Ожерелье", "Окуловка", "Павелец-1-Тульский ", "Палласовка", "Питнак", "Платоновка", "Поле-Сефид", "разъезд Афанасьева", "разъезд № 17", "Раненбург", "Решт", "Ртищево-1", "Сазакин", "Сай-Утес", "Сальяны", "Сангачалы", "Санкт-Петербург ", "Саратов I-Пассажирский", "Сари", "Сейди", "Сен Чахун", "Серахс ", "Сердар", "Сиазань", "Сирджан", "Тамала", "Тамбов-1", "Тараджи", "Тверь ", "Тебес", "Тегеран", "Теджен", "Темиргое", "Торбете-Хейдерие", "Туркменабат-2", "Узень", "Узуново", "Улан-Холл", "Урбах ", "Ургенч", "Фариман", "Фирузкух", "Хазарасп", "Ханка", "Харабалинская", "Хатунаабад", "Хаштпар", "Ходжейли", "Чархи", "Шават", "Шамхал", "Шетпе", "Ширван", "Шуманай", "Эльтон" });
            comboBox1.Location = new Point(12, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(92, 23);
            comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Аккистау", "Аксарайский", "Актау", "Алтын Сяхря", "Анисовка", "Априн", "Артезиан", "Артык", "Астара (Азербайджан)", "Астара (Иран)", "Астрахань", "Аткарск", "Атырау", "Ашулук", "Бад", "Баджестан", "Байрамалы", "Баку", "Бами", "Бафк", "Бахарден", "Бахрам", "Баш-Алят", "Бейнеу", "Белиджи", "Бендер-Аббас", "Бендер-Энзели", "Берекет", "Берикей", "Богоявленск", "Бойныузын", "Бологое", "Бусловская", "Вертуновская", "Верхний Баскунчак", "Выборг", "Вышний Волочек ", "Гаджи-Зейналабдин", "Гамышоба", "Ганюшкино", "Гарыбата", "Гёкдепе", "Гермсар", "Гмелинская", "Гобустан", "Гол Гохар", "Горган", "Гыпджак", "Дашогуз", "Дербент", "Джалилабад", "Доссор", "Ералиево", "Жаслык", "Железнодорожная станция Дины Нурпеисовой", "Жетыбай", "Захмет", "Зензели", "Зергер", "Избербаш", "Инче-Барун", "Йезд", "Казвин", "Кака", "Канлыкуль", "Карадаг", "Кашан", "Каэмшехр", "Келята", "Кизилюрт", "Кизляр", "Килязи", "Кирсанов", "Кочубей", "Красный Кут", "Кульсары", "Кум", "Кунград", "Курык ", "Кусарчай", "Кхондж", "Лавак", "Ленкорань", "Лиман", "Макат", "Малая Вишера ", "Манас", "Мангистау ", "Мары", "Масаллы", "Махачкала", "Машхад", "Мейбод", "Милославское", "Михайлов", "Мичуринск-Уральский ", "Молланепес", "Москва Павелецкая ", "Мотахари", "Найманкуль", "Ожерелье", "Окуловка", "Павелец-1-Тульский ", "Палласовка", "Питнак", "Платоновка", "Поле-Сефид", "разъезд Афанасьева", "разъезд № 17", "Раненбург", "Решт", "Ртищево-1", "Сазакин", "Сай-Утес", "Сальяны", "Сангачалы", "Санкт-Петербург ", "Саратов I-Пассажирский", "Сари", "Сейди", "Сен Чахун", "Серахс ", "Сердар", "Сиазань", "Сирджан", "Тамала", "Тамбов-1", "Тараджи", "Тверь ", "Тебес", "Тегеран", "Теджен", "Темиргое", "Торбете-Хейдерие", "Туркменабат-2", "Узень", "Узуново", "Улан-Холл", "Урбах ", "Ургенч", "Фариман", "Фирузкух", "Хазарасп", "Ханка", "Харабалинская", "Хатунаабад", "Хаштпар", "Ходжейли", "Чархи", "Шават", "Шамхал", "Шетпе", "Ширван", "Шуманай", "Эльтон" });
            comboBox2.Location = new Point(12, 273);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 23);
            comboBox2.TabIndex = 13;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(12, 302);
            button4.Name = "button4";
            button4.Size = new Size(92, 38);
            button4.TabIndex = 14;
            button4.Text = "Построить путь";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 213);
            label3.Name = "label3";
            label3.Size = new Size(100, 14);
            label3.TabIndex = 15;
            label3.Text = "Стартовая станция:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 256);
            label4.Name = "label4";
            label4.Size = new Size(96, 14);
            label4.TabIndex = 16;
            label4.Text = "Конечная станция:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 402);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(92, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 373);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(92, 23);
            textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 346);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(92, 23);
            textBox2.TabIndex = 23;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 442);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 24;
            label5.Text = "Маштаб";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(222, 70);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 22);
            toolStripMenuItem1.Text = "Очистить карту от пунктов";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(221, 22);
            toolStripMenuItem2.Text = "Показать большие пункты";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(221, 22);
            toolStripMenuItem3.Text = "Показать все пункты";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(78, 458);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 458);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(20, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(776, 502);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(hScrollBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gMapControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(792, 541);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModelingRail";
            FormClosed += Form1_FormClosed;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem моделированиеToolStripMenuItem;
        private ToolStripMenuItem математическоеМоделированиеToolStripMenuItem;
        private ToolStripMenuItem движениеПоездаToolStripMenuItem;
        private ToolStripMenuItem движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem;
        private ToolStripMenuItem движениеПоездаПоЗападномуМаршрутуToolStripMenuItem;
        private HScrollBar hScrollBar1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button4;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ToolStripMenuItem моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem;
    }
}