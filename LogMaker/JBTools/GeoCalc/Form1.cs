using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            double xf = double.Parse(x1.Text) - double.Parse(x2.Text);
            double yf = double.Parse(y1.Text) - double.Parse(y2.Text);

            double xs = Math.Pow(xf, 2);
            double ys = Math.Pow(yf, 2);

            double output1 = Math.Sqrt(xs + ys);

            output.Text = output1.ToString();
        }
    }
}
