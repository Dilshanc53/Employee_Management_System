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
    public partial class viewEmp : Form
    {
        public viewEmp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Myplu\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void fetchempdata()
        {
            con.Open();
            String query = $"SELECT * FROM [Table] WHERE EmpId = '{EmpIdsearch.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmpIdlbl.Text = dr["EmpId"].ToString();
                    EmpPoslbl.Text = dr["EmpPos"].ToString();
                    EmpEdulbl.Text = dr["EmpEdu"].ToString();
                    EmpNamelbl.Text = dr["EmpName"].ToString();
                    EmpIdlbl.Visible = true;
                    EmpPoslbl.Visible = true;
                    EmpEdulbl.Visible = true;
                    EmpNamelbl.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No matching employee ID found.");
            }

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void viewEmp_Load(object sender, EventArgs e)
        {

        }

        private void EmpIdlbl_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
