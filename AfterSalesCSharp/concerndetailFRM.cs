using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AfterSalesCSharp
{
    public partial class concerndetailFRM : MetroFramework.Forms.MetroForm
    {
        public concerndetailFRM()
        {
            InitializeComponent();
        }

        private void concerndetailFRM_Load(object sender, EventArgs e)
        {

        }
        public void loadquestion(string cin)
        {
            string str = "SELECT DISTINCT A.CIN,B.QID,C.QUESTION FROM QATB AS A INNER JOIN ANSWERTB AS B ON A.AID=B.AID"+ 
                " INNER JOIN QUESTIONNAIRETB AS C ON B.QID = C.QID"+
                " WHERE A.CIN = @cin";
            DataSet ds = new DataSet();
            ds.Clear();
            BindingSource bs = new BindingSource();
            using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.Parameters.AddWithValue("@cin",cin);
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "QATB");
                            bs.DataSource = ds;
                            bs.DataMember = "QATB";
                            questionGRID.DataSource = bs;
                            questionGRID.Columns["QID"].Visible = false;
                            questionGRID.Columns["cin"].Visible = false;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }

        private void questionGRID_SelectionChanged(object sender, EventArgs e)
        {
            string cin = "";
            string qid = "";
            DataGridViewSelectedRowCollection selecteditems = questionGRID.SelectedRows;
            foreach(DataGridViewRow row in selecteditems)
            {
                cin = row.Cells["cin"].Value.ToString();
                qid = row.Cells["qid"].Value.ToString();
            } 




            string str = "select b.answer from qatb as a inner join answertb as b on a.aid=b.aid where a.cin = @cin and b.qid = @qid";
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            ds.Clear();
            using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.Parameters.AddWithValue("@cin",cin);
                            sqlcmd.Parameters.AddWithValue("@qid", qid);
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "qatb");
                            bs.DataSource = ds;
                            bs.DataMember = "qatb";
                            answerGRID.DataSource = bs;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
