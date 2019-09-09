using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSESC.SM
{
    public partial class SMKonstr : Form
    {
        public SMKonstr()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SMPanels sMPanels = new SMPanels();
            sMPanels.Show();
        }
    }
}
