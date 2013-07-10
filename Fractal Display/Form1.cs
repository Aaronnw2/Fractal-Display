using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fractal_Display
{
    public partial class Form1 : Form
    {
        public static Bitmap drawfractal()
        {
            Bitmap graphImage = new Bitmap(750, 500);

            return graphImage;
        }

        public bool maxSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxSelected = false;
            Bitmap graphImage = new Bitmap(750, 500);
            Fractal testFractal = new Fractal(100, 2.5, -1, 1, -1);
            txtIterations.Text = Convert.ToString(100);
            txtXMax.Text = Convert.ToString(2.5);
            txtXMin.Text = Convert.ToString(-1);
            txtYMax.Text = Convert.ToString(1);
            txtYMin.Text = Convert.ToString(-1);
            for (int i = 0; i < 750; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    if (testFractal.grapharray[i, j] == -1)
                        graphImage.SetPixel(i, j, Color.Black);
                    else
                        if (testFractal.grapharray[i, j] == 0)
                            graphImage.SetPixel(i, j, Color.SteelBlue);
                        if(testFractal.grapharray[i,j] == 1)
                            graphImage.SetPixel(i, j, Color.Teal);
                        if (testFractal.grapharray[i, j] == 2)
                            graphImage.SetPixel(i, j, Color.SkyBlue);
                        if(testFractal.grapharray[i,j] > 2)
                            graphImage.SetPixel(i, j, Color.FromArgb(Color.Blue.ToArgb() + 75 + testFractal.grapharray[i, j]));
                }
            }
            pictureBox1.Image = graphImage;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //not correct values
            if (maxSelected == false)
            {
                txtXMax.Text = Convert.ToString(750 - e.X);
                txtYMax.Text = Convert.ToString(500 - e.Y);
                maxSelected = true;
            }
            else
            {
                txtXMin.Text = Convert.ToString(750 - e.X);
                txtYMin.Text = Convert.ToString(500 - e.Y);
                maxSelected = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
