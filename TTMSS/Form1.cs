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
using static System.Collections.Specialized.BitVector32;

namespace TTMSS
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wrongLabel.Visible = false;
        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if (txtSelectUser.SelectedIndex == 1)
            {
                panel2.Visible = false;
                panel1.Visible = true;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Paul" && txtPassword.Text == "Paul@23")
            {
                wrongLabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }

        private void checkBoxShowHide2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide2.Checked == true)
            {
                stdPassword.PasswordChar = '\0';
                checkBoxShowHide2.Text = "Hide Password";
            }
            else
            {
                stdPassword.PasswordChar = '*';
                checkBoxShowHide2.Text = "Show Password";
            }
        }

        public bool ValidateLogin(string matricule, string password)
        {
            string connectionString = "data source = DESKTOP-EN05MG1\\SQLEXPRESS;database =TMS;integrated security = True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM student WHERE matricule = @Matricule AND stdpassword = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Matricule", matricule);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            bool valid = ValidateLogin(txtEnrollementNo.Text, stdPassword.Text);
            if(valid == true)
            {
                string matricule = txtEnrollementNo.Text;
                query = "select username from student where matricule = '" + matricule + "'";
                ds = fn.getData(query);
                string name = ds.Tables[0].Rows[0][0].ToString();
                stdwrongLabel.Visible = false;
                Student std = new Student(name,matricule);
                std.Show();
                this.Hide();
            }
            else
            {
                stdwrongLabel.Visible = true;
            }

        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            stdwrongLabel.Visible = false;
            StudentReg stdreg = new StudentReg();
            stdreg.Show();
            this.Hide();
        }
    }
}
