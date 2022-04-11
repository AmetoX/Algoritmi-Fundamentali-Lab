using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgFun_Laborator_
{
    public partial class Form1 : Form
    {
        Bitmap sursa;
        Bitmap destinatie;
        Bitmap sursa2;
        Bitmap destinatie2;
        //Bitmap save;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sursa = new Bitmap(Image.FromFile(@"../../Resurse/123.png"));
            destinatie = new Bitmap(sursa.Width, sursa.Height);
            pictureBox1.Image = sursa;
            sursa2 = new Bitmap(Image.FromFile(@"../../Resurse/1234.png"));
            destinatie2 = new Bitmap(sursa2.Width, sursa2.Height);
            pictureBox2.Image = sursa2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    Td = Color.FromArgb(r, g, b);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox1.Image = destinatie;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa2.Width; i++)
            {
                for (int j = 0; j < sursa2.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Ts2 = sursa2.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    int r2 = Ts2.R;
                    int g2 = Ts2.G;
                    int b2 = Ts2.B;
                    int r12 = (r+ r2) / 2;
                    int g12 = (g+ g2) / 2;
                    int b12 = (b+ b2) / 2;
                    Td = Color.FromArgb(r12, g12, b12);
                    destinatie2.SetPixel(i, j, Td);
                }
            }
            pictureBox3.Image = destinatie2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            destinatie2.Save(@"../../Resurse/12345.png");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sursa.Width; i++)
            {
                for (int j = 0; j < sursa.Height; j++)
                {
                    Color Ts = sursa.GetPixel(i, j);
                    Color Td;
                    int r = Ts.R;
                    int g = Ts.G;
                    int b = Ts.B;
                    Td = Color.FromArgb(r, g, b);
                    nustiu(Ts,Td);
                    destinatie.SetPixel(i, j, Td);
                }
            }
            pictureBox1.Image = destinatie;
        }
        private Color nustiu (Color ts,Color td)
        {
            if (ts.R < 10 && ts.G < 10 && ts.B < 10)
            {
                
            }
            return td;
        }
    }
}
