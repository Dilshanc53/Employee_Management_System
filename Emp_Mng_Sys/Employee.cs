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

namespace Emp_Mng_Sys
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Myplu\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Employee()
        {
            InitializeComponent();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "")
                MessageBox.Show("Please fill the information!");
            else
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO [Table] (EmpId, EmpName, EmpEdu, EmpPos) VALUES ('" + EmpId.Text + "', '" + EmpName.Text + "', '" + EmpEdu.SelectedItem.ToString() + "', '" + EmpPos.SelectedItem.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee successfully added");
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void populate()
        {
            con.Open();
            String query = "select * from [Table]";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myEmployeeDbDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.myEmployeeDbDataSet.Table);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
