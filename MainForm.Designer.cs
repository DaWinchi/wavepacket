namespace DynamicWave
{
    partial class MainForm
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
            this.WaveBox = new System.Windows.Forms.PictureBox();
            this.Run = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SigmaBox = new System.Windows.Forms.TextBox();
            this.X0Box = new System.Windows.Forms.TextBox();
            this.ABox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.V0Box = new System.Windows.Forms.TextBox();
            this.AlphaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.SteptBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SpectrBox = new System.Windows.Forms.PictureBox();
            this.SingleWaveBox = new System.Windows.Forms.PictureBox();
            this.SearchFure = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FureProgress = new System.Windows.Forms.ProgressBar();
            this.MomentBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.WaveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleWaveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MomentBar)).BeginInit();
            this.SuspendLayout();
            // 
            // WaveBox
            // 
            this.WaveBox.Location = new System.Drawing.Point(12, 11);
            this.WaveBox.Name = "WaveBox";
            this.WaveBox.Size = new System.Drawing.Size(873, 275);
            this.WaveBox.TabIndex = 0;
            this.WaveBox.TabStop = false;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(929, 612);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(230, 30);
            this.Run.TabIndex = 1;
            this.Run.Text = "Пуск";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SigmaBox
            // 
            this.SigmaBox.Location = new System.Drawing.Point(1059, 13);
            this.SigmaBox.Name = "SigmaBox";
            this.SigmaBox.Size = new System.Drawing.Size(100, 20);
            this.SigmaBox.TabIndex = 2;
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(1059, 38);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(100, 20);
            this.X0Box.TabIndex = 3;
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(1059, 64);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(100, 20);
            this.ABox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(953, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ширина купола";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вершина купола";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Высота купола";
            // 
            // V0Box
            // 
            this.V0Box.Location = new System.Drawing.Point(1059, 90);
            this.V0Box.Name = "V0Box";
            this.V0Box.Size = new System.Drawing.Size(100, 20);
            this.V0Box.TabIndex = 8;
            // 
            // AlphaBox
            // 
            this.AlphaBox.Location = new System.Drawing.Point(1059, 116);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Size = new System.Drawing.Size(100, 20);
            this.AlphaBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(929, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Амплитуда потенциала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(979, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Alpha";
            // 
            // RBox
            // 
            this.RBox.Location = new System.Drawing.Point(1059, 142);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(100, 20);
            this.RBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(998, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "R";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(929, 648);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(230, 30);
            this.Stop.TabIndex = 14;
            this.Stop.Text = "Стоп";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // SteptBox
            // 
            this.SteptBox.Location = new System.Drawing.Point(1059, 168);
            this.SteptBox.Name = "SteptBox";
            this.SteptBox.Size = new System.Drawing.Size(100, 20);
            this.SteptBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(947, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Шаг по времени";
            // 
            // SpectrBox
            // 
            this.SpectrBox.Location = new System.Drawing.Point(12, 343);
            this.SpectrBox.Name = "SpectrBox";
            this.SpectrBox.Size = new System.Drawing.Size(509, 335);
            this.SpectrBox.TabIndex = 17;
            this.SpectrBox.TabStop = false;
            // 
            // SingleWaveBox
            // 
            this.SingleWaveBox.Location = new System.Drawing.Point(528, 343);
            this.SingleWaveBox.Name = "SingleWaveBox";
            this.SingleWaveBox.Size = new System.Drawing.Size(395, 335);
            this.SingleWaveBox.TabIndex = 18;
            this.SingleWaveBox.TabStop = false;
            // 
            // SearchFure
            // 
            this.SearchFure.Location = new System.Drawing.Point(929, 576);
            this.SearchFure.Name = "SearchFure";
            this.SearchFure.Size = new System.Drawing.Size(230, 30);
            this.SearchFure.TabIndex = 19;
            this.SearchFure.Text = "Начать сбор информации для спектра";
            this.SearchFure.UseVisualStyleBackColor = true;
            this.SearchFure.Click += new System.EventHandler(this.SearchFure_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(1072, 194);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(87, 20);
            this.NBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(891, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Количество отсчётов для Фурье";
            // 
            // FureProgress
            // 
            this.FureProgress.Location = new System.Drawing.Point(894, 220);
            this.FureProgress.Name = "FureProgress";
            this.FureProgress.Size = new System.Drawing.Size(265, 23);
            this.FureProgress.TabIndex = 22;
            // 
            // MomentBar
            // 
            this.MomentBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.MomentBar.Enabled = false;
            this.MomentBar.Location = new System.Drawing.Point(12, 292);
            this.MomentBar.Name = "MomentBar";
            this.MomentBar.Size = new System.Drawing.Size(872, 45);
            this.MomentBar.TabIndex = 23;
            this.MomentBar.Scroll += new System.EventHandler(this.MomentBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 690);
            this.Controls.Add(this.MomentBar);
            this.Controls.Add(this.FureProgress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.SearchFure);
            this.Controls.Add(this.SingleWaveBox);
            this.Controls.Add(this.SpectrBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SteptBox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlphaBox);
            this.Controls.Add(this.V0Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.X0Box);
            this.Controls.Add(this.SigmaBox);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.WaveBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WaveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleWaveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MomentBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WaveBox;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SigmaBox;
        private System.Windows.Forms.TextBox X0Box;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox V0Box;
        private System.Windows.Forms.TextBox AlphaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox SteptBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox SpectrBox;
        private System.Windows.Forms.PictureBox SingleWaveBox;
        private System.Windows.Forms.Button SearchFure;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar FureProgress;
        private System.Windows.Forms.TrackBar MomentBar;
    }
}

