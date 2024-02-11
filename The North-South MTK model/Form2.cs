using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static bool IsNum(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c)) return true;
            }
            return false;
        }
        public Form1 fr1;
        int x, flag = 0, q, n, FileActive = 0, stan;
        int[] nn, qq;
        double[] sum;
        double[,] tg1;
        int[,] r;
        string file = @"Modeling.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string file = @"Modeling.txt";
            string[] lines = File.ReadAllLines(file);
            sum = new double[lines.Length];
            qq = new int[lines.Length];
            nn = new int[lines.Length];
            q = 0;
            string[] Oneline;
            if (flag == 1)
            {
                Array.Clear(sum);
                Array.Clear(tg1);
                Array.Clear(r);
                Array.Clear(qq);
                Array.Clear(nn);
            }
            for (int j = 0, q1 = 0; j < lines.Length; j++)
            {
                Oneline = lines[j].Split(new char[] { ' ' });
                q = int.Parse(Oneline[0]);
                qq[j] = q;
                if (q < q1)
                {
                    q = q1;
                    continue;
                }
                q1 = q;
            }
            // очищаем listView1
            listView1.Items.Clear();
            double tg, tp = 0.025, f = 0;
            tg1 = new double[lines.Length, q];
            r = new int[lines.Length, q];
            stan = lines.Length;
            comboBox1.Items.Clear();
            for (x = 0; x < lines.Length; x++)
            {
                Oneline = lines[x].Split(new char[] { ' ' });
                int q1 = int.Parse(Oneline[0]), n1 = int.Parse(Oneline[1]);
                nn[x] = n1;
                comboBox1.Items.Add("Станция №" + (x + 1));
                for (int i = 0, j = 0; i < q1;)
                {
                    r[x, i] = Random.Shared.Next(n1);
                    j = 0;
                    for (; r[x, j] != r[x, i]; j++) { }
                    if (i == j)
                        i++;
                }
                for (int i = 0; i < q1; i++)
                    for (int j = 0; j < q1 - 1; j++)
                        if (r[x, j] > r[x, j + 1])
                        {
                            int t = r[x, j + 1];
                            r[x, j + 1] = r[x, j];
                            r[x, j] = t;
                        }
                sum[x] = tp * (r[x, q1 - 1] - r[x, 0]);
                for (int i = 0; i < q1; i++)
                {
                    tg = 4 + Random.Shared.NextDouble() * 3;
                    tg1[x, i] = tg;
                    sum[x] += tg;
                }
                textBox3.Text = sum[0].ToString("n") + " мин.";
                if (f == 0)
                {
                    // создаем список изображений для строк listView1
                    ImageList imageList = new ImageList();
                    // устанавливаем размер изображений
                    imageList.ImageSize = new Size(20, 20);

                    // заполняем список изображениями
                    for (int i = 0, j = 0; i < n1; i++)
                    {
                        if (r[x, j] == i)
                        {
                            imageList.Images.Add(new Bitmap("Cont1.png"));
                            j++;
                            if (j == q1)
                                j--;
                            continue;
                        }
                        imageList.Images.Add(new Bitmap("Cont2.png"));
                    }
                    // устанавливаем в listView1 список изображений imageList
                    listView1.SmallImageList = imageList;
                    for (int i = 0, j = 0; i < n1; i++)
                    {
                        // создадим объект ListViewItem (строку) для listView1
                        ListViewItem listViewItem = new ListViewItem(new string[1]);

                        if (r[x, j] == i)
                        {
                            listViewItem.Text = "№" + (i + 1).ToString() + ", t=" + String.Format("{0:.###}", tg1[x, j]);
                            listViewItem.ImageIndex = i;
                            listView1.Items.Add(listViewItem);
                            j++;
                            if (j == q1)
                                j--;
                            continue;
                        }
                        listViewItem.Text = "№" + (i + 1).ToString();
                        // индекс изображения из imageList для данной строки listViewItem
                        listViewItem.ImageIndex = i;

                        // добавляем созданный элемент listViewItem (строку) в listView1
                        listView1.Items.Add(listViewItem);
                    }
                    textBox1.Text = "" + q1.ToString();
                    textBox2.Text = "" + n1.ToString();
                    f = 1;
                    flag = 1;
                    FileActive = 1;
                    comboBox1.Text = "Станция №1";
                }
            }
            double sum1 = 0;
            for (int i = 0; i < sum.Length; i++)
                sum1 += sum[i];
            textBox5.Text = sum1.ToString("n") + " мин.";
            textBox6.Text = (sum1 / sum.Length).ToString("n") + " мин.";
            записьДанныхВФайлToolStripMenuItem.Visible = true;
            textBox7.Text = stan.ToString();
        }

        private void моделированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!fr1.Visible)
            {
                Hide();
                fr1.Show();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            textBox3.Text = sum[index].ToString("n") + " мин.";
            listView1.Clear();

            ImageList imageList = new ImageList();

            // устанавливаем размер изображений
            imageList.ImageSize = new Size(20, 20);

            // заполняем список изображениями
            if (FileActive == 1)
            {
                string[] lines = File.ReadAllLines(file);
                string[] Oneline = lines[index].Split(new char[] { ' ' });
                q = int.Parse(Oneline[0]);
                n = int.Parse(Oneline[1]);
                textBox1.Text = "" + q.ToString();
                textBox2.Text = "" + n.ToString();
            }
            for (int i = 0, j = 0; i < n; i++)
            {
                if (r[index, j] == i)
                {
                    imageList.Images.Add(new Bitmap("Cont1.png"));
                    j++;
                    if (j == q)
                        j--;
                    continue;
                }
                imageList.Images.Add(new Bitmap("Cont2.png"));
            }

            // устанавливаем в listView1 список изображений imageList
            listView1.SmallImageList = imageList;
            for (int i = 0, j = 0; i < n; i++)
            {
                // создадим объект ListViewItem (строку) для listView1
                ListViewItem listViewItem = new ListViewItem(new string[1]);

                if (r[index, j] == i)
                {
                    listViewItem.Text = "№" + (i + 1).ToString() + ", t=" + String.Format("{0:.###}", tg1[index, j]);
                    listViewItem.ImageIndex = i;
                    listView1.Items.Add(listViewItem);
                    j++;
                    if (j == q)
                        j--;
                    continue;
                }
                listViewItem.Text = "№" + (i + 1).ToString();
                // индекс изображения из imageList для данной строки listViewItem
                listViewItem.ImageIndex = i;

                // добавляем созданный элемент listViewItem (строку) в listView1
                listView1.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsNum(textBox1.Text))
            {
                MessageBox.Show("Вводите целые неотрицательные числа.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                return;
            }
            if (IsNum(textBox2.Text))
            {
                MessageBox.Show("Вводите целые неотрицательные числа.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Не введено количество контейнеров на погрузку/разгрузку (q).", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Не введено количество контейнерных мест в поезде (n).", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            q = Convert.ToInt32(textBox1.Text);
            n = Convert.ToInt32(textBox2.Text);
            stan = Convert.ToInt32(textBox7.Text);
            if (q < 1)
            {
                MessageBox.Show("Поезд обрабатывается на станции только в случае, если нужно выгрузить/погрузить хотя бы один контейнер.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                return;
            }
            if (n < 1)
            {
                MessageBox.Show("Количество контейнерных мест должно быть не меньше 1.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                return;
            }
            if (n < q)
            {
                MessageBox.Show("Контейнеров на выгрузку/загрузку не может быть больше, чем количество контейнерных мест в поезде.", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // очищаем listView1
            listView1.Items.Clear();
            if (flag == 1)
            {
                Array.Clear(sum);
                Array.Clear(tg1);
                Array.Clear(r);
                Array.Clear(qq);
                Array.Clear(nn);
            }
            double tg, tp = 0.025, f = 0;
            sum = new double[stan];
            tg1 = new double[stan, q];
            r = new int[stan, q];
            qq = new int[stan];
            nn = new int[stan];
            comboBox1.Items.Clear();
            for (x = 0; x < stan; x++)
            {
                qq[x] = q;
                nn[x] = n;
                comboBox1.Items.Add("Станция №" + (x + 1));
                for (int i = 0; i < q;)
                {
                    r[x, i] = Random.Shared.Next(n);
                    int j = 0;
                    for (; r[x, j] != r[x, i]; j++) { }
                    if (i == j)
                        i++;
                }
                for (int i = 0; i < r.GetLength(1); i++)
                    for (int j = 0; j < r.GetLength(1) - 1; j++)
                        if (r[x, j] > r[x, j + 1])
                        {
                            int t = r[x, j + 1];
                            r[x, j + 1] = r[x, j];
                            r[x, j] = t;
                        }
                sum[x] = tp * (r[x, q - 1] - r[x, 0]);
                for (int i = 0; i < q; i++)
                {
                    tg = 4 + Random.Shared.NextDouble() * 3;
                    tg1[x, i] = tg;
                    sum[x] += tg;
                }
                textBox3.Text = sum[0].ToString("n") + " мин.";
                if (f == 0)
                {
                    // создаем список изображений для строк listView1
                    ImageList imageList = new ImageList();
                    // устанавливаем размер изображений
                    imageList.ImageSize = new Size(20, 20);

                    // заполняем список изображениями
                    for (int i = 0, j = 0; i < n; i++)
                    {
                        if (r[x, j] == i)
                        {
                            imageList.Images.Add(new Bitmap("Cont1.png"));
                            j++;
                            if (j == q)
                                j--;
                            continue;
                        }
                        imageList.Images.Add(new Bitmap("Cont2.png"));
                    }
                    // устанавливаем в listView1 список изображений imageList
                    listView1.SmallImageList = imageList;
                    for (int i = 0, j = 0; i < n; i++)
                    {
                        // создадим объект ListViewItem (строку) для listView1
                        ListViewItem listViewItem = new ListViewItem(new string[1]);

                        if (r[x, j] == i)
                        {
                            listViewItem.Text = "№" + (i + 1).ToString() + ", t=" + String.Format("{0:.###}", tg1[x, j]);
                            listViewItem.ImageIndex = i;
                            listView1.Items.Add(listViewItem);
                            j++;
                            if (j == q)
                                j--;
                            continue;
                        }
                        listViewItem.Text = "№" + (i + 1).ToString();
                        // индекс изображения из imageList для данной строки listViewItem
                        listViewItem.ImageIndex = i;

                        // добавляем созданный элемент listViewItem (строку) в listView1
                        listView1.Items.Add(listViewItem);
                    }
                    f = 1;
                    flag = 1;
                    FileActive = 0;
                    comboBox1.Text = "Станция №1";
                }
            }
            double sum1 = 0;
            for (int i = 0; i < sum.Length; i++)
                sum1 += sum[i];
            textBox5.Text = sum1.ToString("n") + " мин.";
            textBox6.Text = (sum1 / sum.Length).ToString("n") + " мин.";
            записьДанныхВФайлToolStripMenuItem.Visible = true;
        }

        private void записьДанныхВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum1 = 0, SQotR = 0, Rsr = 0, sumQotR = 0, sumQotT = 0, SQotT = 0, Tsr = 0, Tmin = sum[0], Tmax = sum[0];
            int sumR = 0, sumN = 0, sumQ = 0;
            for (int i = 0; i < stan; i++)
            {
                sum1 += sum[i];
                sumR += r[i, qq[i] - 1] - r[i, 0];
                sumN += nn[i];
                sumQ += qq[i];
                if (sum[i] < Tmin)
                    Tmin = sum[i];
                if (sum[i] > Tmax)
                    Tmax = sum[i];
            }
            Tsr = sum1 / stan;
            Rsr = (double)sumR / stan;
            StreamWriter sw = new StreamWriter("Result.txt", true, Encoding.UTF8);
            StreamWriter shortw = new StreamWriter("ShortResult.txt", true, Encoding.UTF8);
            sw.WriteLine("Моделирование " + stan.ToString() + " станций");
            for (int i = 0; i < stan; i++)
            {
                sw.Write("Станция №" + (i + 1).ToString() + " q = " + qq[i].ToString() +
                    " n = " + nn[i].ToString() + " r[0] = " + (r[i, 0] + 1) + " r[q - 1] = " +
                    (r[i, qq[i] - 1] + 1) + " количество проезжаемых мест: " + (r[i, qq[i] - 1] - r[i, 0]) +
                    " Время погрузки/разгрузки = " + sum[i].ToString("n") + "\n");
                sumQotR += Math.Pow((r[i, qq[i] - 1] - r[i, 0] - Rsr), 2);
                sumQotT += Math.Pow((sum[i] - Tsr), 2);
            }
            SQotR = Math.Sqrt(sumQotR / (stan - 1));
            SQotT = Math.Sqrt(sumQotT / (stan - 1));
            sw.Write("Сумма по всем станциям: количество проезжаемых контейнеров = " + sumR + " полное время = " + sum1.ToString("n") +
                "\nСр. знач. по всем станциям: количество проезжаемых контейнеров = " + (double)(sumR) / stan + " полное время = " + (sum1 / stan).ToString("n") + "\n" + "\n");
            sw.Close();
            shortw.Write((double)(sumQ) / stan + " " +
                (double)(sumN) / stan + " " +
                stan.ToString() + " " +
                (double)(sumR) / stan + " " + SQotR + " " +
                sum1 / stan + " " + SQotT + " " + Tmin + " " + Tmax + " " + (Tmax - Tmin) + "\n");
            shortw.Close();
            MessageBox.Show("Операция выполнена успешно! Данные записаны в файл Result.txt", "Успех",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}