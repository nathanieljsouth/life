﻿using System;
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
        //Variable to hold the grid
        Grid lifeGrid = new Grid();

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

            //Set up the properties of the grid
            lifeGrid.Rows = Convert.ToInt32(spnRows.Value);
            lifeGrid.Columns = Convert.ToInt32(spnColumns.Value);
            lifeGrid.AliveRequested = Convert.ToInt32(spnAlive.Value);

            try
            {
                //create the grid
                lifeGrid.createGrid();
                txtGrid.Text = lifeGrid.getGridDisplay();
            }
            catch (Exception errorMessage)
            {
                MessageBox.Show(errorMessage.Message);
                
            }

            //enable the 'run' controls
            grpRun.Enabled = true;

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
            lifeGrid.processOneGeneration();
            txtGrid.Text = lifeGrid.getGridDisplay();
            updateGenerationCount();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtGrid.Width = Form1.ActiveForm.Width - txtGrid.Left - 50;
            txtGrid.Height = Form1.ActiveForm.Height - txtGrid.Top - 50;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lifeGrid.processOneGeneration();

            txtGrid.Text = lifeGrid.getGridDisplay();

            updateGenerationCount();

        }

        private void updateGenerationCount()
        {
            //increase the generation count
            txtGenerations.Text = lifeGrid.Generations.ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void spnAutoStop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void spnInterval_ValueChanged(object sender, EventArgs e)
        {
            tmrTimer.Interval = Convert.ToInt32(spnInterval.Value);
        }
    }
}
