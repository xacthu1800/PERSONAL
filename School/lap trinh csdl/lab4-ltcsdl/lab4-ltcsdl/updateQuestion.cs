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
    public partial class updateQuestion : Form
    {
        String cnstr = "Data Source=Bin\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        int set;
        List<item> listItem = new List<item>();
        item Item = new item();
        public updateQuestion()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void updateQuestion_Load(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "select * from question ";
                cmd.CommandText = query;
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

            load_combobox1();
        }

        private void uComSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_combobox2();
        }

        private void load_combobox2()
        {
            int c = 0;
            while (c < listItem.Count)
            {
                if (listItem[c].qset == (int)(uComSet.SelectedItem))
                {
                    uComQuestionno.Items.Add(listItem[c].qNo);
                }
                ++c;
            }
        }
        private void load_combobox1()
        {
            int count = 0;
            while (count < listItem.Count)
            {
                if (listItem[count].qset > set)
                {
                    set = listItem[count].qset;
                    uComSet.Items.Add(set);
                    if(++count == listItem.Count)
                    {
                        uComSet.Items.Add(++set);
                    }
                }
                ++count;
            }

        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uComQuestionno_SelectedIndexChanged(object sender, EventArgs e)
        {
            int setSelected = (int)(uComSet.SelectedItem);
            int index = (int)(uComQuestionno.SelectedItem);
            foreach ( item obj in listItem)
            {
                if (obj.qNo == index && obj.qset == setSelected )
                {
                    uTextQuestion.Text = obj.question;
                    uTextOption1.Text = obj.option1;
                    uTextOption2.Text = obj.option2;
                    uTextOption3.Text = obj.option3;
                    uTextOption4.Text = obj.option4;
                    uTextAnswer.Text = obj.answer;
                    Item = obj;
                    break; 
                }
            }
        }

        private void uButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (cnn = new SqlConnection(cnstr))
                {
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cnn;
                    String query = "UPDATE question" +
                        " SET question = @question," +
                        " option1 = @o1," +
                        " option2 = @o2," +
                        " option3 = @o3," +
                        " option4 = @o4," +
                        " answer = @a" +
                        " WHERE qNo = @qNo AND qset = @qset";

                    cmd.CommandText = query;

                    cmd.Parameters.Add("@question", SqlDbType.VarChar).Value = uTextQuestion.Text;
                    cmd.Parameters.Add("@o1", SqlDbType.VarChar).Value = uTextOption1.Text;
                    cmd.Parameters.Add("@o2", SqlDbType.VarChar).Value = uTextOption2.Text;
                    cmd.Parameters.Add("@o3", SqlDbType.VarChar).Value = uTextOption3.Text;
                    cmd.Parameters.Add("@o4", SqlDbType.VarChar).Value = uTextOption4.Text;
                    cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = uTextAnswer.Text;
                    cmd.Parameters.Add("@qNo", SqlDbType.Int).Value = Item.qNo;
                    cmd.Parameters.Add("@qset", SqlDbType.Int).Value = Item.qset;


                    //cmd.ExecuteNonQuery();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Commit giao dịch nếu có thay đổi
                        MessageBox.Show("Update successful");
                    }
                    else
                    {
                        // Rollback nếu không có bản ghi nào được cập nhật
                        MessageBox.Show("No rows updated");
                    }

                    cmd.Parameters.Clear();
                    cmd.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message);
            }


        }

        private void uButtonReset_Click(object sender, EventArgs e)
        {
           
        }
    }
}
