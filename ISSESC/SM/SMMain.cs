using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSESC
{
    public partial class SMMain : Form
    {
        MainForm MainForm = new MainForm();
        public SMMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Close();
        }

        private void SMMain_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SM.SMPanels smp = new SM.SMPanels();
            smp.Show();
        }
    }
}
