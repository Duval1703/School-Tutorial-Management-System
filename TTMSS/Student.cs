using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace TTMSS
{
    public partial class Student : Form
    {

        function fn = new function();
        String query,query1,query3;
        DataSet ds,ds1,ds3;

        int countqset,countquest, countqstructset, countqstructquest,i = 0,j=0;

        private void structQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnstrucnext_Click(object sender, EventArgs e)
        {
            string structuralans="";
            string correct;
            if (structans.Text == "")
            {
                wrongLabel2.Visible = true;
            }
            else
            {
                structuralans = structans.Text;
            }
            if (structuralans != "")
            {
                wrongLabel2.Visible = false;
                query = "select answer from structuralquestion where qSet='" + txtsetNo.Text + "' and qNo='" + txtQuestionNo.Text + "'";
                ds = fn.getData(query);
                correct = ds.Tables[0].Rows[0][0].ToString();
                query1 = "insert into structresult (qset,qNo,question,youranswer,correctanswer,matricule) values ('" + txtsetNo.Text + "','" + txtQuestionNo.Text + "','" + structQuestion.Text + "','" + structuralans + "','" + correct + "','" + txtRollNo.Text + "')";
                fn.setDatas(query1);
                structans.Clear();  
                displaystruct();
            }

            
        }

        

        private void btnstructstart_Click(object sender, EventArgs e)
        {
           
            structans.Visible = true;
            btnstrucnext.Visible = true;
            structQuestion.Visible = true;
            btnstructstart.Visible = false;
            j = 0;
            i = 0;
            displaystruct();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Question.Visible = true;
            radOption1.Visible = true;
            radOption2.Visible = true;
            radOption3.Visible = true;
            radOption4.Visible = true;
            btnNext.Visible = true;
            btnstart.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;

            displayquestion();
        }

        public void displayquestion()
        {
            if (i < countqset)
            {
                query1 = "select distinct qSet from questions;";
                ds1 = fn.getData(query1);

                query = "select qNo from questions where qset = '" + ds1.Tables[0].Rows[i][0].ToString() + "';";
                ds = fn.getData(query);
                countquest = ds.Tables[0].Rows.Count;

                txtTotalNo.Text = countquest.ToString();
                txtsetTotalNo.Text = countqset.ToString();
                txtsetNo.Text = ds1.Tables[0].Rows[i][0].ToString();
            }
            else
            {
                MessageBox.Show("We are moving to Structural Questions.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                i = 0;
                j = 0;

                panel2.Visible=true;
              
                query = "select distinct qset from structuralquestion";
                ds = fn.getData(query);
                countqstructset = ds.Tables[0].Rows.Count;

                
            }
            if (j < countquest)
            {
                query = "select question,optionA,optionB,optionC,optionD from questions where qset = '" + txtsetNo.Text + "'";
                ds = fn.getData(query);
                Question.Text = ds.Tables[0].Rows[j][0].ToString();
                radOption1.Text = ds.Tables[0].Rows[j][1].ToString();
                radOption2.Text = ds.Tables[0].Rows[j][2].ToString();
                radOption3.Text = ds.Tables[0].Rows[j][3].ToString();
                radOption4.Text = ds.Tables[0].Rows[j][4].ToString();
                query = "select qNo from questions question where question = '" + Question.Text + "'";
                ds = fn.getData(query);
                txtQuestionNo.Text = ds.Tables[0].Rows[0][0].ToString();

                j++;
            }
            else 
            {
                MessageBox.Show("Next Set.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i++;
                j = 0;
                displayquestion();
            }
        }

        public void displaystruct()
        {
            if (i < countqstructset)
            {
                query1 = "select distinct qSet from structuralquestion;";
                ds1 = fn.getData(query1);

                query = "select qNo from structuralquestion where qset = '" + ds1.Tables[0].Rows[i][0].ToString() + "';";
                ds = fn.getData(query);
                countqstructquest = ds.Tables[0].Rows.Count;

                txtTotalNo.Text = countqstructquest.ToString();
                txtsetTotalNo.Text = countqstructset.ToString();
                txtsetNo.Text = ds1.Tables[0].Rows[i][0].ToString();
            }
            else
            {
                MessageBox.Show("Finish.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Result result = new Result(txtName.Text, txtRollNo.Text);
                result.Show();
                this.Hide();
            }
            if (j < countqstructquest)
            {
                query3 = "select question from structuralquestion where qset = '" + txtsetNo.Text + "'";
                ds3 = fn.getData(query3);
                structQuestion.Text = ds3.Tables[0].Rows[j][0].ToString();

                query = "select qNo from structuralquestion question where question = '" + structQuestion.Text + "'";
                ds = fn.getData(query);
                txtQuestionNo.Text = ds.Tables[0].Rows[0][0].ToString();

                j++;
            }
            else
            {
                MessageBox.Show("Next Set.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                i++;
                j = 0;
                displaystruct();
            }
        }

        public Student(string name,string matricule)
        {
            InitializeComponent();
            txtName.Text = name;
            txtRollNo.Text = matricule;
        }

        private void Student_Load(object sender, EventArgs e)
        {
             Question.Visible = false;
            radOption1.Visible = false;
            radOption2.Visible = false;
            radOption3.Visible = false;
            radOption4.Visible = false;
            btnNext.Visible = false;
            btnstart.Visible = true;
            panel2.Visible = false;
            panel1.Visible = true;
            structans.Visible = false;
            btnstrucnext.Visible = false;
            structQuestion.Visible = false;
            wrongLabel1.Visible = false;
            wrongLabel2.Visible = false;

            query = "select distinct qset from questions";
            ds = fn.getData(query);
            countqset = ds.Tables[0].Rows.Count;

            query1 = "select distinct qset from structuralquestion";
            ds1 = fn.getData(query1);
            countqstructset = ds1.Tables[0].Rows.Count;


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string answer="";
            string correct;

            if(radOption1.Checked)
            {
                answer= radOption1.Text;
                
            }
            else if (radOption2.Checked)
            {
                answer = radOption2.Text;
                
            }
            else if (radOption3.Checked)
            {
                answer = radOption3.Text;
                
            }
            else if (radOption4.Checked)
            {
                answer = radOption4.Text;
                
            }
            else
            {
                wrongLabel1.Visible = true;
            }
            if(answer != "")
            {
                wrongLabel1.Visible = false;
                query = "select ans from questions where qset='" + txtsetNo.Text + "' and qNo='" + txtQuestionNo.Text + "'";
                ds = fn.getData(query);
                correct = ds.Tables[0].Rows[0][0].ToString();
                query1 = "insert into resultMCQ (qset,qNo,question,youranswer,correctanswer,matricule) values ('"+ txtsetNo.Text + "','"+ txtQuestionNo.Text + "','"+ Question.Text + "','" + answer + "','" + correct + "','"+ txtRollNo.Text + "')";
                fn.setDatas(query1);
                radOption1.Checked = false;
                radOption2.Checked = false;
                radOption3.Checked = false;
                radOption4.Checked = false;

                displayquestion();
            }
            
        }
    }
}
