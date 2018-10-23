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
    public partial class searchresultFRM : MetroFramework.Forms.MetroForm
    {
        Form1 frm;
        public searchresultFRM(Form1 frm1)
        {
            frm = frm1;
            InitializeComponent();
        }

        private void searchresultFRM_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height - 38;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width,0);
        }
        public void loadsearchresult(string query)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
                {
                    sqlcon.Open();
                    DataSet ds = new DataSet();
                    BindingSource bs = new BindingSource();
                    ds.Clear();
                    using (SqlCommand sqlcmd = new SqlCommand(query, sqlcon))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            da.SelectCommand = sqlcmd;
                            da.Fill(ds, "callintb");
                            bs.DataSource = ds;
                            bs.DataMember = "callintb";
                            searchResultGridview.DataSource = null;
                            searchResultGridview.DataSource = bs;
                            manageCALLINGRIDcolumns();
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void manageCALLINGRIDcolumns()
        {
            searchResultGridview.Columns["AUTONUM"].Visible = false;
            searchResultGridview.Columns["AUTONUM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["STATUS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["CIN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["PROJECT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["ADDRESS"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["RECIPIENT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["CONTACT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["EMAIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["FOIL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["Screen"].Width = 100;
            searchResultGridview.Columns["Windows"].Width = 100;
            searchResultGridview.Columns["DOORS"].Width = 100;
            searchResultGridview.Columns["OTHER"].Width = 100;
            searchResultGridview.Columns["DATE VISITED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            searchResultGridview.Columns["ASSIGNED PERSONNEL"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void searchResultGridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm.newcallinPNL.VerticalScroll.Value = 0;
            if ((searchResultGridview.RowCount >= 0) && (e.RowIndex >= 0))
            {
                DataGridViewRow row = searchResultGridview.Rows[e.RowIndex];
                frm.savetotemp();
                frm.calldateTXT.Text = row.Cells[2].Value.ToString();
                Form1.tempcin = row.Cells[3].Value.ToString();
                frm.projectTXT.Text = row.Cells[4].Value.ToString();
                frm.addressTXT.Text = row.Cells[5].Value.ToString();
                frm.recipientTXT.Text = row.Cells[6].Value.ToString();
                frm.contactTXT.Text = row.Cells[7].Value.ToString();
                frm.emailTXT.Text = row.Cells[8].Value.ToString();
                frm.foilTXT.Text = row.Cells[9].Value.ToString();
                frm.screenTXT.Text = row.Cells[10].Value.ToString();
                frm.windowsTXT.Text = row.Cells[11].Value.ToString();
                frm.doorsTXT.Text = row.Cells[12].Value.ToString();
                frm.otherTXT.Text = row.Cells[13].Value.ToString();
                frm.datevisitedTXT.Text = row.Cells[14].Value.ToString();
                frm.assignedpersonnelTXT.Text = row.Cells[15].Value.ToString();
                frm.addBTN.Text = "Reentry";
                frm.updateBTN.Visible = true;
                frm.cancelBTN.Visible = true;
                frm.deleteBTN.Visible = true;
                Color x = Color.Red;
                txtforecolor(x);
            }
        }
        public void txtforecolor(Color x)
        {
            frm.calldateTXT.ForeColor = x;
            frm.projectTXT.ForeColor = x;
            frm.addressTXT.ForeColor = x;
            frm.recipientTXT.ForeColor = x;
            frm.contactTXT.ForeColor = x;
            frm.emailTXT.ForeColor = x;
            frm.foilTXT.ForeColor = x;
            frm.screenTXT.ForeColor = x;
            frm.windowsTXT.ForeColor = x;
            frm.doorsTXT.ForeColor = x;
            frm.otherTXT.ForeColor = x;
            frm.datevisitedTXT.ForeColor = x;
            frm.assignedpersonnelTXT.ForeColor = x;
        }

        private void searchResultGridview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {   
            autorow(sender, e);
        }
        public void autorow(Object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void searchResultGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }
    }
}
