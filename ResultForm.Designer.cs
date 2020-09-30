namespace lab_5
{
    partial class ResultForm
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
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.darkTextBox3 = new DarkUI.Controls.DarkTextBox();
            this.SuspendLayout();
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(25, 222);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(162, 44);
            this.darkButton1.TabIndex = 0;
            this.darkButton1.Text = "Повторить обработку";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(25, 180);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.ReadOnly = true;
            this.darkTextBox1.Size = new System.Drawing.Size(484, 20);
            this.darkTextBox1.TabIndex = 3;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.darkLabel1.Location = new System.Drawing.Point(22, 164);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(145, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Массив P после обработки";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(22, 23);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(254, 39);
            this.darkLabel2.TabIndex = 4;
            this.darkLabel2.Text = "Если среднее арифметическое элементов  P\r\nбольше значения Amin минимального элеме" +
    "нта \r\nА, вычесть Amin из каждого элемента  P.";
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(22, 95);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(207, 13);
            this.darkLabel3.TabIndex = 5;
            this.darkLabel3.Text = "Среднее арифметическое элементов P";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(22, 122);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(65, 13);
            this.darkLabel4.TabIndex = 6;
            this.darkLabel4.Text = "Минимум A";
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox2.Location = new System.Drawing.Point(271, 95);
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.ReadOnly = true;
            this.darkTextBox2.Size = new System.Drawing.Size(100, 20);
            this.darkTextBox2.TabIndex = 7;
            // 
            // darkTextBox3
            // 
            this.darkTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox3.Location = new System.Drawing.Point(271, 122);
            this.darkTextBox3.Name = "darkTextBox3";
            this.darkTextBox3.ReadOnly = true;
            this.darkTextBox3.Size = new System.Drawing.Size(100, 20);
            this.darkTextBox3.TabIndex = 8;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(534, 284);
            this.Controls.Add(this.darkTextBox3);
            this.Controls.Add(this.darkTextBox2);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkButton1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ResultForm";
            this.ShowIcon = false;
            this.Text = "Вычисление результата";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.Shown += new System.EventHandler(this.ResultForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
        private DarkUI.Controls.DarkTextBox darkTextBox2;
        private DarkUI.Controls.DarkTextBox darkTextBox3;
    }
}