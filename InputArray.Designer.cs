namespace lab_5
{
    partial class InputArray
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
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.darkLabel1.Location = new System.Drawing.Point(13, 28);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(161, 13);
            this.darkLabel1.TabIndex = 0;
            this.darkLabel1.Text = "Введите через пробел массив";
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(12, 44);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(484, 20);
            this.darkTextBox1.TabIndex = 1;
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(154, 81);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(200, 35);
            this.darkButton1.TabIndex = 2;
            this.darkButton1.Text = "Подтвердить";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // InputArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(517, 128);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkLabel1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "InputArray";
            this.ShowIcon = false;
            this.Text = "Ввод массива P";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InputArray_FormClosed);
            this.Shown += new System.EventHandler(this.InputArray_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkButton darkButton1;
    }
}