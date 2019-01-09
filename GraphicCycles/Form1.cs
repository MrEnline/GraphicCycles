using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicCycles
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            InitGraph();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void InitGraph()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            graphics = Graphics.FromImage(pictureBox1.Image);
            pen = new Pen(Color.DarkRed);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            graphics.Clear(pictureBox1.BackColor);
            Refresh();
        }

        public void Sleep(int time)
        {
            Refresh();
            Thread.Sleep(time);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graphics.DrawLine(pen, 0, 0, 300, 300);
            graphics.DrawLine(pen, 300, 0, 0, 300);
            Refresh();
        }

        public void HorizontalLines()
        {
            for (int y = 0; y <= 300; y+=30)
            {
                graphics.DrawLine(pen, 0, y, 300, y);
                Sleep(100);
            }
            Refresh();
        }

        public void VerticallLines()
        {
            for (int x = 0; x <= 300; x += 30)
            {
                graphics.DrawLine(pen, x, 0, x, 300);
                Sleep(100);
            }
            Refresh();
        }

        public void AllLines()
        {
            for (int x = 0; x <= 300; x += 30)
            {
                graphics.DrawLine(pen, x, 0, x, 300);
                int y = x;
                graphics.DrawLine(pen, 0, y, 300, y);
                Sleep(100);
            }
            Refresh();
        }

        public void DiagLines()
        {

            //либо 2 цикла сделать
            for (int r = 0; r < 300; r+=30)
            {
                graphics.DrawLine(pen, 0, r, r, 0);
                //graphics.DrawLine(pen, 300, r, r, 300);
                graphics.DrawLine(pen, r, 300, 300, r);
                Sleep(200);
            }
            Refresh();
        }

        public void ConeOfRays()
        {
            for (int y = 0; y <= 300; y+=10)
                graphics.DrawLine(pen, 0, y, 300, 0);
            for (int y = 0; y <= 300; y += 10)
                graphics.DrawLine(pen, 0, 300, 300, y);
            Refresh();
        }

        public void ConeOfRays1()
        {
            for (int z = 0; z <= 300; z+=10)
            {
                graphics.DrawLine(pen, 0, 300, z, 0);
                graphics.DrawLine(pen, 0, 300, 300, z);
                Sleep(100);
            }

            for (int z = 0; z <= 300; z += 10)
            {
                graphics.DrawLine(pen, 300, 0, 0, z);
                graphics.DrawLine(pen, 300, 0, z, 300);
                Sleep(100);
            }

            for (int z = 0; z <= 300; z+=10)
            {
                graphics.DrawLine(pen, 0, 0, 300, z);
                graphics.DrawLine(pen, 0, 0, z, 300);
                Sleep(100);
            }

            for (int z = 300; z >= 0; z-=10)
            {
                graphics.DrawLine(pen, 300, 300, 0, z);
                graphics.DrawLine(pen, 300, 300, z, 0);
                Sleep(100);
            }                     
            Refresh();
        }

        public void Squares()
        {

            for (int y = 0; y < 300; y+=30)
            {
                for (int x = 0; x < 300; x += 30)
                {
                    graphics.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep(20);
                }
            }
            Refresh();
        }

        public void Squares1()
        {

            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {
                    if (x == 0 || x == 270 || y == 0 || y == 270)
                    {
                        graphics.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                        Sleep(20);
                    }
                }
            }
            Refresh();
        }

        public void CreateTracery()
        {
            for (int z = 0; z <= 300; z+=30)
            {
                if ((z == 120 || z == 150))
                    continue;
                graphics.DrawRectangle(pen, z + 3, z + 3, 24, 24);
                graphics.DrawRectangle(pen, 270 - z + 3, z + 3, 24, 24);
                graphics.DrawRectangle(pen, z+3, 153, 24, 24);
                graphics.DrawRectangle(pen, z+3, 123, 24, 24);
                graphics.DrawRectangle(pen, 153, z + 3, 24, 24);
                graphics.DrawRectangle(pen, 123, z + 3, 24, 24);
                Sleep(100);
            }
            Refresh();
        }

        public void CreateTracery1()
        {
            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {
                    if ((x == 120 || x == 150) && (y == 120 || y == 150))
                        continue;
                    if (x == y || 270 - x == y || x == 150 || x == 120 || y == 120 || y == 150)
                    {
                        graphics.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                        Sleep(20);
                    }
                }
            }
            Refresh();
        }

        public void LinesInSquares()
        {

            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {
                    graphics.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep(10);
                    //интересный узор
                    //for (int z = 0; z < 24; z+=3)
                    //{
                    //    graphics.DrawLine(pen, x + 3 + z, y + 3, x + 3, y + 3 + z);
                    //}

                    for (int z = 0; z < 24; z += 3)
                    {
                        graphics.DrawLine(pen, x + 3 + z, y + 3, x + 3 + z, y + 27);
                        graphics.DrawLine(pen, x + 3, y + 3 + z, x + 27, y + 3 + z);
                        Sleep(3);
                    }
                }
            }
            Refresh();
        }

        public void CirclesInSquares()
        {
            for (int y = 0; y < 300; y += 30)
            {
                for (int x = 0; x < 300; x += 30)
                {
                    graphics.DrawRectangle(pen, x + 3, y + 3, 24, 24);
                    Sleep(10);
                    for (int xx = 6; xx < 24; xx += 6)
                    {
                        for (int yy = 6; yy < 24; yy += 6)
                        {
                            graphics.DrawEllipse(pen, x + xx, y + yy, 6, 6);
                        }
                    }
                }
            }
            Refresh();
        }

        private void buttonLines_Click(object sender, EventArgs e)
        {
            HorizontalLines();
            VerticallLines();
        }

        private void buttonAllLines_Click(object sender, EventArgs e)
        {
            AllLines();
        }

        private void buttonDiagLines_Click(object sender, EventArgs e)
        {
            DiagLines();
        }

        private void buttonConeOfRays_Click(object sender, EventArgs e)
        {
            ConeOfRays();
        }

        private void buttonConeOfRays1_Click(object sender, EventArgs e)
        {
            ConeOfRays1();
        }

        private void buttonSquares_Click(object sender, EventArgs e)
        {
            Squares();
        }

        private void buttonSquares1_Click(object sender, EventArgs e)
        {
            Squares1();
        }

        private void buttonTracery_Click(object sender, EventArgs e)
        {
            CreateTracery();
        }

        private void buttonTracery1_Click(object sender, EventArgs e)
        {
            CreateTracery1();
        }

        private void buttonLinesInSquares_Click(object sender, EventArgs e)
        {
            LinesInSquares();
        }

        private void buttonCirclesInSquares_Click(object sender, EventArgs e)
        {
            CirclesInSquares();
        }
    }
}
