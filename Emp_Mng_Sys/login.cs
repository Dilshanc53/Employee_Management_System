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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        


       
            private void button1_Click(object sender, EventArgs e)
            {
            try
            {
                // Connection string to your database
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Myplu\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30";

                // Create a connection object
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Query to get the list of table names
                    string query = "USE MyEmployeeDb; SELECT name FROM sys.tables;";

                    // Create a command object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and get the list of table names
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> tableNames = new List<string>();
                            while (reader.Read())
                            {
                                tableNames.Add(reader.GetString(0));
                            }

                            // Display the table names
                            foreach (string tableName in tableNames)
                            {
                                MessageBox.Show(tableName);
                            }
                        }
                    }

                    // Close the connection
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        
        /* string usrname = txtusr.Text;
         string pwd = txtpwd.Text;

         try
         {
             using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Myplu\Documents\MyEmployeeDb.mdf;Integrated Security=True;Connect Timeout=30"))
             {
                 con.Open();
                 string query = "SELECT * FROM [adminlogin];";
                 SqlCommand cmd = new SqlCommand(query, con);
                 cmd.Parameters.AddWithValue("@usrname", usrname);
                 cmd.Parameters.AddWithValue("@pwd", pwd);

                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);

                 if (dt.Rows.Count > 0)
                 {
                     Employee employeeForm = new Employee();
                     employeeForm.Show();
                     this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("Invalid username or password. Please try again.");
                 }
             }
         }
         catch (Exception ex)
         {
             MessageBox.Show("An error occurred: " + ex.Message);

         }*/
    }

        

        private void txtusr_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
