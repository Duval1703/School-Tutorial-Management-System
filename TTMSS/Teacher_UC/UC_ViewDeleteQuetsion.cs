using System;
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
    public partial class UC_ViewDeleteQuetsion : UserControl
    {
        function fn = new function();
        String query, stdquery;
        DataSet ds,  stdds;
        String id, stid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch { }
        }

        private void combostructSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;

            if (combostructSet.SelectedIndex != 0)
            {
                stdquery = "select id,qNo,question,answer from structuralquestion where qSet = '" + combostructSet.Text + "'";
                stdds = fn.getData(stdquery);
                dataGridView2.DataSource = stdds.Tables[0];
                
            }
            else
            {
                stdquery = "select id,qSet,qNo,question,answer from structuralquestion ";
                stdds = fn.getData(stdquery);
                dataGridView2.DataSource = stdds.Tables[0];
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                    stid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                 
            }
            catch { }
        }

        private void btnstructDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int rowindex = dataGridView2.SelectedCells[0].RowIndex;
                    string id = (dataGridView2.Rows[rowindex].Cells["id"].Value).ToString();
                    query = "delete from structuralquestion where id  = '" + id + "'";
                    fn.setData(query, "Deletion Successful");
                    dataGridView2.DataSource = null;
                    UC_ViewDeleteQuetsion_Load(this, null);
                }

            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_ViewDeleteQuetsion_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int rowindex = dataGridView1.SelectedCells[0].RowIndex;
                    string id = (dataGridView1.Rows[rowindex].Cells["id"].Value).ToString();
                    query = "delete from questions where id  = '" + id + "'";
                    fn.setData(query, "Deletion Successful");
                    dataGridView1.DataSource = null;
                    UC_ViewDeleteQuetsion_Load(this, null);
                }

            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            if (comboSet.SelectedIndex != 0)
            {
                query = "select id,qNo,question,optionA,optionB,optionC,optionD,ans from questions where qset = '" + comboSet.Text + "'";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
               
            }
            else
            {
                query = "select id,qset,qNo,question,optionA,optionB,optionC,optionD,ans from questions ";
                ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
                
            }
        }

        private void comboselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboselect.SelectedIndex == 0)
            {
                MCQpanel.Visible = true;
                Structuralpanel.Visible = false;
                comboSet.Items.Clear();
                comboSet.Items.Add("All Questions");
                query = "select distinct qset from questions";
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
                combostructSet.Items.Add("All Questions");
                query = "select distinct qSet from structuralquestion";
                ds = fn.getData(query);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    combostructSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
            }
        }

        public UC_ViewDeleteQuetsion()
        {
            InitializeComponent();
        }

        private void UC_ViewDeleteQuetsion_Load(object sender, EventArgs e)
        {
            MCQpanel.Visible = false;
            Structuralpanel.Visible = false;
        }
    }
}
