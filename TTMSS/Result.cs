using System;
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
    public partial class Result : Form
    {
        function fn = new function();
        String query, stdquery;
        DataSet ds, stdds;

       
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Result(string name, string matricule)
        {
            InitializeComponent();
            txtRollNo.Text = matricule;
            txtName.Text = name;
        }

        private void Result_Load(object sender, EventArgs e)
        {
             
            query = "select qset, qNo,question,youranswer,correctanswer from resultMCQ where matricule = '"+ txtRollNo.Text + "' ";
            ds = fn.getData(query);
            dataGridView.DataSource = ds.Tables[0];

            stdquery = "select qset, qNo,question,youranswer,correctanswer from structresult where matricule = '" + txtRollNo.Text + "' ";
            stdds = fn.getData(stdquery);
            dataGridView1.DataSource = stdds.Tables[0];

            gettotal();

        }

      
        private void gettotal()
        { 
            int count=0;

            query = "select youranswer, correctanswer from resultMCQ where matricule ='"+ txtRollNo .Text+ "';";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string yans = ds.Tables[0].Rows[i][0].ToString();
                string cans = ds.Tables[0].Rows[i][1].ToString();

                if (yans == cans)
                {
                    count++;
                }
            }

            Mark.Text = count.ToString();

            stdquery = "insert into result (matricule,name,mcqmark) values ('" + txtRollNo.Text + "','" + txtName.Text + "','" + Mark.Text + "')";
            fn.setDatas(stdquery);

        }

    }
}
