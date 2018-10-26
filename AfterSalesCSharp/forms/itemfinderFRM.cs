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

namespace AfterSalesCSharp.forms
{
 
    public partial class itemfinderFRM : MetroFramework.Forms.MetroForm
    {
        newQUform f;
        public static string pname = "";
        public itemfinderFRM(newQUform frm)
        {
            f = frm;
            InitializeComponent();
        }
        public void loadproject()
        {
            string str = "select distinct project_label from addendum_to_contract_tb";
            DataSet ds = new DataSet();
            ds.Clear();
            using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr2))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "addendum_to_contract_tb");
                            projectname.DataSource = ds.Tables["addendum_to_contract_tb"];
                            projectname.DisplayMember = "project_label";
                            joborder.SelectedIndex = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = projectname.SelectedIndex;
            loadproject();
            if (x > projectname.Items.Count)
            {
                projectname.SelectedIndex = -1;
            }
            else
            {
                projectname.SelectedIndex = x;
            }
        }
        public void loadjo()
        {
            string str = "select distinct parentjono from addendum_to_contract_tb where project_label=@pl";
            DataSet ds = new DataSet();
            ds.Clear();
            using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr2))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.Parameters.AddWithValue("@pl", projectname.Text);
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "addendum_to_contract_tb");
                            joborder.DataSource = ds.Tables["addendum_to_contract_tb"];
                            joborder.DisplayMember = "parentjono";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
        private void joborder_MouseDown(object sender, MouseEventArgs e)
        {
            int x = joborder.SelectedIndex;
            loadjo();
            if (x > joborder.Items.Count)
            {
                joborder.SelectedIndex = -1;
            }
            else
            {
                joborder.SelectedIndex = x;
            }
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            string str = "select a.KMDI_NO,ITEM_NO,WDW_NO,LOCATION,DESCRIPTION,b.fulladd from KMDI_FABRICATION_TB as a inner join ADDENDUM_TO_CONTRACT_TB as b on a.job_order_no = b.JOB_ORDER_NO where b.LOCK=0 and b.PARENTJONO = @jo and a.STATUS=''";
            DataSet ds = new DataSet();
            ds.Clear();
            using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr2))
            {
                using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.Parameters.AddWithValue("@jo", joborder.Text);
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "addendum_to_contract_tb");
                            itemGRID.DataSource = ds.Tables["addendum_to_contract_tb"];
                            itemGRID.Columns["fulladd"].Visible = false;
                            using (SqlDataReader rd = sqlcmd.ExecuteReader())
                            {
                                while (rd.Read())
                                {
                                    address.Text = rd["FULLADD"].ToString();
                                }
                            }                         
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "" + ex.ToString() + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void itemGRID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((itemGRID.Rows.Count >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow row = itemGRID.Rows[e.RowIndex];
                f.kno.Text = row.Cells["kmdi_no"].Value.ToString();
                f.itemno.Text = row.Cells["item_no"].Value.ToString();
                f.wdwloc.Text = row.Cells["wdw_no"].Value.ToString()+" / "+row.Cells["location"].Value.ToString();
            }
        }

        private void itemfinderFRM_Load(object sender, EventArgs e)
        {
            projectname.Text = pname;
            int x = joborder.SelectedIndex;
            loadjo();        
            metroTextButton2.PerformClick();
        }
    }
}
