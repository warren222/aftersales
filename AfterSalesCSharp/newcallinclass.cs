using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MetroFramework;
using System.Windows.Forms;
using System.Data;

namespace AfterSalesCSharp
{
    class newcallinclass
    {
     
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand sqlcmd = new SqlCommand();

        Form1 frm1;
        public newcallinclass(Form1 frm1val)
        {
            frm1 = frm1val;
        }
        //ADD NEW RECORD INTO CALLIN TABLE
        public void addcallin(string calldate , string project ,
                        string address , string recipient ,
                        string contact , string email ,
                        string foil , string screen ,
                        string windows , string doors ,
                        string others , string datevisited ,
                        string assignedpersonnel )
        {
            try
            {
                string query = "Declare @autonum as integer = (select max(autonum)+1 from callintb)" +
                   "insert into callintb" +
                   "(AUTONUM," +
                   "CDATE," +
                   "CIN," +
                   "PROJECT," +
                   "ADDRESS," +
                   "RECIPIENT," +
                   "CONTACT," +
                   "EMAIL," +
                   "FOIL," +
                   "SCREEN," +
                   "WINDOWS," +
                   "DOORS," +
                   "OTHER," +
                   "DATEVISITED," +
                   "ASSIGNEDPERSONNEL)" +
                   "values" +
                   "(@autonum, " +
                   "'" + calldate + "' , " +
                   "((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5)))," +
                   "'" + project + "' , " +
                   "'" + address + "' , " +
                   "'" + recipient + "' , " +
                   "'" + contact + "' , " +
                   "'" + email + "' , " +
                   "'" + foil + "' , " +
                   "'" + screen + "' , " +
                   "'" + windows + "' , " +
                   "'" + doors + "' , " +
                   "'" + others + "' , " +
                   "'" + datevisited + "' , " +
                   "'" + assignedpersonnel + "') "+
                   "INSERT INTO QATB (CIN,AID) SELECT ((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5))),AID FROM ANSWERTB WHERE CHK=1 " +
                   "UPDATE ANSWERTB SET CHK=0";
                using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
                {
                    sqlcon.Open();
                    using (SqlCommand sqlcmd = new SqlCommand(query, sqlcon))
                    {
                        sqlcmd.ExecuteNonQuery();
                        MetroMessageBox.Show(Form1.ActiveForm, "Data Added Successfully", "SQL Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void updatecallin(string tempcin , string calldate , string project ,
                       string address , string recipient ,
                       string contact , string email ,
                       string foil , string screen ,
                       string windows , string doors ,
                       string others , string datevisited ,
                       string assignedpersonnel )
        {
            try
            {          
                string query = "update callintb set "+
                                "CDATE = '" + calldate + "', "+
                                "PROJECT = '" + project + "', "+
                                "ADDRESS = '" + address + "', "+
                                "RECIPIENT = '" + recipient + "', "+
                                "CONTACT = '" + contact + "', "+
                                "EMAIL = '" + email + "', "+
                                "FOIL = '" + foil + "', "+
                                "SCREEN = '" + screen + "', "+
                                "WINDOWS = '" + windows + "', "+
                                "DOORS = '" + doors + "', "+
                                "OTHER = '" + others + "', "+
                                "DATEVISITED = '" + datevisited + "', "+
                                "ASSIGNEDPERSONNEL = '" + assignedpersonnel + "' "+
                                "where cin = '" + tempcin + "'";
                using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
                {
                    sqlcon.Open();
                    using (SqlCommand sqlcmd = new SqlCommand(query,sqlcon))
                    {
                        sqlcmd.ExecuteNonQuery();
                        MetroMessageBox.Show(Form1.ActiveForm, "Data Updated Successfully", "SQL Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
            catch (SqlException e)
            {
                MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }
        public void deletecallin(string cin)
        {
                string str = "delete from callintb where cin = '" + cin + "'";
                using (SqlConnection sqlcon = new SqlConnection(sql.sqlconstr))
                {        
                    using (SqlCommand sqlcmd = new SqlCommand(str, sqlcon))
                    {
                        try
                        {
                            sqlcon.Open();
                            sqlcmd.ExecuteNonQuery();
                        }
                        catch (SqlException e)
                        {
                        MetroMessageBox.Show(Form1.ActiveForm, "" + e.Message + "", "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }     
                CallinTableClass b = new CallinTableClass(frm1);
                b.loadcallintb();
            }
         
        }
    }

