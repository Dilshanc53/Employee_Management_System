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
//using System.Drawing;

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

        private void EmpDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow row = EmpDGV.Rows[e.RowIndex];

            // Set the values of the TextBoxes to the values in the selected row
            EmpId.Text = row.Cells["EmpId"].Value.ToString();
            EmpName.Text = row.Cells["EmpName"].Value.ToString();
            EmpEdu.SelectedItem = row.Cells["EmpEdu"].Value.ToString();
            EmpPos.SelectedItem = row.Cells["EmpPos"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "" || EmpPos.Text == "" || EmpEdu.Text == "")
            {
                MessageBox.Show("MIssing information!");
            }
            else
            {
                try
                {
                    con.Open();
                    //String query = "UPDATE [Table] set EmpId = '"+EmpId.Text+"', EmpName = '"+EmpName.Text+"',EmpEdu =      ";
                    String query = $"UpDATE [Table] set EmpId = '{EmpId.Text}', EmpNmae = EmpName = '{EmpName.Text}', EmpPos = '{EmpPos.Text}', EmpEdu = '{EmpEdu.Text}'"; 
                    con.Close();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "")
            {
                MessageBox.Show("Enter the Employee ID");
            }
            else
            {
                try
                /* {
                     con.Open();
                     String query = "delete from [Table] WHERE EmpId = " + EmpId.Text + ";";
                     SqlCommand cmd = new SqlCommand(query, con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Employee Deleted Successfully");
                     con.Close();
                 }*/
                {
                    con.Open();
                    String query = "DELETE FROM [Table] WHERE EmpId = @EmpId;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmpId", EmpId.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Employee with entered EmpId not found in the table");
                    }
                    else
                    {
                        MessageBox.Show("Employee Deleted Successfully");
                    }
                    con.Close();
                    populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                    con.Close();
                }
            }
        }

        private void EmpPos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Employee_Paint(object sender, PaintEventArgs e)
        {


           /* // Create a LinearGradientBrush that will paint from top to bottom
            LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle, Color.Red, Color.Yellow, LinearGradientMode.Vertical);

                // Set the form's BackgroundImage property to the LinearGradientBrush
                this.BackgroundImage = new Bitmap(this.Width, this.Height);
                using (Graphics g = Graphics.FromImage(this.BackgroundImage))
                {
                    g.FillRectangle(brush, this.ClientRectangle);
                }*/
            

        }
    }
}
