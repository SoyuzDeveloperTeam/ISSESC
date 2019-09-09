using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * На главной странице РС МКС с возможостью вращения
 * при нажати на модуль показывается сам модуль и две кнопки - внешняя и внутренняя компоновка
 * если внутри, то АКС - под улом показывается с вилом на стол, или же с другогго угла
 * внешняя простос возможностью вращения + фото
 * описание типа подсказок или вспылвающих форм
 * ДИНАМИКА
 */

namespace ISSESC
{
    public partial class MainForm : Form
    {
        //SMMain SMMaain = new SMMain();
        CO.SOMain SOMain = new CO.SOMain();
        FGB.FGBMain FGBMain = new FGB.FGBMain();


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SMMain sMMain = new SMMain();
            sMMain.Show();
            this.Visible = false;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            SOMain.Show();
            this.Visible = false;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FGBMain.Show();
            this.Visible = false;
        }
    }
}
