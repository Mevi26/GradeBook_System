using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GradeBook_System
{
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Need Login data", "Wrong Login ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

            }
                string uname = textBox_username.Text;
            string pass = textBox_password.Text;
            DataTable table= student.getList(new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM `resu` WHERE `username`='"+ uname + "' AND `password`='"+ pass + "'"));
        if (table.Rows.Count > 0)
            {
                Form1 main = new Form1();
                this.Hide();
                main.Show();
            }
        else
            {
              
                MessageBox.Show("Your username and password are not exists", "Wrong Login ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
