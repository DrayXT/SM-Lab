namespace para_lab14
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            bStart = new Button();
            currentClientCountLabel = new Label();
            currentTimeLabel = new Label();
            bPause = new Button();
            statisticsDataGridView = new DataGridView();
            maxTimeStateLabel = new Label();
            serviceIntensity = new NumericUpDown();
            arrivalIntensity = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            lQueue = new Label();
            maxQueueLengthLabel = new Label();
            maxOperatorsLabel = new Label();
            namea = new Label();
            nOperators = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)statisticsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceIntensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrivalIntensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nOperators).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bStart
            // 
            bStart.Location = new Point(344, 409);
            bStart.Name = "bStart";
            bStart.Size = new Size(94, 29);
            bStart.TabIndex = 0;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // currentClientCountLabel
            // 
            currentClientCountLabel.AutoSize = true;
            currentClientCountLabel.Location = new Point(12, 279);
            currentClientCountLabel.Name = "currentClientCountLabel";
            currentClientCountLabel.Size = new Size(50, 20);
            currentClientCountLabel.TabIndex = 1;
            currentClientCountLabel.Text = "label1";
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Location = new Point(320, 279);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(50, 20);
            currentTimeLabel.TabIndex = 2;
            currentTimeLabel.Text = "label2";
            // 
            // bPause
            // 
            bPause.Location = new Point(558, 409);
            bPause.Name = "bPause";
            bPause.Size = new Size(94, 29);
            bPause.TabIndex = 3;
            bPause.Text = "Pause";
            bPause.UseVisualStyleBackColor = true;
            bPause.Click += bPause_Click;
            // 
            // statisticsDataGridView
            // 
            statisticsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statisticsDataGridView.Location = new Point(12, 12);
            statisticsDataGridView.Name = "statisticsDataGridView";
            statisticsDataGridView.RowHeadersWidth = 51;
            statisticsDataGridView.Size = new Size(363, 246);
            statisticsDataGridView.TabIndex = 4;
            // 
            // maxTimeStateLabel
            // 
            maxTimeStateLabel.AutoSize = true;
            maxTimeStateLabel.Location = new Point(381, 12);
            maxTimeStateLabel.Name = "maxTimeStateLabel";
            maxTimeStateLabel.Size = new Size(185, 20);
            maxTimeStateLabel.TabIndex = 5;
            maxTimeStateLabel.Text = "Самое долгое состояние:";
            // 
            // serviceIntensity
            // 
            serviceIntensity.Location = new Point(613, 98);
            serviceIntensity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            serviceIntensity.Name = "serviceIntensity";
            serviceIntensity.Size = new Size(94, 27);
            serviceIntensity.TabIndex = 6;
            serviceIntensity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // arrivalIntensity
            // 
            arrivalIntensity.Location = new Point(613, 140);
            arrivalIntensity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            arrivalIntensity.Name = "arrivalIntensity";
            arrivalIntensity.Size = new Size(94, 27);
            arrivalIntensity.TabIndex = 7;
            arrivalIntensity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 100);
            label1.Name = "label1";
            label1.Size = new Size(221, 20);
            label1.TabIndex = 8;
            label1.Text = "Интенсивность обслуживания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 142);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 9;
            label2.Text = "Интенсивность прибытия";
            // 
            // lQueue
            // 
            lQueue.AutoSize = true;
            lQueue.Location = new Point(12, 310);
            lQueue.Name = "lQueue";
            lQueue.Size = new Size(50, 20);
            lQueue.TabIndex = 10;
            lQueue.Text = "label3";
            // 
            // maxQueueLengthLabel
            // 
            maxQueueLengthLabel.AutoSize = true;
            maxQueueLengthLabel.Location = new Point(381, 52);
            maxQueueLengthLabel.Name = "maxQueueLengthLabel";
            maxQueueLengthLabel.Size = new Size(159, 20);
            maxQueueLengthLabel.TabIndex = 11;
            maxQueueLengthLabel.Text = "Макс. длина очереди:";
            // 
            // maxOperatorsLabel
            // 
            maxOperatorsLabel.AutoSize = true;
            maxOperatorsLabel.Location = new Point(381, 32);
            maxOperatorsLabel.Name = "maxOperatorsLabel";
            maxOperatorsLabel.Size = new Size(198, 20);
            maxOperatorsLabel.TabIndex = 12;
            maxOperatorsLabel.Text = "Макс. занятых операторов:";
            // 
            // namea
            // 
            namea.AutoSize = true;
            namea.Location = new Point(381, 178);
            namea.Name = "namea";
            namea.Size = new Size(149, 20);
            namea.TabIndex = 13;
            namea.Text = "Кол-во операторов:";
            // 
            // nOperators
            // 
            nOperators.Location = new Point(613, 178);
            nOperators.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nOperators.Name = "nOperators";
            nOperators.Size = new Size(94, 27);
            nOperators.TabIndex = 14;
            nOperators.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nOperators);
            Controls.Add(namea);
            Controls.Add(maxOperatorsLabel);
            Controls.Add(maxQueueLengthLabel);
            Controls.Add(lQueue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(arrivalIntensity);
            Controls.Add(serviceIntensity);
            Controls.Add(maxTimeStateLabel);
            Controls.Add(statisticsDataGridView);
            Controls.Add(bPause);
            Controls.Add(currentTimeLabel);
            Controls.Add(currentClientCountLabel);
            Controls.Add(bStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)statisticsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceIntensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrivalIntensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nOperators).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button bStart;
        private Label currentClientCountLabel;
        private Label currentTimeLabel;
        private Button bPause;
        private DataGridView statisticsDataGridView;
        private Label maxTimeStateLabel;
        private NumericUpDown serviceIntensity;
        private NumericUpDown arrivalIntensity;
        private Label label1;
        private Label label2;
        private Label lQueue;
        private Label maxQueueLengthLabel;
        private Label maxOperatorsLabel;
        private Label namea;
        private NumericUpDown nOperators;
    }
}
