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
            if (parent_a.Text == "-" || go.Text == "Continue")
            {
                inside = new Inside(Convert.ToInt32(memNum.Text));
                refresh.Enabled = true;
                reset.Enabled = true;
                go.Text = "pause";
            }
            else
            {
                refresh.Enabled = false;
                go.Enabled = true;
                go.Text = "Continue";
            }
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
        }

        private void mutationRate_ValueChanged(object sender, EventArgs e)
        {
            mutationRatePercentage.Text = Convert.ToString(mutationRate.Value) + " %";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            refresh.Enabled = false;
            parent_a.Text = "-";
            parent_b.Text = "-";
            parent_c.Text = "-";
            accuracy.Text = "-";
            reset.Enabled = false;
            go.Text = "Let's go!";
            inside = new Inside(Convert.ToInt32(memNum.Text));
        }
    }
}
