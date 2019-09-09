using System;
using System.Collections.Generic;
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
        
        private void UserCoeff_Click(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.Red);

                int px, py,threshold;
                int i,j,k;
                double ax, ay, bx, by, cx, cy;
                decimal czero, cone;
                bx = 0;
                by = 0;
                px = 0;
                py = 0;
                czero = c0UserValue.Value;
                cone = c1UserValue.Value;

                //starting point run
                threshold = 20;

                    
                //begin loop
                //iterate through every pixel
                for(i=0;i<600;i++)
                {
                    for(j=0; j<600;j++)
                    {
                        ax = -2.0 + i * (4.0 / picCanvas.ClientSize.Width);
                        ay = -2.0 + j * (4.0 / picCanvas.ClientSize.Height);

                        //try 4096 iterations
                        for (k = 0; k < 4096; k++)
                        {
                            bx = (ax * ax) - (ay * ay) + Decimal.ToDouble(czero);
                            by = 2 * ax * ay + Decimal.ToDouble(cone);

                            //check if converge and paint the pixel blue
                            if (((bx * bx) + (by * by) < threshold) && bx > -2 && bx < 2 && by > -2 && by < 2)
                            {
                                px = Convert.ToInt32((bx + 2) * (picCanvas.ClientSize.Width / 4));
                                py = Convert.ToInt32((by + 2) * (picCanvas.ClientSize.Height / 4));
                                if (px < picCanvas.ClientSize.Width && py < picCanvas.ClientSize.Height)
                                    bm.SetPixel(px, py, Color.Blue);
                            }

                            //break loop if diverge >> threshold                           
                            if (((bx * bx) + (by * by) > threshold))
                                break;
                            
                            //move forward
                            ax = bx;
                            ay = by;
                        }
                    }
                }
                    picCanvas.Image = bm;
            }
        }

        private void runDefaultValue(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(picCanvas.ClientSize.Width, picCanvas.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.Red);

                int px, py, threshold;
                int i, j, k;
                double ax, ay, bx, by, cx, cy;
                decimal czero, cone;
                bx = 0;
                by = 0;
                px = 0;
                py = 0;
                czero = 0;
                cone = 1;

                //starting point run
                threshold = 20;


                //begin loop
                //iterate through every pixel
                for (i = 0; i < 600; i++)
                {
                    for (j = 0; j < 600; j++)
                    {
                        ax = -2.0 + i * (4.0 / picCanvas.ClientSize.Width);
                        ay = -2.0 + j * (4.0 / picCanvas.ClientSize.Height);

                        //try 4096 iterations
                        for (k = 0; k < 4096; k++)
                        {
                            bx = (ax * ax) - (ay * ay) + Decimal.ToDouble(czero);
                            by = 2 * ax * ay + Decimal.ToDouble(cone);

                            //check if converge and paint the pixel blue
                            if (((bx * bx) + (by * by) < threshold) && bx > -2 && bx < 2 && by > -2 && by < 2)
                            {
                                px = Convert.ToInt32((bx + 2) * (picCanvas.ClientSize.Width / 4));
                                py = Convert.ToInt32((by + 2) * (picCanvas.ClientSize.Height / 4));
                                if (px < picCanvas.ClientSize.Width && py < picCanvas.ClientSize.Height)
                                    bm.SetPixel(px, py, Color.Blue);
                            }

                            //break loop if diverge >> threshold                           
                            if (((bx * bx) + (by * by) > threshold))
                                break;

                            //move forward
                            ax = bx;
                            ay = by;
                        }
                    }
                }
                picCanvas.Image = bm;
            }
        }

    }
}
