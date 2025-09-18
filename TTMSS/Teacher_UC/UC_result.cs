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
    public partial class UC_result : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_result_Load(this,null);
        }

        public UC_result()
        {
            InitializeComponent();
        }

        private void UC_result_Load(object sender, EventArgs e)
        {
            query = "select matricule,name,mcqmark,structmark from result";
            ds = fn.getData(query);
            dataGridView.DataSource = ds.Tables[0];
        }

        
    }
}
