namespace LAB4Encapsulation
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
            this.INname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.INbirthyear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.INgpa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Listname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maxgpa = new System.Windows.Forms.TextBox();
            this.mingpa = new System.Windows.Forms.TextBox();
            this.Allage = new System.Windows.Forms.TextBox();
            this.avg_gpa = new System.Windows.Forms.TextBox();
            this.MinGPA_name = new System.Windows.Forms.TextBox();
            this.MaxGPA_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // INname
            // 
            this.INname.Location = new System.Drawing.Point(51, 76);
            this.INname.Name = "INname";
            this.INname.Size = new System.Drawing.Size(116, 22);
            this.INname.TabIndex = 0;
            this.INname.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // INbirthyear
            // 
            this.INbirthyear.Location = new System.Drawing.Point(51, 131);
            this.INbirthyear.Name = "INbirthyear";
            this.INbirthyear.Size = new System.Drawing.Size(116, 22);
            this.INbirthyear.TabIndex = 2;
            this.INbirthyear.Text = "2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthyear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // INgpa
            // 
            this.INgpa.Location = new System.Drawing.Point(51, 186);
            this.INgpa.Name = "INgpa";
            this.INgpa.Size = new System.Drawing.Size(116, 22);
            this.INgpa.TabIndex = 6;
            this.INgpa.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "GPA max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "GPA min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "GPA avg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Name";
            // 
            // Listname
            // 
            this.Listname.Location = new System.Drawing.Point(508, 76);
            this.Listname.Multiline = true;
            this.Listname.Name = "Listname";
            this.Listname.Size = new System.Drawing.Size(116, 203);
            this.Listname.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 27);
            this.label9.TabIndex = 14;
            this.label9.Text = "Class Age";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Papyrus", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 27);
            this.label10.TabIndex = 15;
            this.label10.Text = "Listname";
            // 
            // maxgpa
            // 
            this.maxgpa.Location = new System.Drawing.Point(204, 76);
            this.maxgpa.Name = "maxgpa";
            this.maxgpa.Size = new System.Drawing.Size(100, 22);
            this.maxgpa.TabIndex = 16;
            this.maxgpa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mingpa
            // 
            this.mingpa.Location = new System.Drawing.Point(204, 131);
            this.mingpa.Name = "mingpa";
            this.mingpa.Size = new System.Drawing.Size(100, 22);
            this.mingpa.TabIndex = 17;
            // 
            // Allage
            // 
            this.Allage.Location = new System.Drawing.Point(351, 186);
            this.Allage.Name = "Allage";
            this.Allage.Size = new System.Drawing.Size(100, 22);
            this.Allage.TabIndex = 18;
            this.Allage.Text = "0";
            this.Allage.TextChanged += new System.EventHandler(this.Allage_TextChanged);
            // 
            // avg_gpa
            // 
            this.avg_gpa.Location = new System.Drawing.Point(204, 186);
            this.avg_gpa.Name = "avg_gpa";
            this.avg_gpa.Size = new System.Drawing.Size(100, 22);
            this.avg_gpa.TabIndex = 19;
            this.avg_gpa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // MinGPA_name
            // 
            this.MinGPA_name.Location = new System.Drawing.Point(351, 131);
            this.MinGPA_name.Name = "MinGPA_name";
            this.MinGPA_name.Size = new System.Drawing.Size(100, 22);
            this.MinGPA_name.TabIndex = 20;
            // 
            // MaxGPA_name
            // 
            this.MaxGPA_name.Location = new System.Drawing.Point(351, 76);
            this.MaxGPA_name.Name = "MaxGPA_name";
            this.MaxGPA_name.Size = new System.Drawing.Size(100, 22);
            this.MaxGPA_name.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(726, 316);
            this.Controls.Add(this.MaxGPA_name);
            this.Controls.Add(this.MinGPA_name);
            this.Controls.Add(this.avg_gpa);
            this.Controls.Add(this.Allage);
            this.Controls.Add(this.mingpa);
            this.Controls.Add(this.maxgpa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Listname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.INgpa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.INbirthyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INname);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox INname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INbirthyear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox INgpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Listname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maxgpa;
        private System.Windows.Forms.TextBox mingpa;
        private System.Windows.Forms.TextBox Allage;
        private System.Windows.Forms.TextBox avg_gpa;
        private System.Windows.Forms.TextBox MinGPA_name;
        private System.Windows.Forms.TextBox MaxGPA_name;
    }
}

