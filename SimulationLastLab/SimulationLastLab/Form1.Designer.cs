namespace SimulationLastLab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.num_CountOperators = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_IntFlow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_IntBank = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAllTime = new System.Windows.Forms.Label();
            this.labelMaxClients = new System.Windows.Forms.Label();
            this.labelBusyOper = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountOperators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IntFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IntBank)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.num_CountOperators);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.num_IntFlow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.num_IntBank);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 35);
            this.panel1.TabIndex = 0;
            // 
            // num_CountOperators
            // 
            this.num_CountOperators.Location = new System.Drawing.Point(697, 9);
            this.num_CountOperators.Name = "num_CountOperators";
            this.num_CountOperators.Size = new System.Drawing.Size(60, 20);
            this.num_CountOperators.TabIndex = 6;
            this.num_CountOperators.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Операторов";
            // 
            // num_IntFlow
            // 
            this.num_IntFlow.Location = new System.Drawing.Point(517, 9);
            this.num_IntFlow.Name = "num_IntFlow";
            this.num_IntFlow.Size = new System.Drawing.Size(60, 20);
            this.num_IntFlow.TabIndex = 4;
            this.num_IntFlow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Интенсивность приходящих клиентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Интенсивность обслуживания клиента";
            // 
            // num_IntBank
            // 
            this.num_IntBank.Location = new System.Drawing.Point(214, 9);
            this.num_IntBank.Name = "num_IntBank";
            this.num_IntBank.Size = new System.Drawing.Size(60, 20);
            this.num_IntBank.TabIndex = 1;
            this.num_IntBank.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(849, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start/Stop";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelAllTime);
            this.panel2.Controls.Add(this.labelMaxClients);
            this.panel2.Controls.Add(this.labelBusyOper);
            this.panel2.Controls.Add(this.labelClients);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 505);
            this.panel2.TabIndex = 1;
            // 
            // labelAllTime
            // 
            this.labelAllTime.AutoSize = true;
            this.labelAllTime.Location = new System.Drawing.Point(3, 135);
            this.labelAllTime.Name = "labelAllTime";
            this.labelAllTime.Size = new System.Drawing.Size(35, 13);
            this.labelAllTime.TabIndex = 4;
            this.labelAllTime.Text = "label5";
            // 
            // labelMaxClients
            // 
            this.labelMaxClients.AutoSize = true;
            this.labelMaxClients.Location = new System.Drawing.Point(3, 87);
            this.labelMaxClients.Name = "labelMaxClients";
            this.labelMaxClients.Size = new System.Drawing.Size(35, 13);
            this.labelMaxClients.TabIndex = 3;
            this.labelMaxClients.Text = "label5";
            // 
            // labelBusyOper
            // 
            this.labelBusyOper.AutoSize = true;
            this.labelBusyOper.Location = new System.Drawing.Point(3, 50);
            this.labelBusyOper.Name = "labelBusyOper";
            this.labelBusyOper.Size = new System.Drawing.Size(115, 13);
            this.labelBusyOper.TabIndex = 2;
            this.labelBusyOper.Text = "Занятых операторов:";
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Location = new System.Drawing.Point(3, 27);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(58, 13);
            this.labelClients.TabIndex = 1;
            this.labelClients.Text = "Клиентов:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статистика";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(208, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0.000";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(747, 505);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 540);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CountOperators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IntFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_IntBank)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelBusyOper;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown num_IntBank;
        private System.Windows.Forms.NumericUpDown num_CountOperators;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_IntFlow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaxClients;
        private System.Windows.Forms.Label labelAllTime;
    }
}

