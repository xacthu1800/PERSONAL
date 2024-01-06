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

namespace lab4_ltcsdl
{
    public partial class studentRegisterForm : Form
    {
        String cnstr = "Data Source=BIN\\SQLEXPRESS01;Initial Catalog=lab4_ltcsdl;Integrated Security=True";
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public studentRegisterForm()
        {
            InitializeComponent();
        }

        private void rButtonRegister_Click(object sender, EventArgs e)
        {
            using (cnn = new SqlConnection(cnstr))
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();

                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;
                String query = "insert into student(roll_num, name, email, address, contact_num)" +
                     "values (@r, @n, @e, @a, @c)";
                cmd.CommandText = query;
                cmd.Parameters.Add("@r", SqlDbType.VarChar).Value = int.Parse((String)rTextRollNum.Text);
                cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = (String)rTextName.Text;
                cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = (String)rTextEmail.Text;
                cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = (String)rTextAddress.Text;
                cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = (String)rTextContactNum.Text;

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                cnn.Close();
                this.Close();
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            addQuestion upp = new addQuestion();
            upp.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            updateQuestion upp = new updateQuestion();
            upp.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {

        }

        private void studentRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
