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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Myplu\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void fetchempdata()
        {
            con.Open();
            String query = $"SELECT * FROM [Table] WHERE EmpId = '{EmpIdsearch_view.Text}'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    EmpName_view.Text = dr["EmpName"].ToString();
                    EmpPos_view.Text = dr["EmpPos"].ToString();
                    EmpName_view.Visible = true;
                    EmpPos_view.Visible = true;
                    
                   
                }
            }
            else
            {
                MessageBox.Show("No matching employee ID found.");
            }

            con.Close();
        }

        private int Getsalary()
        {
            try
            {
                int salary;
                if (EmpPos_view.Text == "Manager")
                {
                    salary = 25000 * Convert.ToInt32(workeddays.Text);
                    return salary;
                }
                else if (EmpPos_view.Text == "Senior Developer")
                {
                    salary = 5000 * Convert.ToInt32(workeddays.Text);
                    return salary;
                }
                else if (EmpPos_view.Text == "Junior Developer")
                {
                    salary = 2000 * Convert.ToInt32(workeddays.Text);
                    return salary;
                }
                else if (EmpPos_view.Text == "Accountant")
                {
                    salary = 1000 * Convert.ToInt32(workeddays.Text);
                    return salary;
                }
                else
                {
                    return 0;
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salary_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchempdata();

        }

        private void EmpIdlbl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmpName_view_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*// richTextBox1.AppendText() = Getsalary() ;
            string text = $"Name =  Salary = {Convert.ToString(Getsalary())}";
            richTextBox1.Text = text;*/

                int salary = Getsalary();
                string text = $"Name = {EmpName_view.Text} Salary = {salary}";
                richTextBox1.AppendText(text + Environment.NewLine);
            


        }

        private void EmpIdsearch_view_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
