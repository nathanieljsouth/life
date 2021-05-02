
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.spnAlive = new System.Windows.Forms.NumericUpDown();
            this.spnColumns = new System.Windows.Forms.NumericUpDown();
            this.spnRows = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblAlive = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.grpRun = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberAlive = new System.Windows.Forms.TextBox();
            this.spnInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.lblGenerations = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.spnInterval)).BeginInit();
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
            this.grpSetup.Location = new System.Drawing.Point(39, 37);
            this.grpSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpSetup.Size = new System.Drawing.Size(379, 380);
            this.grpSetup.TabIndex = 0;
            this.grpSetup.TabStop = false;
            this.grpSetup.Text = "Setup Tools";
            // 
            // spnAlive
            // 
            this.spnAlive.Location = new System.Drawing.Point(219, 187);
            this.spnAlive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.spnAlive.Size = new System.Drawing.Size(107, 31);
            this.spnAlive.TabIndex = 3;
            this.spnAlive.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // spnColumns
            // 
            this.spnColumns.Location = new System.Drawing.Point(219, 132);
            this.spnColumns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.spnColumns.Size = new System.Drawing.Size(107, 31);
            this.spnColumns.TabIndex = 2;
            this.spnColumns.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // spnRows
            // 
            this.spnRows.Location = new System.Drawing.Point(219, 73);
            this.spnRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.spnRows.Size = new System.Drawing.Size(107, 31);
            this.spnRows.TabIndex = 1;
            this.spnRows.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.spnRows.ValueChanged += new System.EventHandler(this.spnRows_ValueChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(183, 272);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 38);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Grid";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(34, 132);
            this.lblColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(82, 25);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns";
            // 
            // lblAlive
            // 
            this.lblAlive.AutoSize = true;
            this.lblAlive.Location = new System.Drawing.Point(34, 187);
            this.lblAlive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlive.Name = "lblAlive";
            this.lblAlive.Size = new System.Drawing.Size(120, 25);
            this.lblAlive.TabIndex = 1;
            this.lblAlive.Text = "Number Alive";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(34, 73);
            this.lblRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(54, 25);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows";
            // 
            // grpRun
            // 
            this.grpRun.Controls.Add(this.label2);
            this.grpRun.Controls.Add(this.txtNumberAlive);
            this.grpRun.Controls.Add(this.spnInterval);
            this.grpRun.Controls.Add(this.label1);
            this.grpRun.Controls.Add(this.txtGenerations);
            this.grpRun.Controls.Add(this.lblGenerations);
            this.grpRun.Controls.Add(this.btnOneGen);
            this.grpRun.Controls.Add(this.btnStop);
            this.grpRun.Controls.Add(this.btnStart);
            this.grpRun.Enabled = false;
            this.grpRun.Location = new System.Drawing.Point(39, 465);
            this.grpRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRun.Name = "grpRun";
            this.grpRun.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRun.Size = new System.Drawing.Size(379, 400);
            this.grpRun.TabIndex = 1;
            this.grpRun.TabStop = false;
            this.grpRun.Text = "Run Tools";
            this.grpRun.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 332);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "Number of Alive Cells";
            // 
            // txtNumberAlive
            // 
            this.txtNumberAlive.Enabled = false;
            this.txtNumberAlive.Location = new System.Drawing.Point(219, 327);
            this.txtNumberAlive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumberAlive.Name = "txtNumberAlive";
            this.txtNumberAlive.Size = new System.Drawing.Size(105, 31);
            this.txtNumberAlive.TabIndex = 100;
            this.txtNumberAlive.TabStop = false;
            this.txtNumberAlive.Text = "0";
            // 
            // spnInterval
            // 
            this.spnInterval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spnInterval.Location = new System.Drawing.Point(219, 122);
            this.spnInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spnInterval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spnInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnInterval.Name = "spnInterval";
            this.spnInterval.Size = new System.Drawing.Size(107, 31);
            this.spnInterval.TabIndex = 6;
            this.spnInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spnInterval.ValueChanged += new System.EventHandler(this.spnInterval_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval (ms)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtGenerations
            // 
            this.txtGenerations.Enabled = false;
            this.txtGenerations.Location = new System.Drawing.Point(219, 278);
            this.txtGenerations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(105, 31);
            this.txtGenerations.TabIndex = 99;
            this.txtGenerations.TabStop = false;
            this.txtGenerations.Text = "0";
            this.txtGenerations.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(9, 283);
            this.lblGenerations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(198, 25);
            this.lblGenerations.TabIndex = 7;
            this.lblGenerations.Text = "Number of Generations";
            this.lblGenerations.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOneGen
            // 
            this.btnOneGen.Location = new System.Drawing.Point(34, 52);
            this.btnOneGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOneGen.Name = "btnOneGen";
            this.btnOneGen.Size = new System.Drawing.Size(292, 38);
            this.btnOneGen.TabIndex = 5;
            this.btnOneGen.Text = "One Generation";
            this.btnOneGen.UseVisualStyleBackColor = true;
            this.btnOneGen.Click += new System.EventHandler(this.btnOneGen_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(183, 210);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(143, 38);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 210);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 38);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtGrid
            // 
            this.txtGrid.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGrid.Location = new System.Drawing.Point(529, 37);
            this.txtGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGrid.Multiline = true;
            this.txtGrid.Name = "txtGrid";
            this.txtGrid.ReadOnly = true;
            this.txtGrid.Size = new System.Drawing.Size(928, 826);
            this.txtGrid.TabIndex = 10;
            this.txtGrid.TabStop = false;
            this.txtGrid.Text = resources.GetString("txtGrid.Text");
            // 
            // tmrTimer
            // 
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 915);
            this.Controls.Add(this.txtGrid);
            this.Controls.Add(this.grpRun);
            this.Controls.Add(this.grpSetup);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.spnInterval)).EndInit();
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
        private System.Windows.Forms.TextBox txtGrid;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.NumericUpDown spn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spnInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberAlive;
    }
}

