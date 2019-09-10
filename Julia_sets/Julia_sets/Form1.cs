using System;
using System.Collections.Generic;
using System.Numerics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Julia_sets
{
    public partial class juliaSetForm : Form
    {
        public juliaSetForm()
        {
            InitializeComponent();
        }

        private static int i;

        private void DrawSet(double cZero, double cOne){
            Bitmap bm = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);

                int threshold;
                int i, j, k;
                double ax, ay, bx, by;
                bx = 0;
                by = 0;

                //starting point run
                threshold = 20;


                //begin loop
                //iterate through every pixel
                for (i = 0; i < picCanvas.ClientSize.Width; i++)
                {
                    for (j = 0; j < picCanvas.ClientSize.Height; j++)
                    {
                        ax = -2.0 + i * (4.0 / picCanvas.ClientSize.Width);
                        ay = -2.0 + j * (4.0 / picCanvas.ClientSize.Height);

                        //try 4096 iterations
                        for (k = 0; k < 4096; k++)
                        {
                            if (((ax * ax) + (ay * ay) >= threshold))
                                break;

                            bx = (ax * ax) - (ay * ay) + cZero;
                            by = 2 * ax * ay + cOne;

                            //move forward
                            ax = bx;
                            ay = by;
                        }
                        //check if converge and paint the pixel blue
                        if (((ax * ax) + (ay * ay) < threshold))
                        {
                            bm.SetPixel(i, j, Color.Blue);
                        }
                        else
                            bm.SetPixel(i, j, Color.Red);

                    }
                }
                picCanvas.Image = bm;
            }
        }

        private void UserCoeff_Click(object sender, EventArgs e)
        {
            double czero, cone;
            czero = Convert.ToDouble(c0UserValue.Text);
            cone = Convert.ToDouble(c1UserValue.Text);
            DrawSet(czero, cone);            
        }

        private void runDefaultValue(object sender, EventArgs e)
        {
            double[,] defaultValues = new double[9, 2] { { -0.74543, 0.11301},{ 0.32, 0.043},{ 0.27334, 0.00742},{ -1.25,1},
                    { 0.11,0.6557}, { 0.11031,0.67037},{ 0,1},{ -0.194,0.6557},{ -0.15652,1.03225} };
            i++;

            double valueTemp;

            valueTemp = defaultValues[(i % 9), 0];
            c0UserValue.Text = valueTemp.ToString();

            valueTemp = defaultValues[(i % 9), 1];
            c1UserValue.Text = valueTemp.ToString();

            DrawSet(defaultValues[(i%9), 0], defaultValues[(i%9), 1]);
        }

    }
}
