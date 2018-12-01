using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parametersFinder
{
    public partial class Form1 : Form
    {
        Inside inside;
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            inside = new Inside(Convert.ToInt32(memNum.Text));
            refresh.Enabled = true;
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            inside.CalcFitness(Convert.ToDouble(x1.Text), Convert.ToDouble(x2.Text));
            inside.FindParents();
            inside.NextGen(mutationRate.Value / 100.0);
            parent_a.Text = Convert.ToString(inside.FirstParent.a);
            parent_b.Text = Convert.ToString(inside.FirstParent.b);
            parent_c.Text = Convert.ToString(inside.FirstParent.c);
            accuracy.Text = Convert.ToString(inside.FirstParent.fitness * -1);
            //percentage.Text = Convert.ToString(inside.FirstParent.fitness * -1)
        }

        private void mutationRate_ValueChanged(object sender, EventArgs e)
        {
            mutationRatePercentage.Text = Convert.ToString(mutationRate.Value) + " %";
        }
    }
}
