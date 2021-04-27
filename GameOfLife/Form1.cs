using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            grpRun.Enabled = true;
            txtGenerations.Text = "0";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grpSetup.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnOneGen.Enabled = false;
            tmrTimer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            grpSetup.Enabled = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnOneGen.Enabled = true;
            tmrTimer.Enabled = false;
        }

        private void btnOneGen_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtGrid.Width = Form1.ActiveForm.Width - txtGrid.Left - 50;
            txtGrid.Height = Form1.ActiveForm.Height - txtGrid.Top - 50;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            txtGrid.Text = DateTime.Now.ToString();

            //increase the generation count
            int genCount;
            genCount = int.Parse(txtGenerations.Text);
            genCount = genCount + 1;
            txtGenerations.Text = genCount.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
