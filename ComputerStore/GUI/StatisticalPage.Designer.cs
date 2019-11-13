namespace GUI
{
    partial class StatisticalPage
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.chartlProductsSold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProductsReceipted = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.dgvProductsSold = new System.Windows.Forms.DataGridView();
            this.dgvProductsReceipted = new System.Windows.Forms.DataGridView();
            this.lblProductsSold = new System.Windows.Forms.Label();
            this.lblProductsReceipted = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartlProductsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductsReceipted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsReceipted)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(432, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(140, 38);
            this.lblTitlePage.TabIndex = 40;
            this.lblTitlePage.Text = "Thống kê";
            // 
            // chartlProductsSold
            // 
            chartArea1.Name = "ChartArea1";
            this.chartlProductsSold.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartlProductsSold.Legends.Add(legend1);
            this.chartlProductsSold.Location = new System.Drawing.Point(26, 406);
            this.chartlProductsSold.Name = "chartlProductsSold";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng tiền";
            this.chartlProductsSold.Series.Add(series1);
            this.chartlProductsSold.Size = new System.Drawing.Size(480, 264);
            this.chartlProductsSold.TabIndex = 41;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "titleChart1";
            title1.Text = "Tổng doanh thu";
            this.chartlProductsSold.Titles.Add(title1);
            // 
            // chartProductsReceipted
            // 
            chartArea2.Name = "ChartArea1";
            this.chartProductsReceipted.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProductsReceipted.Legends.Add(legend2);
            this.chartProductsReceipted.Location = new System.Drawing.Point(519, 406);
            this.chartProductsReceipted.Name = "chartProductsReceipted";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng tiền";
            this.chartProductsReceipted.Series.Add(series2);
            this.chartProductsReceipted.Size = new System.Drawing.Size(480, 264);
            this.chartProductsReceipted.TabIndex = 43;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "titleChart1";
            title2.Text = "Tổng chi";
            this.chartProductsReceipted.Titles.Add(title2);
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator.LineThickness = 1;
            this.Separator.Location = new System.Drawing.Point(26, 356);
            this.Separator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(973, 43);
            this.Separator.TabIndex = 44;
            this.Separator.Transparency = 255;
            this.Separator.Vertical = false;
            // 
            // dgvProductsSold
            // 
            this.dgvProductsSold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsSold.Location = new System.Drawing.Point(26, 98);
            this.dgvProductsSold.Name = "dgvProductsSold";
            this.dgvProductsSold.RowTemplate.Height = 24;
            this.dgvProductsSold.Size = new System.Drawing.Size(480, 251);
            this.dgvProductsSold.TabIndex = 45;
            // 
            // dgvProductsReceipted
            // 
            this.dgvProductsReceipted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsReceipted.Location = new System.Drawing.Point(519, 98);
            this.dgvProductsReceipted.Name = "dgvProductsReceipted";
            this.dgvProductsReceipted.RowTemplate.Height = 24;
            this.dgvProductsReceipted.Size = new System.Drawing.Size(480, 251);
            this.dgvProductsReceipted.TabIndex = 45;
            // 
            // lblProductsSold
            // 
            this.lblProductsSold.AutoSize = true;
            this.lblProductsSold.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsSold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductsSold.Location = new System.Drawing.Point(135, 57);
            this.lblProductsSold.Name = "lblProductsSold";
            this.lblProductsSold.Size = new System.Drawing.Size(246, 38);
            this.lblProductsSold.TabIndex = 40;
            this.lblProductsSold.Text = "Sản phẩm đã bán";
            // 
            // lblProductsReceipted
            // 
            this.lblProductsReceipted.AutoSize = true;
            this.lblProductsReceipted.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsReceipted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProductsReceipted.Location = new System.Drawing.Point(630, 57);
            this.lblProductsReceipted.Name = "lblProductsReceipted";
            this.lblProductsReceipted.Size = new System.Drawing.Size(263, 38);
            this.lblProductsReceipted.TabIndex = 40;
            this.lblProductsReceipted.Text = "Sản phẩm đã nhập";
            // 
            // StatisticalPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductsReceipted);
            this.Controls.Add(this.dgvProductsSold);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.chartProductsReceipted);
            this.Controls.Add(this.chartlProductsSold);
            this.Controls.Add(this.lblProductsReceipted);
            this.Controls.Add(this.lblProductsSold);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "StatisticalPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.Load += new System.EventHandler(this.StatisticalPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartlProductsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductsReceipted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsReceipted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartlProductsSold;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductsReceipted;
        private Bunifu.Framework.UI.BunifuSeparator Separator;
        private System.Windows.Forms.DataGridView dgvProductsSold;
        private System.Windows.Forms.DataGridView dgvProductsReceipted;
        private System.Windows.Forms.Label lblProductsSold;
        private System.Windows.Forms.Label lblProductsReceipted;
    }
}
