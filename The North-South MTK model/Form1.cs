using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using static WinFormsApp1.Form1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private Form active;

        sealed public class Node
        {
            public List<Link> Links { get; set; }

            public Node()
            {
                Links = new List<Link>();
            }
        }
        sealed public class Link
        {
            public double Distance { get; set; }
            public string Node { get; set; }
        }
        sealed public class Description
        {
            public bool Visited { get; set; }
            public double Distance { get; set; }
            public string PreviousNode { get; set; }
            public Description()
            {
                Visited = false;
                Distance = double.PositiveInfinity;
                PreviousNode = null;
            }
        }
        sealed public class Graph
        {
            private Dictionary<string, Node> nodes;

            public Graph()
            {
                nodes = new Dictionary<string, Node>();
            }

            public void AddNode(string name)
            {
                nodes.Add(name, new Node());
            }

            public void AddLinkToNode(string start, string end, double distance, bool isOriented)
            {
                nodes[start].Links.Add(new Link { Node = end, Distance = distance });
                if (!isOriented)
                    nodes[end].Links.Add(new Link { Node = start, Distance = distance });
            }

            public double FindShortestDistance(string start, string end, out List<string> shortestPath)
            {
                // Алгоритм Дейкстры.
                Dictionary<string, Description> info = new Dictionary<string, Description>(this.nodes.Count);
                foreach (string current in this.nodes.Keys)
                    info.Add(current, new Description());
                info[start].Distance = 0;

                // Пока все вершины непосещенные.
                while (!info.Select(x => x.Value.Visited).Aggregate((x, y) => x & y))
                {
                    // Находим непосещенную вершину с минимальной меткой.
                    string current = info.Where(x => !x.Value.Visited
                            && x.Value.Distance == info.Where(y => !y.Value.Visited).Min(y => y.Value.Distance))
                            .First().Key;
                    // Находим все непосещенные соседние вершины для текущей вершины.
                    List<Link> neighbors = nodes[current].Links.Where(x => !info[x.Node].Visited).ToList();
                    // Рассматриваем новую длину пути для каждой соседней вершины.
                    foreach (Link link in neighbors)
                    {
                        double distance = info[current].Distance + link.Distance;
                        if (info[link.Node].Distance > distance)
                        {
                            info[link.Node].Distance = distance;
                            info[link.Node].PreviousNode = current;
                        }
                    }
                    // Отмечаем текущую вершину как посещенную.
                    info[current].Visited = true;
                }

                // Восстановление кратчайшего пути
                shortestPath = new List<string>();
                string node = end;
                while (node != start)
                {
                    shortestPath.Insert(0, node);
                    node = info[node].PreviousNode;
                }
                shortestPath.Insert(0, start);

                return info[end].Distance;
            }
        }

        // Класс точка - координаты
        public class CPoint
        {
            public double x { get; set; }
            public double y { get; set; }
            public CPoint(double _x, double _y)
            {
                x = _x;
                y = _y;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        Graph graph = new Graph();

        List<CPoint> ListP0 = new List<CPoint>();
        List<CPoint> ListP1 = new List<CPoint>();
        List<CPoint> ListP2 = new List<CPoint>();
        List<PointLatLng> points = new List<PointLatLng>(); //Лист с точками
        List<PointLatLng> points2 = new List<PointLatLng>(); //Лист с точками
        List<PointLatLng> points1 = new List<PointLatLng>(); //Лист с точками
        GMapOverlay m = new GMapOverlay("m");
        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            double lat, lon;
            lat = 46.467652;
            lon = 47.962433;
            gMapControl1.ContextMenuStrip = contextMenuStrip1;
            gMapControl1.Position = new PointLatLng(lat, lon);
            gMapControl1.Zoom = 6;
            gMapControl1.ShowCenter = false;
            GMapOverlay polyOverlay = new GMapOverlay("polygons"); //Оверлей
            GMapOverlay polyOverlay1 = new GMapOverlay("polygons"); //Оверлей
            gMapControl1.Overlays.Add(m);
            string[] ArrayOfStringsWithCoor = File.ReadAllLines(@"t.txt");
            string[] ArrayOfStringsWithCoor2 = File.ReadAllLines(@"m.txt");
            string[] ArrayOfStringsWithCoor5 = File.ReadAllLines(@"m2.txt");
            string[] ArrayOfStringsWithNames = File.ReadAllLines(@"n.txt");
            string[] ArrayOfStringsWithCoor4 = File.ReadAllLines(@"m1.txt");
            string[] ArrayOfStringsWithCoorS = File.ReadAllLines(@"s.txt");
            for (int i = 0; i < ArrayOfStringsWithNames.Length; i++)
                graph.AddNode(ArrayOfStringsWithNames[i]);
            int f = 0;
            double v;
            for (int i = 1; i < ArrayOfStringsWithCoor4.Length; i++)
            {
                if (i == 97 || i == 107 || i == 117 || i == 142 || i == 153 && f == 1)
                {
                    i++;
                }
                v = Convert.ToDouble(ArrayOfStringsWithCoorS[i - 1]);
                graph.AddLinkToNode(ArrayOfStringsWithCoor4[i - 1], ArrayOfStringsWithCoor4[i], v, false);
                if (i == 86)
                {
                    f = 1;
                    i++;
                }
            }
            for (int i = 0; i < ArrayOfStringsWithCoor2.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor2[i].Split(new char[] { ';' });
                points.Add(new PointLatLng(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ArrayOfStringsWithCoor5.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor5[i].Split(new char[] { ';' });
                points2.Add(new PointLatLng(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                ListP0.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP0.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP0[i].x, ListP0[i].y), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = ArrayOfStringsWithNames[i];
                m.Markers.Add(marker);
            }
            GMapPolygon polygon = new GMapPolygon(points, "mypolygon"); //Создаем полигон
            polygon.Stroke = new Pen(Color.Red, 1);
            polygon.Fill = new SolidBrush(Color.FromArgb(0, Color.Empty));
            polyOverlay.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay);
            GMapPolygon polygon1 = new GMapPolygon(points2, "mypolygon1"); //Создаем полигон
            polygon1.Stroke = new Pen(Color.Red, 1);
            polygon1.Fill = new SolidBrush(Color.FromArgb(0, Color.Empty));
            polyOverlay1.Polygons.Add(polygon1);
            gMapControl1.Overlays.Add(polyOverlay1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gMapControl1.Bearing += 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gMapControl1.Bearing -= 10;
        }
        int delay = 0;

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                delay++;
                if (delay == 10)
                {
                    int x = e.X;
                    int y = e.Y;
                    double lat, lng;
                    lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                    lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
                    label1.Text = Convert.ToString(lat);
                    label2.Text = Convert.ToString(lng);
                    delay = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void математическоеМоделированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            fr2.fr1 = this;
            Hide();
        }

        private void движениеПоездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMapOverlay o = new GMapOverlay("o");
            gMapControl1.Overlays.Add(o);
            string[] ArrayOfStringsWithCoor4 = File.ReadAllLines(@"p1.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor4.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor4[i].Split(new char[] { ';' });
                ListP1.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP1.Count; i++)
            {
                Image newImage = Image.FromFile("Train.png");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage, 60, 30));
                marker.ToolTip = new GMapRoundedToolTip(marker);
                gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                o.Markers.Add(marker);
                gMapControl1.Refresh();
                Thread.Sleep(300);
                o.Clear();
            }
            ListP1.Clear();
        }

        private void движениеПоездаПоВосточномуМаршрутуЧерезИнчеБарунToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMapOverlay o = new GMapOverlay("o");
            gMapControl1.Overlays.Add(o);
            string[] ArrayOfStringsWithCoor4 = File.ReadAllLines(@"p2.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor4.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor4[i].Split(new char[] { ';' });
                ListP1.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP1.Count; i++)
            {
                Image newImage = Image.FromFile("Train.png");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage, 60, 30));
                marker.ToolTip = new GMapRoundedToolTip(marker);
                gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                o.Markers.Add(marker);
                gMapControl1.Refresh();
                Thread.Sleep(300);
                o.Clear();
            }
            ListP1.Clear();
        }

        private void движениеПоездаПоЗападномуМаршрутуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMapOverlay o = new GMapOverlay("o");
            gMapControl1.Overlays.Add(o);
            string[] ArrayOfStringsWithCoor4 = File.ReadAllLines(@"p3.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor4.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor4[i].Split(new char[] { ';' });
                ListP1.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP1.Count; i++)
            {
                if (i >= 81 && i <= 84)
                {
                    Image newImage1 = Image.FromFile("Fura.png");
                    GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage1, 60, 45));
                    marker1.ToolTip = new GMapRoundedToolTip(marker1);
                    gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                    o.Markers.Add(marker1);
                    gMapControl1.Refresh();
                    Thread.Sleep(1000);
                    o.Clear();
                    continue;
                }
                Image newImage = Image.FromFile("Train.png");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage, 60, 30));
                marker.ToolTip = new GMapRoundedToolTip(marker);
                gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                o.Markers.Add(marker);
                gMapControl1.Refresh();
                Thread.Sleep(300);
                o.Clear();
            }
            ListP1.Clear();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gMapControl1.Zoom = hScrollBar1.Value;
        }

        GMapOverlay b = new GMapOverlay("b");
        GMapOverlay polyOverlay1 = new GMapOverlay("polygons1");

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Не выбран стартовая станция", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Не выбран конечная станция", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            b.Clear();
            ListP2.Clear();
            polyOverlay1.Clear();
            gMapControl1.Overlays.Add(b);
            gMapControl1.Refresh();
            string[] ArrayOfStringsWithCoor5 = File.ReadAllLines(@"n.txt");
            string[] ArrayOfStringsWithCoor6 = File.ReadAllLines(@"t.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor5.Length; i++)
            {
                if (comboBox1.Text == ArrayOfStringsWithCoor5[i] || comboBox2.Text == ArrayOfStringsWithCoor5[i])
                {
                    string[] OneStringWithCoor1 = ArrayOfStringsWithCoor6[i].Split(new char[] { ';' });
                    ListP2.Add(new CPoint(Convert.ToDouble(OneStringWithCoor1[0]), Convert.ToDouble(OneStringWithCoor1[1])));
                }
            }
            for (int i = 0; i < ListP2.Count; i++)
            {
                GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(ListP2[i].x, ListP2[i].y), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue);
                marker1.ToolTip = new GMapRoundedToolTip(marker1);
                b.Markers.Add(marker1);
            }
            double s = graph.FindShortestDistance(comboBox1.Text, comboBox2.Text, out List<string> shortestPath);
            int v = Random.Shared.Next(30, 120);
            double t1 = Math.Round(s / v, 4);
            textBox2.Text = "S: " + s.ToString() + " км.";
            textBox1.Text = "V: " + v.ToString() + " км/ч.";
            textBox3.Text = "T: " + t1.ToString() + " ч.";
            for (int i = 0; i < shortestPath.Count; i++)
            {
                for (int j = 0; j < ArrayOfStringsWithCoor5.Length; j++)
                    if (shortestPath[i] == ArrayOfStringsWithCoor5[j])
                    {
                        string[] OneStringWithCoor = ArrayOfStringsWithCoor6[j].Split(new char[] { ';' });
                        points1.Add(new PointLatLng(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                        ListP1.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                        break;
                    }
            }
            for (int i = shortestPath.Count - 1; i >= 0; i--)
            {
                for (int j = ArrayOfStringsWithCoor5.Length - 1; j >= 0; j--)
                    if (shortestPath[i] == ArrayOfStringsWithCoor5[j])
                    {
                        string[] OneStringWithCoor = ArrayOfStringsWithCoor6[j].Split(new char[] { ';' });
                        points1.Add(new PointLatLng(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                        break;
                    }
            }
            GMapPolygon polygon = new GMapPolygon(points1, "mypolygon"); //Создаем полигон
            polygon.Stroke = new Pen(Color.Blue, 2);
            polygon.Fill = new SolidBrush(Color.FromArgb(0, Color.Empty));
            polyOverlay1.Polygons.Add(polygon);
            gMapControl1.Overlays.Add(polyOverlay1);
            GMapOverlay t = new GMapOverlay("t");
            gMapControl1.Overlays.Add(t);
            int count = ListP1.Count;
            Image newImage, newImage1;
            GMarkerGoogle marker;
            for (int i = 0; i < count; i++)
            {
                if (shortestPath[i] == "Астара (Иран)" || shortestPath[i] == "Хаштпар" || shortestPath[i] == "Бендер-Энзели" || shortestPath[i] == "Решт")
                {
                    newImage1 = Image.FromFile("Fura.png");
                    GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage1, 60, 45));
                    marker1.ToolTip = new GMapRoundedToolTip(marker1);
                    gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                    t.Markers.Add(marker1);
                    gMapControl1.Refresh();
                    Thread.Sleep(1000);
                    t.Clear();
                    continue;
                }
                newImage = Image.FromFile("Train.png");
                marker = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage, 60, 30));
                marker.ToolTip = new GMapRoundedToolTip(marker);
                gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                t.Markers.Add(marker);
                gMapControl1.Refresh();
                Thread.Sleep(300);
                t.Clear();
                marker.Dispose();
            }
            ListP1.Clear();
            points1.Clear();
            text1 = comboBox1.Text;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void hScrollBar1_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m.Clear();
            ListP0.Clear();
            b.Clear();
            ListP2.Clear();
            polyOverlay1.Clear();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            m.Clear();
            ListP0.Clear();
            string[] ArrayOfStringsWithCoor = File.ReadAllLines(@"t.txt");
            string[] ArrayOfStringsWithCoor3 = File.ReadAllLines(@"n.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                ListP0.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP0.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP0[i].x, ListP0[i].y), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = ArrayOfStringsWithCoor3[i];
                m.Markers.Add(marker);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m.Clear();
            ListP0.Clear();
            string[] ArrayOfStringsWithCoor = File.ReadAllLines(@"t2.txt");
            string[] ArrayOfStringsWithCoor3 = File.ReadAllLines(@"n2.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                ListP0.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP0.Count; i++)
            {
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP0[i].x, ListP0[i].y), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = ArrayOfStringsWithCoor3[i];
                m.Markers.Add(marker);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (hScrollBar1.Value < hScrollBar1.Maximum)
            {
                hScrollBar1.Value += 1;
                gMapControl1.Zoom = hScrollBar1.Value;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (hScrollBar1.Value > hScrollBar1.Minimum)
            {
                hScrollBar1.Value -= 1;
                gMapControl1.Zoom = hScrollBar1.Value;
            }
        }
        string text1 = "";
        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string text = item.ToolTipText;
            if (text1 == "" || comboBox1.Text == "")
            {
                comboBox1.Text = text;
                text1 = text;
            }
            else
            {
                comboBox2.Text = text;
                text1 = "";
            }
        }

        private void моделированиеДвиженияПоТранскаспийскомуМаршрутуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GMapOverlay o = new GMapOverlay("o");
            gMapControl1.Overlays.Add(o);
            string[] ArrayOfStringsWithCoor4 = File.ReadAllLines(@"p4.txt");
            for (int i = 0; i < ArrayOfStringsWithCoor4.Length; i++)
            {
                string[] OneStringWithCoor = ArrayOfStringsWithCoor4[i].Split(new char[] { ';' });
                ListP1.Add(new CPoint(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
            }
            for (int i = 0; i < ListP1.Count; i++)
            {
                if (i >= 36 && i <= 39)
                {
                    Image newImage1 = Image.FromFile("boat.png");
                    GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage1, 50, 30));
                    marker1.ToolTip = new GMapRoundedToolTip(marker1);
                    gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                    o.Markers.Add(marker1);
                    gMapControl1.Refresh();
                    Thread.Sleep(1000);
                    o.Clear();
                    continue;
                }
                if (i >= 40 && i <= 41)
                {
                    Image newImage1 = Image.FromFile("Fura.png");
                    GMarkerGoogle marker1 = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage1, 60, 45));
                    marker1.ToolTip = new GMapRoundedToolTip(marker1);
                    gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                    o.Markers.Add(marker1);
                    gMapControl1.Refresh();
                    Thread.Sleep(1000);
                    o.Clear();
                    continue;
                }
                Image newImage = Image.FromFile("Train.png");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(ListP1[i].x, ListP1[i].y), new Bitmap(newImage, 60, 30));
                marker.ToolTip = new GMapRoundedToolTip(marker);
                gMapControl1.Position = new PointLatLng(ListP1[i].x, ListP1[i].y);
                o.Markers.Add(marker);
                gMapControl1.Refresh();
                Thread.Sleep(300);
                o.Clear();
            }
            ListP1.Clear();
        }
    }
}