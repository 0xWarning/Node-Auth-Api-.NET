namespace NABAP
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
            this.logEmailEdit = new System.Windows.Forms.TextBox();
            this.logPassEdit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.regLicenseKey = new System.Windows.Forms.TextBox();
            this.regPassEdit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.regNameEdit = new System.Windows.Forms.TextBox();
            this.regEmailEdit = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // logEmailEdit
            // 
            this.logEmailEdit.Location = new System.Drawing.Point(6, 19);
            this.logEmailEdit.Name = "logEmailEdit";
            this.logEmailEdit.Size = new System.Drawing.Size(132, 20);
            this.logEmailEdit.TabIndex = 0;
            this.logEmailEdit.Text = "Email";
            // 
            // logPassEdit
            // 
            this.logPassEdit.Location = new System.Drawing.Point(6, 45);
            this.logPassEdit.Name = "logPassEdit";
            this.logPassEdit.Size = new System.Drawing.Size(132, 20);
            this.logPassEdit.TabIndex = 1;
            this.logPassEdit.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.logEmailEdit);
            this.groupBox1.Controls.Add(this.logPassEdit);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Interaction";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(6, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 46);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Waiting to login ...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.regLicenseKey);
            this.groupBox3.Controls.Add(this.regPassEdit);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.regNameEdit);
            this.groupBox3.Controls.Add(this.regEmailEdit);
            this.groupBox3.Location = new System.Drawing.Point(308, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Register";
            // 
            // regLicenseKey
            // 
            this.regLicenseKey.Location = new System.Drawing.Point(7, 97);
            this.regLicenseKey.Name = "regLicenseKey";
            this.regLicenseKey.Size = new System.Drawing.Size(132, 20);
            this.regLicenseKey.TabIndex = 4;
            this.regLicenseKey.Text = "License";
            // 
            // regPassEdit
            // 
            this.regPassEdit.Location = new System.Drawing.Point(7, 71);
            this.regPassEdit.Name = "regPassEdit";
            this.regPassEdit.Size = new System.Drawing.Size(132, 20);
            this.regPassEdit.TabIndex = 3;
            this.regPassEdit.Text = "Password";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // regNameEdit
            // 
            this.regNameEdit.Location = new System.Drawing.Point(6, 19);
            this.regNameEdit.Name = "regNameEdit";
            this.regNameEdit.Size = new System.Drawing.Size(132, 20);
            this.regNameEdit.TabIndex = 0;
            this.regNameEdit.Text = "Name";
            // 
            // regEmailEdit
            // 
            this.regEmailEdit.Location = new System.Drawing.Point(6, 45);
            this.regEmailEdit.Name = "regEmailEdit";
            this.regEmailEdit.Size = new System.Drawing.Size(132, 20);
            this.regEmailEdit.TabIndex = 1;
            this.regEmailEdit.Text = "Email";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 196);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 90);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Info (After Login)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(440, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(440, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Token";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waiting to login ...";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.groupBox9);
            this.groupBox6.Location = new System.Drawing.Point(479, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(162, 274);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Admin Panel";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.textBox5);
            this.groupBox7.Location = new System.Drawing.Point(12, 153);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(139, 71);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Remove User";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(126, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Email Here";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox3);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.textBox7);
            this.groupBox9.Controls.Add(this.textBox8);
            this.groupBox9.Location = new System.Drawing.Point(6, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(145, 128);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Token Gen";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "Expiry";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Create License";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 20);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "Custom License Key";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 45);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 20);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Rank";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button5);
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Location = new System.Drawing.Point(157, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(145, 72);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Login (With License)";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Login";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "License";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 315);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Node API Backend Admin Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox logEmailEdit;
        private System.Windows.Forms.TextBox logPassEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox regLicenseKey;
        private System.Windows.Forms.TextBox regPassEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox regNameEdit;
        private System.Windows.Forms.TextBox regEmailEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
    }
}

