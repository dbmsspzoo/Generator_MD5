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
    public partial class oProgramie : UserControl
    {
        public oProgramie()
        {
            InitializeComponent();
        }

        private void oProgramieLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dbms.com.pl/polityka-zarzadzania-danymi/");
        }
    }
}
