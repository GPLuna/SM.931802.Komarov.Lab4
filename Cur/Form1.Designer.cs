namespace Cur
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LDollars = new System.Windows.Forms.Label();
            this.LRubles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edPercent = new System.Windows.Forms.NumericUpDown();
            this.edValue = new System.Windows.Forms.NumericUpDown();
            this.Buy = new System.Windows.Forms.Button();
            this.Sell = new System.Windows.Forms.Button();
            this.SellAll = new System.Windows.Forms.Button();
            this.BuyAll = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.edDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.edRate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LDollars);
            this.panel1.Controls.Add(this.LRubles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.edPercent);
            this.panel1.Controls.Add(this.edValue);
            this.panel1.Controls.Add(this.Buy);
            this.panel1.Controls.Add(this.Sell);
            this.panel1.Controls.Add(this.SellAll);
            this.panel1.Controls.Add(this.BuyAll);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edDays);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.edRate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 103);
            this.panel1.TabIndex = 0;
            // 
            // LDollars
            // 
            this.LDollars.AutoSize = true;
            this.LDollars.Location = new System.Drawing.Point(467, 42);
            this.LDollars.Name = "LDollars";
            this.LDollars.Size = new System.Drawing.Size(60, 13);
            this.LDollars.TabIndex = 13;
            this.LDollars.Text = "Доллары: ";
            // 
            // LRubles
            // 
            this.LRubles.AutoSize = true;
            this.LRubles.Location = new System.Drawing.Point(467, 23);
            this.LRubles.Name = "LRubles";
            this.LRubles.Size = new System.Drawing.Size(43, 13);
            this.LRubles.TabIndex = 12;
            this.LRubles.Text = "Рубли: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Процент";
            // 
            // edPercent
            // 
            this.edPercent.DecimalPlaces = 2;
            this.edPercent.Location = new System.Drawing.Point(106, 74);
            this.edPercent.Name = "edPercent";
            this.edPercent.Size = new System.Drawing.Size(96, 20);
            this.edPercent.TabIndex = 10;
            // 
            // edValue
            // 
            this.edValue.DecimalPlaces = 2;
            this.edValue.Location = new System.Drawing.Point(339, 16);
            this.edValue.Name = "edValue";
            this.edValue.Size = new System.Drawing.Size(96, 20);
            this.edValue.TabIndex = 9;
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(327, 42);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(108, 23);
            this.Buy.TabIndex = 8;
            this.Buy.Text = "Купить доллары";
            this.Buy.UseVisualStyleBackColor = true;
            this.Buy.Click += new System.EventHandler(this.Buy_Click);
            // 
            // Sell
            // 
            this.Sell.Location = new System.Drawing.Point(327, 71);
            this.Sell.Name = "Sell";
            this.Sell.Size = new System.Drawing.Size(108, 23);
            this.Sell.TabIndex = 7;
            this.Sell.Text = "Продать доллары";
            this.Sell.UseVisualStyleBackColor = true;
            this.Sell.Click += new System.EventHandler(this.Sell_Click);
            // 
            // SellAll
            // 
            this.SellAll.Location = new System.Drawing.Point(577, 74);
            this.SellAll.Name = "SellAll";
            this.SellAll.Size = new System.Drawing.Size(128, 23);
            this.SellAll.TabIndex = 6;
            this.SellAll.Text = "Продать все доллары";
            this.SellAll.UseVisualStyleBackColor = true;
            this.SellAll.Click += new System.EventHandler(this.SellAll_Click);
            // 
            // BuyAll
            // 
            this.BuyAll.Location = new System.Drawing.Point(455, 74);
            this.BuyAll.Name = "BuyAll";
            this.BuyAll.Size = new System.Drawing.Size(99, 23);
            this.BuyAll.TabIndex = 5;
            this.BuyAll.Text = "Купить на все";
            this.BuyAll.UseVisualStyleBackColor = true;
            this.BuyAll.Click += new System.EventHandler(this.BuyAll_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(221, 42);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Do it!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edDays
            // 
            this.edDays.Location = new System.Drawing.Point(106, 45);
            this.edDays.Name = "edDays";
            this.edDays.Size = new System.Drawing.Size(96, 20);
            this.edDays.TabIndex = 3;
            this.edDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дней";
            // 
            // edRate
            // 
            this.edRate.DecimalPlaces = 2;
            this.edRate.Location = new System.Drawing.Point(106, 16);
            this.edRate.Name = "edRate";
            this.edRate.Size = new System.Drawing.Size(96, 20);
            this.edRate.TabIndex = 1;
            this.edRate.Value = new decimal(new int[] {
            7433,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущий курс";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 103);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "F2";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(717, 347);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown edRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown edPercent;
        private System.Windows.Forms.NumericUpDown edValue;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Button Sell;
        private System.Windows.Forms.Button SellAll;
        private System.Windows.Forms.Button BuyAll;
        private System.Windows.Forms.Label LDollars;
        private System.Windows.Forms.Label LRubles;
    }
}

