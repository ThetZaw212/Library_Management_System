using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace LMS.Class
{
    internal class clsMainDB
    {
        public SqlConnection con;
        DataSet DS = new DataSet();

        public void DatabaseConn()
        {
            try
            {
                con = new SqlConnection(LMS.Properties.Settings.Default.LMSCon);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();

                }
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error In DataBase Connection.");
            }
        }
        public DataTable SelectData(string SPString)
        {
            DataTable dt = new DataTable();
            try
            {
                DatabaseConn();
                SqlDataAdapter Adtp = new SqlDataAdapter(SPString, con);
                Adtp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In SelectData.");
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        public void TextBoxData(ref TextBox txtTextBox, string SPString, string FieldName)
        {
            DataTable DT = new DataTable();
            AutoCompleteStringCollection Source = new AutoCompleteStringCollection();

            try
            {
                DatabaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                if (DT.Rows.Count > 0)
                {
                    txtTextBox.AutoCompleteCustomSource.Clear();
                    for (int i = 0; i < DT.Rows.Count; i++)
                    {
                        Source.Add(DT.Rows[i][FieldName].ToString());
                    }
                    txtTextBox.AutoCompleteCustomSource = Source;
                    txtTextBox.Text = "";
                    txtTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In TextBoxData");
            }
            finally
            {
                con.Close();
            }

        }
        public void AddCombo(ref ComboBox cboCombo, string SPString, string Display, string Value)
        {
            DataTable DT = new DataTable();
            DataTable DTCombo = new DataTable();
            DataRow Dr;

            DTCombo.Columns.Add(Display);
            DTCombo.Columns.Add(Value);

            Dr = DTCombo.NewRow();
            Dr[Display] = "-------Select-------";
            Dr[Value] = 0;
            DTCombo.Rows.Add(Dr);

            try
            {
                DatabaseConn();
                SqlDataAdapter Adpt = new SqlDataAdapter(SPString, con);
                Adpt.Fill(DT);
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    Dr = DTCombo.NewRow();
                    Dr[Display] = DT.Rows[i][Display];
                    Dr[Value] = DT.Rows[i][Value];
                    DTCombo.Rows.Add(Dr);
                }
                cboCombo.DisplayMember = Display;
                cboCombo.ValueMember = Value;
                cboCombo.DataSource = DTCombo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error In AddCombo");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
