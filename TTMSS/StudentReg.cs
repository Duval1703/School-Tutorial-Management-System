using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMSS
{
    public partial class StudentReg : Form
    {
        function fn = new function();
        String query;

        public StudentReg()
        {
            InitializeComponent();
        }

        private void StudentReg_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String sex = conboSex.Text;
            String matricule = txtMatricule.Text;
            String tel = txtContact.Text;
            String email = txtEmail.Text;
            String pass = txtPassword.Text;
            String confpass = txtPasswordConfirm.Text;

            if (name == "" || fname == "" || lname == "" || sex == "" || matricule == "" || tel == "" || email == "" || pass == "" || confpass == "")
            {
                MessageBox.Show("ALL FIELDS ARE MANDATORY", "Error");
            }
            else
            {
                if (pass == confpass)
                {
                    query = "insert into student(matricule,username,firstname,lastname,stdpassword,sex,contact,email) values ('" + matricule + "','" + name + "','" + fname + "','" + lname + "','" + pass + "','" + sex + "','" + tel + "','" + email + "');";
                    fn.setData(query, "You are Registered");
                    Form1 std = new Form1();
                    std.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password does not correspond", "Error");
                }
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPasswordConfirm.PasswordChar = '\0';
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPasswordConfirm.PasswordChar = '*';
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }
    }
}
