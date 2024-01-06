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
namespace lab4_ltcsdl
{
    public partial class viewQuestion : Form
    {
        String cnstr = "Data Source=BIN\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection Ketnoi;
        SqlCommand Thuchien;
        SqlDataReader Docdulieu;
        string Lenh;
        int i;
        public viewQuestion()
        {
            InitializeComponent();
            Ketnoi = new SqlConnection(cnstr);
            Lenh = @"SELECT qset
            FROM   question";

            HashSet<string> uniqueValues = new HashSet<string>();  

            using (SqlCommand Thuchien = new SqlCommand(Lenh, Ketnoi))
            {
                Ketnoi.Open();
                using (SqlDataReader Docdulieu = Thuchien.ExecuteReader())
                {
                    while (Docdulieu.Read())
                    {
                        string qsetValue = Docdulieu[0].ToString();

        
                        if (uniqueValues.Add(qsetValue))
                        {
                            uComSet.Items.Add(qsetValue);  
                        }
                    }
                }
            }
            Ketnoi.Close();
        }





        private void viewQuestion_Load(object sender, EventArgs e)
        {
            //this.questionTableAdapter.Fill(this.lab4_ltcsdlDataSet.question);

        }

        private void uComSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedQset = uComSet.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedQset))
            {
                string query = "SELECT questionId, qNo, question, option1, option2, option3, option4, answer, qset FROM question WHERE qset = @qset";

                using (SqlConnection connection = new SqlConnection(cnstr))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@qset", selectedQset);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                
                            dataGridView1.DataSource = null; 
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;

                        
                            uComSet.SelectedItem = selectedQset;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            if (selectedRowIndex >= 0)
            {
                int questionIdToDelete = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells["questionId"].Value.ToString());

            }
        }
        private void uButtonUpdate_Click(object sender, EventArgs e)
        { }






















        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            addQuestion upp = new addQuestion();
            upp.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            updateQuestion upp = new updateQuestion();
            upp.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            studentResult upp = new studentResult();
            upp.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
