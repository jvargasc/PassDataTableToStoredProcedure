
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassDataTableToStoredProcedureCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtCustomer_KeyDown(object sender, KeyEventArgs e)
        {

            if( (e.KeyCode == Keys.Return) && (TxtCustomer.Text.Trim() != "") )
                GetData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void BtnClear_Click(object sender, System.EventArgs e)
        {
            TxtCustomer.Text = "";
            DtgClients.DataSource = null;
        }

        private void GetData()
        {
            DataTable TmpTable = new DataTable();
            DataTable TmpTableRead = new DataTable();
            DataRow TmpRow;

            TmpTable.Columns.Add("CustomerId", typeof(string));
            TmpTable.Columns.Add("CustomerName", typeof(string));

            TmpRow = TmpTable.NewRow();

            TmpRow["CustomerId"] = TxtCustomer.Text.Trim();
            TmpRow["CustomerName"] = "Nombre de Prueba";

            TmpTable.Rows.Add(TmpRow);

            //SqlConnection TmpConnection;
            using (SqlConnection TmpConnection = new SqlConnection(@"Data Source=.\sqlexpress01;Initial Catalog=Northwind;Persist Security Info=True;User ID=dbuser;Password=P4$$w0rd" ))
            {

                TmpConnection.Open();

                SqlCommand TmpSqlCommand = new SqlCommand("dbo.SP_CustomerList", TmpConnection);
                TmpSqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter TmpSqlParameter = TmpSqlCommand.Parameters.AddWithValue("@CustomerList", TmpTable);

                TmpSqlParameter.SqlDbType = SqlDbType.Structured;
                //TmpSqlCommand.ExecuteNonQuery();
                SqlDataAdapter TmpSqlDataAdapter = new SqlDataAdapter();

                TmpSqlDataAdapter.SelectCommand = TmpSqlCommand;
                TmpSqlDataAdapter.Fill(TmpTableRead);

                if (TmpTableRead.Rows.Count > 0)
                    DtgClients.DataSource = TmpTableRead;
               else
                    {
                    MessageBox.Show("Code not found");
                    DtgClients.DataSource = null;
                }

            }

        }

    }
}
