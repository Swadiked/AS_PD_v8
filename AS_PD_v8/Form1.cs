using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_PD_v8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ienakum_ValueChanged(object sender, EventArgs e)
        {
            int ienakum = Convert.ToInt32(Math.Round(papildienakum.Value, 0));

        }
        public void ienakumi(int ienakum, int papildienakum)
        {
            int summa = ienakum + papildienakum;
            
           
        }

        public void rekinat_Click(object sender, EventArgs e)
        {
            summa.Text = ienakum.Value + papildienakum.Value;

        }

        private void papildienakum_ValueChanged(object sender, EventArgs e)
        {
            int papildienakum = Convert.ToInt32(Math.Round(ienakum.Value, 0));
        }

        private void izdevum_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
