namespace Collatz_Conjecture
{
    partial class Main
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.CCChart = new LiveCharts.WinForms.CartesianChart();
            this.lblLimit = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmboxNumbers = new System.Windows.Forms.ComboBox();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(15, 14);
            this.lblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(34, 20);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(56, 10);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(226, 27);
            this.txtN.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Location = new System.Drawing.Point(291, 8);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(79, 30);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // CCChart
            // 
            this.CCChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCChart.Location = new System.Drawing.Point(15, 62);
            this.CCChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CCChart.Name = "CCChart";
            this.CCChart.Size = new System.Drawing.Size(1616, 676);
            this.CCChart.TabIndex = 4;
            this.CCChart.Text = "CCChart";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(698, 14);
            this.lblLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(49, 20);
            this.lblLimit.TabIndex = 5;
            this.lblLimit.Text = "Limit: ";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1538, 9);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmboxNumbers
            // 
            this.cmboxNumbers.AllowDrop = true;
            this.cmboxNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboxNumbers.FormattingEnabled = true;
            this.cmboxNumbers.Location = new System.Drawing.Point(936, 10);
            this.cmboxNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboxNumbers.Name = "cmboxNumbers";
            this.cmboxNumbers.Size = new System.Drawing.Size(175, 28);
            this.cmboxNumbers.TabIndex = 10;
            // 
            // btnDark
            // 
            this.btnDark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDark.Location = new System.Drawing.Point(1436, 9);
            this.btnDark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(94, 29);
            this.btnDark.TabIndex = 11;
            this.btnDark.Text = "Dark Mode";
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnLight
            // 
            this.btnLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLight.Location = new System.Drawing.Point(1436, 9);
            this.btnLight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(94, 29);
            this.btnLight.TabIndex = 12;
            this.btnLight.Text = "Light Mode";
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Visible = false;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnCount
            // 
            this.btnCount.AutoSize = true;
            this.btnCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCount.Location = new System.Drawing.Point(379, 8);
            this.btnCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(88, 30);
            this.btnCount.TabIndex = 13;
            this.btnCount.Text = "Count to 1";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AutoSize = true;
            this.btnRandom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandom.Location = new System.Drawing.Point(478, 8);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 30);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1334, 9);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 29);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1646, 754);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.cmboxNumbers);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.CCChart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1662, 791);
            this.Name = "Main";
            this.Text = "Collatz Conjecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblN;
        private TextBox txtN;
        private Button btnGenerate;
        private LiveCharts.WinForms.CartesianChart CCChart;
        private Label lblLimit;
        private Button btnClear;
        private ComboBox cmboxNumbers;
        private Button btnDark;
        private Button btnLight;
        private Button btnCount;
        private Button btnRandom;
        private Button btnExport;
    }
}