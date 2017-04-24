using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Szymon_Pruszek_Labolatorium3
{
    class County
    {
        public static void ShowCounty(SqlConnection sqlConnection, DataGridView dataGridView,int number)
        {
            string com = "SELECT TOP "+number + @" County.ID, County.Name as Powiat, County.Capital as 'Stolica Powiatu',
                    Voivodeship.Name as 'Województwo', Voivodeship.Capital as 'Stolica Województwa'
                    FROM County JOIN Voivodeship ON County.VoivodeshipID = Voivodeship.ID ORDER BY County.ID";
            Console.WriteLine(com);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
