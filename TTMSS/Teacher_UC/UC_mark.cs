using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMSS.Teacher_UC
{
    public partial class UC_mark : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        int n = 1, count;
        float result;
        int id;

        private void btnstart_Click(object sender, EventArgs e)
        {
            btnnext.Visible = true;
            query = "select matricule,qset,qNo,question,youranswer,id from ( select top 1 * from structresult order by id) as firstrecord;";
            ds = fn.getData(query);

            txtMatricule.Text = ds.Tables[0].Rows[0][0].ToString();
            txtSet.Text = ds.Tables[0].Rows[0][1].ToString();
            txtQuestNo.Text = ds.Tables[0].Rows[0][2].ToString();
            txtQuestion.Text = ds.Tables[0].Rows[0][3].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][4].ToString();
            txtid.Text = ds.Tables[0].Rows[0][5].ToString();
            int.TryParse(txtid.Text, out id);

            btnstart.Visible = false;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            getresult(id);
            btnprevious.Visible = true;
            if (n < count - 1)
            {
                n++;
                id = display(n);
            }
            else if (n == count - 1)
            {
                btnnext.Text = "Finish";
                n++;
                id = display(n);
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (n > 2)
            {
                n--;
                id = display(n);
            }
            else if (n == 2)
            {
                n--;
                id = display(n);
                btnprevious.Visible = false;
            }
        }

        private void UC_mark_Load(object sender, EventArgs e)
        {
            btnprevious.Visible = false;
            btnnext.Visible = false;
            query = "select qset from structresult;";
            ds = fn.getData(query);
            count = ds.Tables[0].Rows.Count;

        }

        public int display(int i)
        {
            int val;
            i--;

            txtComment.Clear();
            txtMark.Clear();

            query = "select matricule,qset,qNo,question,youranswer,id from structresult";
            ds = fn.getData(query);

            txtMatricule.Text = ds.Tables[0].Rows[i][0].ToString();
            txtSet.Text = ds.Tables[0].Rows[i][1].ToString();
            txtQuestNo.Text = ds.Tables[0].Rows[i][2].ToString();
            txtQuestion.Text = ds.Tables[0].Rows[i][3].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[i][4].ToString();
            txtid.Text = ds.Tables[0].Rows[i][5].ToString();

            if (int.TryParse(txtid.Text, out val))
            {
                return val;
            }
            else
            {
                return -1;
            }



        }

        public void getresult(int id)
        {
            query = "update  structresult set result = '" + txtMark.Text + "',comment = '" + txtComment.Text + "' where id = '" + id + "'";
            fn.setDatas(query);
        }



        public UC_mark()
        {
            InitializeComponent();
        }


    }
}
