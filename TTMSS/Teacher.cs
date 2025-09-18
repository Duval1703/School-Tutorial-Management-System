using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMSS.Teacher_UC;

namespace TTMSS
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void uC_ViewDeleteQuetsion1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = false;
            uC_updateQuestion1.Visible = false;
            uC_ViewDeleteQuetsion1.Visible = false;
            uC_result1.Visible = false;
            uC_mark1.Visible = false;
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestion1.Visible = true;
            uC_AddNewQuestion1.BringToFront();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_updateQuestion1.Visible = true;
            uC_updateQuestion1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewDeleteQuetsion1.Visible = true;
            uC_ViewDeleteQuetsion1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            uC_result1.Visible = true;
            uC_result1.BringToFront(); 
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            uC_mark1.Visible = true ;
            uC_mark1.BringToFront();
        }
    }
}
