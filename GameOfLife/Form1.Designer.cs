﻿
namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.spnAlive = new System.Windows.Forms.NumericUpDown();
            this.spnColumns = new System.Windows.Forms.NumericUpDown();
            this.spnRows = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblAlive = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.grpRun = new System.Windows.Forms.GroupBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.spnAutoStop = new System.Windows.Forms.NumericUpDown();
            this.chkAutoStop = new System.Windows.Forms.CheckBox();
            this.btnOneGen = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtGrid = new System.Windows.Forms.TextBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.grpSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnAlive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRows)).BeginInit();
            this.grpRun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnAutoStop)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSetup
            // 
            this.grpSetup.Controls.Add(this.spnAlive);
            this.grpSetup.Controls.Add(this.spnColumns);
            this.grpSetup.Controls.Add(this.spnRows);
            this.grpSetup.Controls.Add(this.btnCreate);
            this.grpSetup.Controls.Add(this.lblColumns);
            this.grpSetup.Controls.Add(this.lblAlive);
            this.grpSetup.Controls.Add(this.lblRows);
            this.grpSetup.Location = new System.Drawing.Point(27, 22);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Size = new System.Drawing.Size(265, 228);
            this.grpSetup.TabIndex = 0;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "Setup Tools";
            // 
            // spnAlive
            // 
            this.spnAlive.Location = new System.Drawing.Point(139, 112);
            this.spnAlive.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.spnAlive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnAlive.Name = "spnAlive";
            this.spnAlive.Size = new System.Drawing.Size(120, 23);
            this.spnAlive.TabIndex = 3;
            this.spnAlive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spnColumns
            // 
            this.spnColumns.Location = new System.Drawing.Point(139, 79);
            this.spnColumns.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spnColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnColumns.Name = "spnColumns";
            this.spnColumns.Size = new System.Drawing.Size(120, 23);
            this.spnColumns.TabIndex = 2;
            this.spnColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spnRows
            // 
            this.spnRows.Location = new System.Drawing.Point(139, 44);
            this.spnRows.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.spnRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnRows.Name = "spnRows";
            this.spnRows.Size = new System.Drawing.Size(120, 23);
            this.spnRows.TabIndex = 1;
            this.spnRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(24, 145);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Grid";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(24, 79);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(55, 15);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns";
            // 
            // lblAlive
            // 
            this.lblAlive.AutoSize = true;
            this.lblAlive.Location = new System.Drawing.Point(24, 112);
            this.lblAlive.Name = "lblAlive";
            this.lblAlive.Size = new System.Drawing.Size(80, 15);
            this.lblAlive.TabIndex = 1;
            this.lblAlive.Text = "Number Alive";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(24, 44);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(35, 15);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows";
            // 
            // grpRun
            // 
            this.grpRun.Controls.Add(this.txtGenerations);
            this.grpRun.Controls.Add(this.lblGenerations);
            this.grpRun.Controls.Add(this.spnAutoStop);
            this.grpRun.Controls.Add(this.chkAutoStop);
            this.grpRun.Controls.Add(this.btnOneGen);
            this.grpRun.Controls.Add(this.btnStop);
            this.grpRun.Controls.Add(this.btnStart);
            this.grpRun.Enabled = false;
            this.grpRun.Location = new System.Drawing.Point(27, 279);
            this.grpRun.Name = "grpRun";
            this.grpRun.Size = new System.Drawing.Size(265, 240);
            this.grpRun.TabIndex = 1;
            this.grpRun.TabStop = false;
            this.grpRun.Text = "Run Tools";
            this.grpRun.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtGenerations
            // 
            this.txtGenerations.Enabled = false;
            this.txtGenerations.Location = new System.Drawing.Point(153, 206);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(75, 23);
            this.txtGenerations.TabIndex = 99;
            this.txtGenerations.TabStop = false;
            this.txtGenerations.Text = "0";
            this.txtGenerations.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(22, 206);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(131, 15);
            this.lblGenerations.TabIndex = 7;
            this.lblGenerations.Text = "Number of Generations";
            this.lblGenerations.Click += new System.EventHandler(this.label1_Click);
            // 
            // spnAutoStop
            // 
            this.spnAutoStop.Location = new System.Drawing.Point(153, 109);
            this.spnAutoStop.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.spnAutoStop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnAutoStop.Name = "spnAutoStop";
            this.spnAutoStop.Size = new System.Drawing.Size(75, 23);
            this.spnAutoStop.TabIndex = 7;
            this.spnAutoStop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnAutoStop.ValueChanged += new System.EventHandler(this.spnAutoStop_ValueChanged);
            // 
            // chkAutoStop
            // 
            this.chkAutoStop.AutoSize = true;
            this.chkAutoStop.Location = new System.Drawing.Point(25, 113);
            this.chkAutoStop.Name = "chkAutoStop";
            this.chkAutoStop.Size = new System.Drawing.Size(79, 19);
            this.chkAutoStop.TabIndex = 6;
            this.chkAutoStop.Text = "Auto Stop";
            this.chkAutoStop.UseVisualStyleBackColor = true;
            // 
            // btnOneGen
            // 
            this.btnOneGen.Location = new System.Drawing.Point(24, 64);
            this.btnOneGen.Name = "btnOneGen";
            this.btnOneGen.Size = new System.Drawing.Size(132, 23);
            this.btnOneGen.TabIndex = 5;
            this.btnOneGen.Text = "One Generation";
            this.btnOneGen.UseVisualStyleBackColor = true;
            this.btnOneGen.Click += new System.EventHandler(this.btnOneGen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(153, 161);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(29, 161);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtGrid
            // 
            this.txtGrid.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGrid.Location = new System.Drawing.Point(370, 22);
            this.txtGrid.Multiline = true;
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.Size = new System.Drawing.Size(651, 497);
            this.txtGrid.TabIndex = 10;
            this.txtGrid.Text = "XOXOXOXOXO";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 500;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 549);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.grpRun);
            this.Controls.Add(this.grpSetup);
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnAlive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnRows)).EndInit();
            this.grpRun.ResumeLayout(false);
            this.grpRun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnAutoStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.GroupBox grpRun;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.NumericUpDown spnAlive;
        private System.Windows.Forms.NumericUpDown spnColumns;
        private System.Windows.Forms.NumericUpDown spnRows;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblAlive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOneGen;
        private System.Windows.Forms.CheckBox chkAutoStop;
        private System.Windows.Forms.NumericUpDown spnAutoStop;
        private System.Windows.Forms.TextBox txtGrid;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.TextBox txtGenerations;
    }
}

