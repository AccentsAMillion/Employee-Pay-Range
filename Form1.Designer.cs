namespace Wk2EmployeePayRage
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.textBox2EmpNo = new System.Windows.Forms.TextBox();
            this.textBox3PayRate = new System.Windows.Forms.TextBox();
            this.textBox4Hours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.button2Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp No.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pay Rate";
            // 
            // textBox1Name
            // 
            this.textBox1Name.Location = new System.Drawing.Point(70, 26);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(280, 20);
            this.textBox1Name.TabIndex = 3;
            // 
            // textBox2EmpNo
            // 
            this.textBox2EmpNo.Location = new System.Drawing.Point(70, 58);
            this.textBox2EmpNo.Name = "textBox2EmpNo";
            this.textBox2EmpNo.Size = new System.Drawing.Size(280, 20);
            this.textBox2EmpNo.TabIndex = 4;
            // 
            // textBox3PayRate
            // 
            this.textBox3PayRate.Location = new System.Drawing.Point(70, 96);
            this.textBox3PayRate.Name = "textBox3PayRate";
            this.textBox3PayRate.Size = new System.Drawing.Size(100, 20);
            this.textBox3PayRate.TabIndex = 5;
            // 
            // textBox4Hours
            // 
            this.textBox4Hours.Location = new System.Drawing.Point(250, 95);
            this.textBox4Hours.Name = "textBox4Hours";
            this.textBox4Hours.Size = new System.Drawing.Size(100, 20);
            this.textBox4Hours.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hours";
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.Location = new System.Drawing.Point(70, 200);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Size = new System.Drawing.Size(75, 23);
            this.ButtonLoad.TabIndex = 8;
            this.ButtonLoad.Text = "Load";
            this.ButtonLoad.UseVisualStyleBackColor = true;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // button2Save
            // 
            this.button2Save.Location = new System.Drawing.Point(250, 199);
            this.button2Save.Name = "button2Save";
            this.button2Save.Size = new System.Drawing.Size(75, 23);
            this.button2Save.TabIndex = 9;
            this.button2Save.Text = "Save";
            this.button2Save.UseVisualStyleBackColor = true;
            this.button2Save.Click += new System.EventHandler(this.button2Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2Save);
            this.Controls.Add(this.ButtonLoad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4Hours);
            this.Controls.Add(this.textBox3PayRate);
            this.Controls.Add(this.textBox2EmpNo);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.TextBox textBox2EmpNo;
        private System.Windows.Forms.TextBox textBox3PayRate;
        private System.Windows.Forms.TextBox textBox4Hours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Button button2Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

