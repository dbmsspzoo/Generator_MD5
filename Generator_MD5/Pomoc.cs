using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_MD5
{
    public partial class Pomoc : UserControl
    {
        public Pomoc()
        {
            InitializeComponent();
            oProgramie1.BringToFront();
        }

        private void oPorgramieBtn_Click(object sender, EventArgs e)
        {
            oProgramie1.BringToFront();
        }

        private void instrukcjaBtn_Click(object sender, EventArgs e)
        {
            instrukcja1.BringToFront();
        }

        private void oWydawcyBtn_Click(object sender, EventArgs e)
        {
            oWydawcy1.BringToFront();
        }

        private void kontaktBtn_Click(object sender, EventArgs e)
        {
            kontakt1.BringToFront();
        }

    }
}
