namespace Lab_14
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ServiceIntensity = new System.Windows.Forms.NumericUpDown();
            this.NumOfConsultants = new System.Windows.Forms.NumericUpDown();
            this.ClientFlow = new System.Windows.Forms.NumericUpDown();
            this.QueueLabel = new System.Windows.Forms.Label();
            this.ServeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateGridView = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfConsultants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ServiceIntensity);
            this.panel1.Controls.Add(this.NumOfConsultants);
            this.panel1.Controls.Add(this.ClientFlow);
            this.panel1.Controls.Add(this.QueueLabel);
            this.panel1.Controls.Add(this.ServeLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 443);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(86, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 56);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(86, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Старт/стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServiceIntensity
            // 
            this.ServiceIntensity.DecimalPlaces = 2;
            this.ServiceIntensity.Location = new System.Drawing.Point(251, 63);
            this.ServiceIntensity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceIntensity.Name = "ServiceIntensity";
            this.ServiceIntensity.Size = new System.Drawing.Size(79, 22);
            this.ServiceIntensity.TabIndex = 10;
            this.ServiceIntensity.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // NumOfConsultants
            // 
            this.NumOfConsultants.Location = new System.Drawing.Point(251, 97);
            this.NumOfConsultants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumOfConsultants.Name = "NumOfConsultants";
            this.NumOfConsultants.Size = new System.Drawing.Size(79, 22);
            this.NumOfConsultants.TabIndex = 9;
            this.NumOfConsultants.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ClientFlow
            // 
            this.ClientFlow.DecimalPlaces = 2;
            this.ClientFlow.Location = new System.Drawing.Point(251, 27);
            this.ClientFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientFlow.Name = "ClientFlow";
            this.ClientFlow.Size = new System.Drawing.Size(79, 22);
            this.ClientFlow.TabIndex = 8;
            this.ClientFlow.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // QueueLabel
            // 
            this.QueueLabel.AutoSize = true;
            this.QueueLabel.Location = new System.Drawing.Point(248, 169);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.Size = new System.Drawing.Size(14, 16);
            this.QueueLabel.TabIndex = 7;
            this.QueueLabel.Text = "0";
            // 
            // ServeLabel
            // 
            this.ServeLabel.AutoSize = true;
            this.ServeLabel.Location = new System.Drawing.Point(248, 134);
            this.ServeLabel.Name = "ServeLabel";
            this.ServeLabel.Size = new System.Drawing.Size(14, 16);
            this.ServeLabel.TabIndex = 6;
            this.ServeLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "В очереди";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Обслужено";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Интенсивность обслуживания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Интенсивность потока клиенов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во консультантов";
            // 
            // stateGridView
            // 
            this.stateGridView.AllowUserToAddRows = false;
            this.stateGridView.AllowUserToDeleteRows = false;
            this.stateGridView.AllowUserToResizeColumns = false;
            this.stateGridView.AllowUserToResizeRows = false;
            this.stateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stateGridView.Location = new System.Drawing.Point(369, 12);
            this.stateGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateGridView.Name = "stateGridView";
            this.stateGridView.RowHeadersVisible = false;
            this.stateGridView.RowHeadersWidth = 51;
            this.stateGridView.RowTemplate.Height = 24;
            this.stateGridView.Size = new System.Drawing.Size(276, 443);
            this.stateGridView.TabIndex = 1;
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Текущее время";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(248, 203);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(14, 16);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 466);
            this.Controls.Add(this.stateGridView);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Офис банка";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfConsultants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ServiceIntensity;
        private System.Windows.Forms.NumericUpDown NumOfConsultants;
        private System.Windows.Forms.NumericUpDown ClientFlow;
        private System.Windows.Forms.Label QueueLabel;
        private System.Windows.Forms.Label ServeLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView stateGridView;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
    }
}

