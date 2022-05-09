using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_Triunghi_Arie_Minima
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<Point> p = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"../../data.in");
            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                float x = int.Parse(buffer.Split(' ')[0]);
                float y = int.Parse(buffer.Split(' ')[1]);
                p.Add(new Point(x, y));                
            }
        }
        float det(Point a, Point b, Point c)
        {
            float t = a.x * b.y + b.x * c.y + c.x * a.y - c.x * b.y - c.x * a.x - a.y * b.x;
            return t;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float ariemin = 100000000;
            Pen cr = new Pen(Color.Black, 4);
            foreach (Point p in p)
            {
                g.DrawEllipse(cr, p.x, p.y, 3, 3);
            }
            float arie = 0;
            float x1 = 0;
            float y1 = 0;
            float x2 = 0;
            float y2 = 0;
            float x3 = 0;
            float y3 = 0;
            List<float> ariect = new List<float>();
            for (int i = 2; i < p.Count; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        arie = det(p[k], p[j], p[i]);
                        if (arie < 0)
                            arie *= -1;
                       arie /= 2;

                        ariect.Add(arie);

                            if (arie<=ariemin)
                            {
                                ariemin = arie;
                                x1 = p[k].x;
                                y1 = p[k].y;
                                x2 = p[j].x;
                                y2 = p[j].y;
                                x3 = p[i].x;
                                y3 = p[i].y;
                            }                                             
                    }
                }
            }
            g.DrawLine(cr, x1, y1, x2, y2);
            g.DrawLine(cr, x2, y2, x3, y3);
            g.DrawLine(cr, x3, y3, x1, y1);
        }
    }
}
