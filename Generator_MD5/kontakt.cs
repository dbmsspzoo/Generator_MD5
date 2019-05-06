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
    public partial class kontakt : UserControl
    {
        public kontakt()
        {
            InitializeComponent();
        }

        private void uruchomChatButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dmsales.com.?utm_source=dbms&utm_campaign=app&utm_term=pomoc");
        }
    }
}
