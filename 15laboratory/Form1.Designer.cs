namespace _15laboratory
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
            this.label_weather = new System.Windows.Forms.Label();
            this.label_day = new System.Windows.Forms.Label();
            this.label_hour = new System.Windows.Forms.Label();
            this.label_Freq0 = new System.Windows.Forms.Label();
            this.label_Freq1 = new System.Windows.Forms.Label();
            this.label_Freq2 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_weather
            // 
            this.label_weather.BackColor = System.Drawing.Color.SandyBrown;
            this.label_weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_weather.Location = new System.Drawing.Point(12, 19);
            this.label_weather.Name = "label_weather";
            this.label_weather.Size = new System.Drawing.Size(150, 30);
            this.label_weather.TabIndex = 0;
            this.label_weather.Text = "WEATHER";
            // 
            // label_day
            // 
            this.label_day.BackColor = System.Drawing.Color.SandyBrown;
            this.label_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_day.Location = new System.Drawing.Point(16, 67);
            this.label_day.Name = "label_day";
            this.label_day.Size = new System.Drawing.Size(150, 30);
            this.label_day.TabIndex = 1;
            this.label_day.Text = "DAY";
            // 
            // label_hour
            // 
            this.label_hour.BackColor = System.Drawing.Color.SandyBrown;
            this.label_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_hour.Location = new System.Drawing.Point(12, 121);
            this.label_hour.Name = "label_hour";
            this.label_hour.Size = new System.Drawing.Size(150, 30);
            this.label_hour.TabIndex = 2;
            this.label_hour.Text = "HOUR";
            // 
            // label_Freq0
            // 
            this.label_Freq0.AutoSize = true;
            this.label_Freq0.BackColor = System.Drawing.Color.SandyBrown;
            this.label_Freq0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Freq0.Location = new System.Drawing.Point(16, 179);
            this.label_Freq0.Name = "label_Freq0";
            this.label_Freq0.Size = new System.Drawing.Size(73, 25);
            this.label_Freq0.TabIndex = 3;
            this.label_Freq0.Text = "Freq0";
            // 
            // label_Freq1
            // 
            this.label_Freq1.AutoSize = true;
            this.label_Freq1.BackColor = System.Drawing.Color.SandyBrown;
            this.label_Freq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Freq1.Location = new System.Drawing.Point(16, 233);
            this.label_Freq1.Name = "label_Freq1";
            this.label_Freq1.Size = new System.Drawing.Size(73, 25);
            this.label_Freq1.TabIndex = 4;
            this.label_Freq1.Text = "Freq1";
            // 
            // label_Freq2
            // 
            this.label_Freq2.AutoSize = true;
            this.label_Freq2.BackColor = System.Drawing.Color.SandyBrown;
            this.label_Freq2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Freq2.Location = new System.Drawing.Point(16, 291);
            this.label_Freq2.Name = "label_Freq2";
            this.label_Freq2.Size = new System.Drawing.Size(73, 25);
            this.label_Freq2.TabIndex = 5;
            this.label_Freq2.Text = "Freq2";
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(12, 365);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(165, 59);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Freq2);
            this.Controls.Add(this.label_Freq1);
            this.Controls.Add(this.label_Freq0);
            this.Controls.Add(this.label_hour);
            this.Controls.Add(this.label_day);
            this.Controls.Add(this.label_weather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_weather;
        private System.Windows.Forms.Label label_day;
        private System.Windows.Forms.Label label_hour;
        private System.Windows.Forms.Label label_Freq0;
        private System.Windows.Forms.Label label_Freq1;
        private System.Windows.Forms.Label label_Freq2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Timer timer1;
    }
}

