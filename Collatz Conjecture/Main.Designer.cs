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
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 9);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(27, 15);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "N =";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(45, 6);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(182, 23);
            this.txtN.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Location = new System.Drawing.Point(233, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(64, 25);
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
            this.CCChart.Location = new System.Drawing.Point(12, 35);
            this.CCChart.Name = "CCChart";
            this.CCChart.Size = new System.Drawing.Size(1153, 508);
            this.CCChart.TabIndex = 4;
            this.CCChart.Text = "CCChart";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(324, 10);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(40, 15);
            this.lblLimit.TabIndex = 5;
            this.lblLimit.Text = "Limit: ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1177, 555);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.CCChart);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
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
    }
}