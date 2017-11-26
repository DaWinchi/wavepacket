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
            this.streamFure = new System.Windows.Forms.Label();
            this.FureBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WaveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleWaveBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MomentBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FureBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // WaveBox
            // 
            this.WaveBox.Location = new System.Drawing.Point(12, 29);
            this.WaveBox.Name = "WaveBox";
            this.WaveBox.Size = new System.Drawing.Size(959, 214);
            this.WaveBox.TabIndex = 0;
            this.WaveBox.TabStop = false;
            // 
            // Run
            // 
            this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Run.Location = new System.Drawing.Point(991, 603);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(261, 30);
            this.Run.TabIndex = 1;
            this.Run.Text = "Запустить волновой пакет";
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
            this.SigmaBox.Location = new System.Drawing.Point(130, 25);
            this.SigmaBox.Name = "SigmaBox";
            this.SigmaBox.Size = new System.Drawing.Size(100, 24);
            this.SigmaBox.TabIndex = 2;
            // 
            // X0Box
            // 
            this.X0Box.Location = new System.Drawing.Point(130, 53);
            this.X0Box.Name = "X0Box";
            this.X0Box.Size = new System.Drawing.Size(100, 24);
            this.X0Box.TabIndex = 3;
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(130, 80);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(100, 24);
            this.ABox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вершина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Высота";
            // 
            // V0Box
            // 
            this.V0Box.Location = new System.Drawing.Point(130, 25);
            this.V0Box.Name = "V0Box";
            this.V0Box.Size = new System.Drawing.Size(100, 24);
            this.V0Box.TabIndex = 8;
            // 
            // AlphaBox
            // 
            this.AlphaBox.Location = new System.Drawing.Point(130, 61);
            this.AlphaBox.Name = "AlphaBox";
            this.AlphaBox.Size = new System.Drawing.Size(100, 24);
            this.AlphaBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Амплитуда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Параметр  α ";
            // 
            // RBox
            // 
            this.RBox.Location = new System.Drawing.Point(130, 91);
            this.RBox.Name = "RBox";
            this.RBox.Size = new System.Drawing.Size(100, 24);
            this.RBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "R";
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(991, 639);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(261, 30);
            this.Stop.TabIndex = 14;
            this.Stop.Text = "Остановка";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // SteptBox
            // 
            this.SteptBox.Location = new System.Drawing.Point(134, 24);
            this.SteptBox.Name = "SteptBox";
            this.SteptBox.Size = new System.Drawing.Size(100, 24);
            this.SteptBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Шаг по времени";
            // 
            // SpectrBox
            // 
            this.SpectrBox.Location = new System.Drawing.Point(12, 315);
            this.SpectrBox.Name = "SpectrBox";
            this.SpectrBox.Size = new System.Drawing.Size(535, 302);
            this.SpectrBox.TabIndex = 17;
            this.SpectrBox.TabStop = false;
            // 
            // SingleWaveBox
            // 
            this.SingleWaveBox.Location = new System.Drawing.Point(553, 315);
            this.SingleWaveBox.Name = "SingleWaveBox";
            this.SingleWaveBox.Size = new System.Drawing.Size(418, 302);
            this.SingleWaveBox.TabIndex = 18;
            this.SingleWaveBox.TabStop = false;
            // 
            // SearchFure
            // 
            this.SearchFure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFure.Location = new System.Drawing.Point(988, 458);
            this.SearchFure.Name = "SearchFure";
            this.SearchFure.Size = new System.Drawing.Size(261, 30);
            this.SearchFure.TabIndex = 2;
            this.SearchFure.Text = "Создать спектр";
            this.SearchFure.UseVisualStyleBackColor = true;
            this.SearchFure.Click += new System.EventHandler(this.SearchFure_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(134, 80);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(100, 24);
            this.NBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Количество отсчётов для спектра";
            // 
            // FureProgress
            // 
            this.FureProgress.Location = new System.Drawing.Point(988, 429);
            this.FureProgress.Name = "FureProgress";
            this.FureProgress.Size = new System.Drawing.Size(261, 23);
            this.FureProgress.TabIndex = 22;
            // 
            // MomentBar
            // 
            this.MomentBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MomentBar.Enabled = false;
            this.MomentBar.Location = new System.Drawing.Point(12, 249);
            this.MomentBar.Name = "MomentBar";
            this.MomentBar.Size = new System.Drawing.Size(959, 45);
            this.MomentBar.TabIndex = 23;
            this.MomentBar.TickFrequency = 0;
            this.MomentBar.Scroll += new System.EventHandler(this.MomentBar_Scroll);
            // 
            // streamFure
            // 
            this.streamFure.AutoSize = true;
            this.streamFure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streamFure.Location = new System.Drawing.Point(988, 408);
            this.streamFure.Name = "streamFure";
            this.streamFure.Size = new System.Drawing.Size(182, 18);
            this.streamFure.TabIndex = 24;
            this.streamFure.Text = "Создайте Фурье-образы";
            // 
            // FureBar
            // 
            this.FureBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.FureBar.Enabled = false;
            this.FureBar.Location = new System.Drawing.Point(12, 633);
            this.FureBar.Name = "FureBar";
            this.FureBar.Size = new System.Drawing.Size(535, 45);
            this.FureBar.TabIndex = 25;
            this.FureBar.Scroll += new System.EventHandler(this.FureBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(8, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Волновой пакет и вид потенциала";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ABox);
            this.groupBox1.Controls.Add(this.X0Box);
            this.groupBox1.Controls.Add(this.SigmaBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(991, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 116);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры гауссова купола";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.V0Box);
            this.groupBox2.Controls.Add(this.AlphaBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.RBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(991, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 128);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры потенциальной ямы";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.SteptBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(991, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 115);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры дискретизации";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Спектр";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(550, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Стационарная волновая функция";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FureBar);
            this.Controls.Add(this.streamFure);
            this.Controls.Add(this.MomentBar);
            this.Controls.Add(this.FureProgress);
            this.Controls.Add(this.SearchFure);
            this.Controls.Add(this.SingleWaveBox);
            this.Controls.Add(this.SpectrBox);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.WaveBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Задача о динамике волнового пакета. Вариант 8.";
            ((System.ComponentModel.ISupportInitialize)(this.WaveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpectrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleWaveBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MomentBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FureBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label streamFure;
        private System.Windows.Forms.TrackBar FureBar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

