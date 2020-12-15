namespace beadando
{
    partial class Results_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results_Form));
            this.piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.diagramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.download = new beadando.Mybutton();
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // piechart
            // 
            this.piechart.BackColor = System.Drawing.Color.Transparent;
            this.piechart.BorderlineWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.piechart.ChartAreas.Add(chartArea1);
            this.piechart.DataSource = this.diagramBindingSource;
            legend1.Name = "Legend1";
            this.piechart.Legends.Add(legend1);
            this.piechart.Location = new System.Drawing.Point(36, 35);
            this.piechart.Name = "piechart";
            this.piechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.piechart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(233)))), ((int)(((byte)(138))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(112)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(166)))), ((int)(((byte)(81))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(167)))), ((int)(((byte)(134))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(230)))), ((int)(((byte)(183))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(151)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(98)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(235)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(29)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.CustomProperties = "PieLineColor=Honeydew";
            series1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.LabelBorderWidth = 3;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "name";
            series1.YValueMembers = "score";
            this.piechart.Series.Add(series1);
            this.piechart.Size = new System.Drawing.Size(601, 491);
            this.piechart.TabIndex = 1;
            this.piechart.Text = "chart1";
            // 
            // diagramBindingSource
            // 
            this.diagramBindingSource.DataSource = typeof(beadando.diagram);
            // 
            // download
            // 
            this.download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.download.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.download.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.download.ForeColor = System.Drawing.Color.White;
            this.download.Location = new System.Drawing.Point(625, 363);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(256, 84);
            this.download.TabIndex = 2;
            this.download.Text = "Download results";
            this.download.UseVisualStyleBackColor = false;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // Results_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.download);
            this.Controls.Add(this.piechart);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results_Form";
            this.Text = "Results";
            ((System.ComponentModel.ISupportInitialize)(this.piechart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagramBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart piechart;
        private System.Windows.Forms.BindingSource diagramBindingSource;
        private Mybutton download;
    }
}