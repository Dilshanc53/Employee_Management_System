using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emp_Mng_Sys
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            viewEmp viewEmp = new viewEmp();
            viewEmp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            viewEmp log = new viewEmp();
            log.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            salary salary = new salary();
            salary.Show();
            this.Hide();
        }
    }
}
