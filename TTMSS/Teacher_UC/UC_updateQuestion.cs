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

namespace TTMSS.Teacher_UC
{
    public partial class UC_updateQuestion : UserControl
    {
        function fn = new function();
        String query,query1;
        DataSet ds,ds1;
        public UC_updateQuestion()
        {
            InitializeComponent();
        }

        private void UC_updateQuestion_Load(object sender, EventArgs e)
        {
            MCQpanel.Visible = false;
            Structuralpanel.Visible = false;
        }

        private void comboselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboselect.SelectedIndex == 0)
            {
                MCQpanel.Visible = true;
                Structuralpanel.Visible = false;
                comboSet.Items.Clear();
                query = "select distinct qset from questions;";
                ds = fn.getData(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
            else if (comboselect.SelectedIndex == 1)
            {
                MCQpanel.Visible = false;
                Structuralpanel.Visible = true;
                combostructSet.Items.Clear();
                query = "select distinct qSet from structuralquestion;";
                ds = fn.getData(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    combostructSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboQuestion.Items.Clear();

            query = "select distinct qNo from questions where qset = '"+ comboSet.Text + "';";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void comboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,optionA,optionB,optionC,optionD,ans from questions where qset = '" + comboSet.Text + "' and qNo = '" + comboQuestion.Text + "'";
            ds = fn.getData(query);
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
            comboSet.SelectedIndex = -1;
            comboQuestion.SelectedIndex = -1;
        }
        public void structclearAll()
        {
            txtstructQuestion.Clear();
            txtstructAnswer.Clear();
            combostructSet.SelectedIndex = -1;
            combostructQuestion.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboQuestion.SelectedIndex != -1)
            {
                String qset = comboSet.Text;
                String qNo = comboQuestion.Text;
                String question = txtQuestion.Text;
                String option1 = txtOption1.Text;
                String option2 = txtOption2.Text;
                String option3 = txtOption3.Text;
                String option4 = txtOption4.Text;
                String ans = txtAnswer.Text;

                query = "update questions set question = '" + question + "',optionA = '" + option1 + "',optionB = '" + option2 + "',optionC = '" + option3 + "',optionD = '" + option4 + "',ans ='" + ans + "' where qset='" + qset + "' and qNo='" + qNo + "'";

                fn.setData(query, "Question No : " + qNo + " \nQuestion Set : " + qset + " \n is Updated.");

            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_updateQuestion_Load(this, null);
        }

        private void combostructSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            combostructQuestion.Items.Clear();
            query = "select distinct qNo from structuralquestion where qset = '" + combostructSet.Text + "';";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                combostructQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void combostructQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select question,answer from structuralquestion where qSet = '" + combostructSet.Text + "' and qNo = '" + combostructQuestion.Text + "'";
            ds = fn.getData(query);
            txtstructQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtstructAnswer.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        private void btnstructReset_Click(object sender, EventArgs e)
        {
            structclearAll();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnstustUpdate_Click(object sender, EventArgs e)
        {
            if (combostructQuestion.SelectedIndex != -1)
            {
                String qset = combostructSet.Text;
                String qNo = combostructQuestion.Text;
                String question = txtstructQuestion.Text;
                String ans = txtstructAnswer.Text;

                query = "update structuralquestion set question = '" + question + "',answer ='" + ans + "' where qSet='" + qset + "' and qNo='" + qNo + "'";

                fn.setData(query, "Question No : " + qNo + " \nQuestion Set : " + qset + " \n is Updated.");

            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Structuralpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
