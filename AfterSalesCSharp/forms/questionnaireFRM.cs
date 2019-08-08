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
    public partial class questionnaireFRM : MetroFramework.Forms.MetroForm
    {
        Form1 frm;
        string qid;
        string aid;
        string constr  = sql.sqlconstr;
        public questionnaireFRM(Form1 f)
        {
            frm = f;
            InitializeComponent();
        }
        private void loadquestionnaire()
        {
            BindingSource bs = new BindingSource();
            DataSet ds = new DataSet();
            ds.Clear();
            string str = "select * from questionnairetb order by item asc";
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "questionnairetb");
                            bs.DataSource = ds;
                            bs.DataMember = "questionnairetb";
                            questionGRID.DataSource = bs;           
                            setcolumns(questionGRID);     
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void setcolumns(DataGridView dg)
        {
            dg.Columns["qid"].Visible = false;
            dg.Columns["item"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dg.Columns["question"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void updateBTN_Click(object sender, EventArgs e)
        {
            loadquestionnaire();
        }

        private void questionnaireFRM_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, (Screen.PrimaryScreen.Bounds.Height-38) - this.Height);
            loadquestionnaire();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"delete record?","Continue...",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string str ="delete from questionnairetb where qid = @id";

            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcmd.Parameters.AddWithValue("@id",qid);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            refreshBTN.PerformClick();
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            if (sql.IsNumeric(itemTXT.Text) == false)
            {
                return;
            }
            string str = "declare @id as integer = (select isnull(max(qid)+1,0) from questionnairetb) "+
                         "insert into questionnairetb (qid,item,question) values (@id,@item,@question)";

            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcmd.Parameters.AddWithValue("@item", itemTXT.Text);
                        sqlcmd.Parameters.AddWithValue("@question", questionTXT.Text);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            refreshBTN.PerformClick();
        }
        private void addquestionnaire()
        {
            string str = "";
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }     
                }
            }
        }

        private void questionGRID_SelectionChanged(object sender, EventArgs e)
        {
           DataGridViewSelectedRowCollection selecteditems = questionGRID.SelectedRows;
           foreach(DataGridViewRow rows in selecteditems)
            {
                qid = rows.Cells["qid"].Value.ToString();
                itemTXT.Text = rows.Cells["item"].Value.ToString();
                questionTXT.Text = rows.Cells["question"].Value.ToString();
                question.Text= rows.Cells["question"].Value.ToString();
            }
        }

        private void updateBTN_Click_1(object sender, EventArgs e)
        {
            if (sql.IsNumeric(itemTXT.Text) == false)
            {
                return;
            }
            string str = "update questionnairetb set item = @item , question = @question where qid = @id";
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcmd.Parameters.AddWithValue("@item",itemTXT.Text);
                        sqlcmd.Parameters.AddWithValue("@question", questionTXT.Text);
                        sqlcmd.Parameters.AddWithValue("@id", qid);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }          
                }
            }
            refreshBTN.PerformClick();
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            loadanswer();
        }
        private void loadanswer()
        {
            string str = "select * from answertb where qid = @qid";
            DataSet ds = new DataSet();
            ds.Clear();
            BindingSource bs = new BindingSource();

            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.Parameters.AddWithValue("@qid", qid);
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "answertb");
                            bs.DataSource = ds;
                            bs.DataMember = "answertb";
                            answerGRID.DataSource = bs;
                            answerGRID.Columns["aid"].Visible = false;
                            answerGRID.Columns["qid"].Visible = false;
                            answerGRID.Columns["chk"].Visible = false;
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void metroTextButton1_Click_1(object sender, EventArgs e)
        {
            if (sql.IsNumeric(aitemTXT.Text) == false)
            {
                return;
            }
            string str = "declare @id as integer = (select isnull(max(aid)+1,0) from answertb) insert into answertb (aid,qid,item,answer) values (@id,@qid,@item,@answer)";
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                 try
                    {
                        sqlcon.Open();
                        sqlcmd.Parameters.AddWithValue("@qid", qid);
                        sqlcmd.Parameters.AddWithValue("@item", aitemTXT.Text);
                        sqlcmd.Parameters.AddWithValue("@answer", answerTXT.Text);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            metroTextButton2.PerformClick();
        }

        private void answerGRID_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selecteditems = answerGRID.SelectedRows;
            foreach(DataGridViewRow rows in selecteditems)
            {
                aid = rows.Cells["aid"].Value.ToString();
                aitemTXT.Text = rows.Cells["item"].Value.ToString();
                answerTXT.Text = rows.Cells["answer"].Value.ToString();
            }
        }

        private void metroTextButton3_Click_1(object sender, EventArgs e)
        {
            if (sql.IsNumeric(aitemTXT.Text) == false)
            {
                return;
            }
            string str = "update answertb set qid=@qid,item=@item,answer=@answer where aid = @id";
            using (SqlConnection sqlcon = new SqlConnection(constr))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        sqlcmd.Parameters.AddWithValue("@id", aid);
                        sqlcmd.Parameters.AddWithValue("@qid", qid);
                        sqlcmd.Parameters.AddWithValue("@item", aitemTXT.Text);
                        sqlcmd.Parameters.AddWithValue("@answer", answerTXT.Text);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "" + ex.ToString() + "", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            metroTextButton2.PerformClick();
        }

        private void questionGRID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            loadanswer();
            metroTabControl1.SelectedIndex = 1;
        }

        private void questionnaireFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.loadquestionnaire();
            frm.storeqa();
            frm.loadasnwer();
        }

        private void metroTextButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
