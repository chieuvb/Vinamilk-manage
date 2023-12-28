namespace GUI_vinamilk.Controls
{
    partial class ThongKeUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonDoanhThu = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelLeft.Controls.Add(this.buttonDoanhThu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(256, 931);
            this.panelLeft.TabIndex = 2;
            // 
            // buttonDoanhThu
            // 
            this.buttonDoanhThu.Location = new System.Drawing.Point(4, 4);
            this.buttonDoanhThu.Name = "buttonDoanhThu";
            this.buttonDoanhThu.Size = new System.Drawing.Size(249, 38);
            this.buttonDoanhThu.TabIndex = 0;
            this.buttonDoanhThu.Text = "Doanh thu";
            this.buttonDoanhThu.UseVisualStyleBackColor = true;
            this.buttonDoanhThu.Click += new System.EventHandler(this.ButtonDoanhThu_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(524, 119);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(900, 393);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // ThongKeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongKeUC";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Size = new System.Drawing.Size(1920, 939);
            this.Tag = "Thong ke";
            this.Load += new System.EventHandler(this.ThongKeUC_Load);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
