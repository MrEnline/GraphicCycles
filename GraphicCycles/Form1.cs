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
        }

        public void VerticallLines()
        {
            for (int x = 0; x <= 300; x += 30)
            {
                graphics.DrawLine(pen, x, 0, x, 300);
                Sleep(100);
            }
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
                            Sleep(100);
                        }
                    }
                }
            }
        }

        public void CosinusSinus()
        {
            for (int alpha = 0; alpha < 360; alpha+=10)
            {
                graphics.DrawLine(pen, 150, 150, 
                                            150 + (float)Math.Cos(alpha/180.0*Math.PI) * 150, 
                                            150 - (float)Math.Sin(alpha/180.0*Math.PI) * 150);
                Sleep(100);
            }
        }

        public void SpiralOfArkhimed()
        {
            float x = 150f;
            float y = 150f;
            float x1, y1;
            float r = 0;
            for (int alpha = 0; alpha <= 360*6; alpha += 20)
            {
                //r += 1f;
                //радиус спирали, который увеличивается в зависимости от угла
                r = alpha / 20f;            
                //alpha / 180.0 * Math.PI - перевод в радианы для SIN и COS
                x1 = 150 + (float)Math.Cos(alpha / 180.0 * Math.PI) * r;
                y1 = 150 - (float)Math.Sin(alpha / 180.0 * Math.PI) * r;
                graphics.DrawLine(pen, x, y, x1,y1);
                //запоминаем текущие координаты и делаем их центром на следующей итерации
                x = x1;
                y = y1;
                Sleep(1);
            }
        }

        public void ArcLine(float alfa, float beta)
        {
            float x1 = 150 + (float)Math.Cos(alfa / 180 * Math.PI) * 150;
            float y1 = 150 - (float)Math.Sin(alfa / 180 * Math.PI) * 150;
            float x2 = 150 + (float)Math.Cos(beta / 180 * Math.PI) * 150;
            float y2 = 150 - (float)Math.Sin(beta / 180 * Math.PI) * 150;
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        public void Spirograph()
        {
            bool flag;
            int radiusB, penPosition;
            float x, y;
            flag = CheckNumber(RadiusB.Text) && CheckNumber(PenPosition.Text);
            if (!flag)
                return;

            //radiusA = Int32.Parse(RadiusA.Text);
            radiusB = Int32.Parse(RadiusB.Text);
            penPosition = Int32.Parse(PenPosition.Text);
            x = 0;
            y = 0;

            for (int alfa = 0; alfa < 360*4; alfa+=10)
            {
                float x1 = 150 + (float)(150 - radiusB) * (float)Math.Cos(alfa / 180 * Math.PI)*150 + penPosition*(float)Math.Cos(((150 - radiusB)/radiusB)*(alfa / 180 * Math.PI)) * 150;
                float y1 = 150 + (float)(150 - radiusB) * (float)Math.Sin(alfa / 180 * Math.PI) * 150 - penPosition * (float)Math.Sin(((150 - radiusB) / radiusB) * (alfa / 180 * Math.PI)) * 150;

                graphics.DrawLine(pen, x, y, x1, y1);
                x = x1;
                y = y1;
                //Sleep(100);
                Refresh();
            }
        }

        private bool CheckNumber(string inputNumber)
        {
            int temp;
            try
            {
                temp = Int32.Parse(inputNumber);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return false;
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

        private void buttonCosinusSinus_Click(object sender, EventArgs e)
        {
            CosinusSinus();
        }

        private void buttonSpiralOfArkhimed_Click(object sender, EventArgs e)
        {
            SpiralOfArkhimed();
        }

        private void buttonArcLine_Click(object sender, EventArgs e)
        {
            int total = 180;
            int koeff = 2;
            //int koeff = 30;
            //for (int n = 0; n < total; n++)
            //{
            //    ArcLine(n, n * koeff);
            //    Sleep(100);
            //}
            try
            {
                koeff = int.Parse(Koeff.Text);
            }
            catch (Exception)
            {
                
                koeff = 2;
            }

            for (int n = 0; n < total; n++)
            {
                ArcLine(2*n, 2*n * koeff);
                Sleep(20);
            }

            //ArcLine(0, 90);
            //ArcLine(90, 180);
            //ArcLine(180, 270);
            //ArcLine(270, 360);
            //ArcLine(0,  180);
        }

        private void buttonAllArcLine_Click(object sender, EventArgs e)
        {
            int total = 180;
            for (float koeff = 2; koeff < total; koeff+=0.1f)
            {
                Sleep(100);
                Clear();
                Counter.Text = koeff.ToString();
                for (int n = 0; n < total; n++)
                {
                    ArcLine(2 * n, 2 * n * koeff);
//                    Sleep(20);
                }
                Refresh();
            }
        }

        private void buttonSpirograph_Click(object sender, EventArgs e)
        {
            Spirograph();
        }
    }
}
