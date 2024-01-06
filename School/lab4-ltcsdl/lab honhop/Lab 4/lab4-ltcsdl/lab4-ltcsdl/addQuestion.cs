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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab4_ltcsdl
{
    public partial class addQuestion : Form
    {
        String cnstr = "Data Source=Bin\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public addQuestion()
        {
            InitializeComponent();
        }

        int countt = 0 ;
        private void textSet_TextChanged(object sender, EventArgs e)
        {
            if (textSet.Text == "")
                return;
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select count(*) from question " +
                    "where  qset= @qset";
                cmd.CommandText = query;
                cmd.Parameters.Add("@qset", SqlDbType.VarChar).Value = int.Parse((String)textSet.Text);

                int count = (int)cmd.ExecuteScalar();
                countt = count;
                questionNumber.Text = count.ToString();
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
            }
        }

        private void textSet_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "insert into question(qNo, question, option1, option2, option3, option4, answer, qset)" +
                    "values ((SELECT count(*) + 1 FROM question WHERE qset = @qset), @q, @o1, @o1, @o3, @o4, @a, @qset)";
                cmd.CommandText = query;
                cmd.Parameters.Add("@qset", SqlDbType.VarChar).Value = int.Parse((String)textSet.Text);
                cmd.Parameters.Add("@q", SqlDbType.VarChar).Value = (String)textQuestion.Text;
                cmd.Parameters.Add("@o1", SqlDbType.VarChar).Value = (String)textOption1.Text;
                cmd.Parameters.Add("@o2", SqlDbType.VarChar).Value = (String)textOption2.Text;
                cmd.Parameters.Add("@o3", SqlDbType.VarChar).Value = (String)textOption3.Text;
                cmd.Parameters.Add("@o4", SqlDbType.VarChar).Value = (String)textOption4.Text;
                cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = (String)textAnswer.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
            }

            questionNumber.Text = (++countt).ToString();
            textQuestion.Text = "";
            textOption1.Text = "";
            textOption2.Text = "";
            textOption3.Text = "";
            textOption4.Text = "";
            textAnswer.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textSet.Text = "0";
            textQuestion.Text = "";
            textOption1.Text = "";
            textOption2.Text = "";
            textOption3.Text = "";
            textOption4.Text = "";
            textAnswer.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addQuestion_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            addQuestion upp = new addQuestion();
            upp.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
         
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            updateQuestion upp = new updateQuestion();
            upp.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            viewQuestion upp = new viewQuestion();
            upp.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            studentResult upp = new studentResult ();
            upp.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
