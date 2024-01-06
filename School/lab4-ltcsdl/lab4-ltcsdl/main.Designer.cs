namespace lab4_ltcsdl
{
    partial class passLabel
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teacherLogin = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.buttonTeacherLogin = new System.Windows.Forms.Button();
            this.studentLogin = new System.Windows.Forms.Label();
            this.textEnroll = new System.Windows.Forms.TextBox();
            this.labelEnroll = new System.Windows.Forms.Label();
            this.buttonStudentRegister = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(292, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select User Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(332, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 44);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teacherLogin
            // 
            this.teacherLogin.AutoSize = true;
            this.teacherLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.teacherLogin.Location = new System.Drawing.Point(104, 205);
            this.teacherLogin.Name = "teacherLogin";
            this.teacherLogin.Size = new System.Drawing.Size(196, 32);
            this.teacherLogin.TabIndex = 2;
            this.teacherLogin.Text = "Teacher Login";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelUser.Location = new System.Drawing.Point(145, 265);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(129, 29);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "UserName";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textUser.Location = new System.Drawing.Point(112, 323);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(188, 34);
            this.textUser.TabIndex = 5;
            // 
            // textPass
            // 
            this.textPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textPass.Location = new System.Drawing.Point(112, 453);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(188, 34);
            this.textPass.TabIndex = 6;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelPass.Location = new System.Drawing.Point(145, 398);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(129, 29);
            this.labelPass.TabIndex = 7;
            this.labelPass.Text = "UserName";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkPass.Location = new System.Drawing.Point(133, 525);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(159, 26);
            this.checkPass.TabIndex = 8;
            this.checkPass.Text = "Show password";
            this.checkPass.UseVisualStyleBackColor = true;
            // 
            // buttonTeacherLogin
            // 
            this.buttonTeacherLogin.Location = new System.Drawing.Point(112, 572);
            this.buttonTeacherLogin.Name = "buttonTeacherLogin";
            this.buttonTeacherLogin.Size = new System.Drawing.Size(188, 52);
            this.buttonTeacherLogin.TabIndex = 9;
            this.buttonTeacherLogin.Text = "Login";
            this.buttonTeacherLogin.UseVisualStyleBackColor = true;
            this.buttonTeacherLogin.Click += new System.EventHandler(this.buttonTeacherLogin_Click);
            // 
            // studentLogin
            // 
            this.studentLogin.AutoSize = true;
            this.studentLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.studentLogin.Location = new System.Drawing.Point(588, 208);
            this.studentLogin.Name = "studentLogin";
            this.studentLogin.Size = new System.Drawing.Size(161, 29);
            this.studentLogin.TabIndex = 11;
            this.studentLogin.Text = "Student Login";
            // 
            // textEnroll
            // 
            this.textEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textEnroll.Location = new System.Drawing.Point(512, 341);
            this.textEnroll.Name = "textEnroll";
            this.textEnroll.Size = new System.Drawing.Size(306, 34);
            this.textEnroll.TabIndex = 10;
            this.textEnroll.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelEnroll
            // 
            this.labelEnroll.AutoSize = true;
            this.labelEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelEnroll.Location = new System.Drawing.Point(534, 280);
            this.labelEnroll.Name = "labelEnroll";
            this.labelEnroll.Size = new System.Drawing.Size(250, 29);
            this.labelEnroll.TabIndex = 13;
            this.labelEnroll.Text = "Student Enrollment no";
            // 
            // buttonStudentRegister
            // 
            this.buttonStudentRegister.Location = new System.Drawing.Point(561, 485);
            this.buttonStudentRegister.Name = "buttonStudentRegister";
            this.buttonStudentRegister.Size = new System.Drawing.Size(188, 52);
            this.buttonStudentRegister.TabIndex = 14;
            this.buttonStudentRegister.Text = "Register";
            this.buttonStudentRegister.UseVisualStyleBackColor = true;
            this.buttonStudentRegister.Click += new System.EventHandler(this.buttonStudentRegister_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(561, 398);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(188, 52);
            this.buttonLog.TabIndex = 15;
            this.buttonLog.Text = "Login";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // passLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 645);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonStudentRegister);
            this.Controls.Add(this.labelEnroll);
            this.Controls.Add(this.studentLogin);
            this.Controls.Add(this.textEnroll);
            this.Controls.Add(this.buttonTeacherLogin);
            this.Controls.Add(this.checkPass);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.teacherLogin);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "passLabel";
            this.Text = "UserName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label teacherLogin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Button buttonTeacherLogin;
        private System.Windows.Forms.Label studentLogin;
        private System.Windows.Forms.TextBox textEnroll;
        private System.Windows.Forms.Label labelEnroll;
        private System.Windows.Forms.Button buttonStudentRegister;
        private System.Windows.Forms.Button buttonLog;
    }
}

