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


namespace lab4_ltcsdl
{
    public partial class quizz : Form
    {
        Random random = new Random();
        String cnstr = "Data Source=BIN\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        List<item> listItem = new List<item>();
        stuD stuDs = new stuD();
        private int remainingMinutes = 0;
        private int remainingSeconds = 0;
        private Timer countdownTimer;
        public quizz()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += CountdownTimer_Tick;
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        int count = 0;
        int score = 0;
        String ans;

        public void load_form()
        {
            if ( count == listItem.Count)
            {
                update_form();
                MessageBox.Show("your score is:" + score);
                this.Close();
                return;
            }
            qTotalQuestion.Text = listItem.Count.ToString();
            qQuestionNumber.Text = listItem[count].qNo.ToString();
            qRollNumber.Text = passLabel.stu;
            qName.Text = stuDs.name;

            radioButton1.Text = listItem[count].option1;
            radioButton2.Text = listItem[count].option2;
            radioButton3.Text = listItem[count].option3;
            radioButton4.Text = listItem[count].option4;
            label9.Text = listItem[count].question;
        }

        public void check(String x)
        {
            if(x == listItem[count].answer)
            {
                score++;
            }
        }
        public void update_score()
        {
            if (radioButton1.Checked)
            {
                check(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                check(radioButton2.Text);
            }
            else if (radioButton3.Checked)
            {
                check(radioButton3.Text);
            }
            else if (radioButton4.Checked)
            {
                check(radioButton4.Text);
            }
        }
        public void update_form()
        {
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "insert into student_score(rollNo, name, email, address, markObtained)" +
                    "values(@r,@n,@e,@a,@m)";
                cmd.CommandText = query;
                cmd.Parameters.Add("@r", SqlDbType.VarChar).Value = passLabel.stu;
                cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = passLabel.stu;
                cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = passLabel.stu;
                cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = passLabel.stu;
                cmd.Parameters.Add("@m", SqlDbType.VarChar).Value = score;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
            }

        }
        private void load()
        {
            // lay du lieu question
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select * from question " +
                    "where  qset= @qset";
                cmd.CommandText = query;
                cmd.Parameters.Add("@qset", SqlDbType.VarChar).Value = random.Next(1, 2);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        // Duyệt qua từng dòng dữ liệu
                        while (reader.Read())
                        {
                            item iem = new item();
                            iem.qNo = reader.GetInt32(1);
                            iem.question = reader.GetString(2);
                            iem.option1 = reader.GetString(3);
                            iem.option2 = reader.GetString(4);
                            iem.option3 = reader.GetString(5);
                            iem.option4 = reader.GetString(6);
                            iem.answer = reader.GetString(7);
                            iem.qset = reader.GetInt32(8);
                            listItem.Add(iem);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Không có dữ liệu.");
                    }

                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
            }
            //lay du lieu student
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select * from student " +
                    "where  roll_num= @name";
                cmd.CommandText = query;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = passLabel.stu;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        // Duyệt qua từng dòng dữ liệu
                        while (reader.Read())
                        {
                            stuDs.roll_num = reader.GetInt32(1);
                            stuDs.name = reader.GetString(2);
                            stuDs.email = reader.GetString(3);
                            stuDs.address = reader.GetString(4);
                            stuDs.contact_num = reader.GetString(5);
                        }
                    }
                    else
                    {

                        MessageBox.Show("Không có dữ liệu.");
                    }

                }
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
            }

        }
        private void quiz_Load(object sender, EventArgs e)
        {
            load();

            load_form();



        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            update_score();
            ++count;
            load_form();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            addQuestion upp = new addQuestion();
            upp.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
            }
            else
            {
                if (remainingMinutes > 0)
                {
                    remainingMinutes--;
                    remainingSeconds = 59;
                }
                else
                {
                    // Countdown finished
                    countdownTimer.Stop();
                    MessageBox.Show("Hết thời gian làm bài!");
                    this.Dispose();
                }
            }

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            IbMin.Text = remainingMinutes.ToString("00");
            IbSec.Text = remainingSeconds.ToString("00");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Set the initial countdown time to 60 minutes
            remainingMinutes = 1;
            remainingSeconds = 0;

            UpdateLabels();
            countdownTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            countdownTimer.Stop();
            MessageBox.Show("Đã nộp bài!");
            this.Close(); // Close the form
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
    

