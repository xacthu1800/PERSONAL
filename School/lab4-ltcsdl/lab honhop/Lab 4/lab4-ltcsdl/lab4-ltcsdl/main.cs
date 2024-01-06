using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace lab4_ltcsdl
{
    public partial class passLabel : Form
    {
        String cnstr = "Data Source=BIN\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public static String stu, _Account, _Password;
        public passLabel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            teacherLogin.Visible = false;
            labelUser.Visible = false;
            labelPass.Visible = false;
            textPass.Visible = false;
            textUser.Visible = false;
            buttonTeacherLogin.Visible = false;
            checkPass.Visible = false;

            studentLogin.Visible = false;
            labelEnroll.Visible = false;
            textEnroll.Visible = false;
            buttonLog.Visible = false;
            buttonStudentRegister.Visible = false;

            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Student");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();


            if (selectedValue == "Teacher")
            {
                teacherLogin.Visible = true;
                labelUser.Visible = true;
                labelPass.Visible = true;
                textPass.Visible = true;
                textUser.Visible = true;
                buttonTeacherLogin.Visible = true;
                checkPass.Visible = true;

                studentLogin.Visible = false;
                labelEnroll.Visible = false;
                textEnroll.Visible = false;
                buttonLog.Visible = false;
                buttonStudentRegister.Visible = false;
            }
            else if (selectedValue == "Student")
            {
                studentLogin.Visible = true;
                labelEnroll.Visible = true;
                textEnroll.Visible = true;
                buttonLog.Visible = true;
                buttonStudentRegister.Visible = true;

                teacherLogin.Visible = false;
                labelUser.Visible = false;
                labelPass.Visible = false;
                textPass.Visible = false;
                textUser.Visible = false;
                buttonTeacherLogin.Visible = false;
                checkPass.Visible = false;
            }
            
        }

        private void buttonStudentRegister_Click(object sender, EventArgs e)
        {
            studentRegisterForm registerForm = new studentRegisterForm();
            registerForm.Show();
        }

        private void buttonStudentLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            stu = textEnroll.Text;
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select * from student where roll_num = @rollNum ";
                cmd.CommandText = query;
                cmd.Parameters.Add("@rollNum", SqlDbType.VarChar).Value = int.Parse((String)textEnroll.Text);


                int x = (int)cmd.ExecuteScalar();
                if (x == null)
                {
                    MessageBox.Show("enroll number is wrong or not exist");
                    return;
                }
                quizz quiz = new quizz();
                quiz.Show();
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
                
            }      
            
        }

        private void buttonTeacherLogin_Click(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(cnstr))
            {

                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select * from teacher " +
                    "where account=@acc AND password=@pass";
                cmd.CommandText = query;
                cmd.Parameters.Add("@acc", SqlDbType.VarChar).Value = (String)textUser.Text;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = (String)textPass.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String accc = reader["account"].ToString();
                        String passs = reader["password"].ToString();
                        if (accc == textUser.Text && passs == textPass.Text)
                        {
                            _Password = textPass.Text;
                            _Account = textUser.Text;
                            addQuestion add = new addQuestion();
                            add.Show();
                        }
                        else
                        {
                            MessageBox.Show("wrong account or password");
                        }
                    }
                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                reader.Close();
                cnn.Close();
            }

        }
    }
}
