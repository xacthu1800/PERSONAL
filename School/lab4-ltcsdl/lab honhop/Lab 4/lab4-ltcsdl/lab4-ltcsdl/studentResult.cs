using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace lab4_ltcsdl
{
    public partial class studentResult : Form
    {
        String cnstr = "Data Source=BIN\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection Ketnoi;
        SqlCommand Thuchien;
        SqlDataReader Docdulieu;
        string Lenh;
        int i;
        public studentResult()
        {
            InitializeComponent();
            Ketnoi = new SqlConnection(cnstr);
            Lenh = @"SELECT name
            FROM   student";

            HashSet<string> uniqueValues = new HashSet<string>();

            using (SqlCommand Thuchien = new SqlCommand(Lenh, Ketnoi))
            {
                Ketnoi.Open();
                using (SqlDataReader Docdulieu = Thuchien.ExecuteReader())
                {
                    while (Docdulieu.Read())
                    {
                        string nameValue = Docdulieu[0].ToString();


                        if (uniqueValues.Add(nameValue))
                        {
                            uComSet.Items.Add(nameValue);
                        }
                    }
                }
            }
            Ketnoi.Close();
        }

        private void studentResult_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.lab4_ltcsdlDataSet.student);

        }

        private void uComSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = uComSet.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedName))
            {
                string query = "SELECT Id, roll_num, name, email, address, contact_num FROM student WHERE name = @Name";

                using (SqlConnection connection = new SqlConnection(cnstr))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", selectedName);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            dataGridView1.DataSource = null;

                            dataGridView1.DataSource = dataTable;

                            uComSet.SelectedItem = selectedName;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

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

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            viewQuestion upp = new viewQuestion();
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
