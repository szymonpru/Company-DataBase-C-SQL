using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Szymon_Pruszek_Labolatorium3
{
    class Employment
    {
        public static void ShowEmployment(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            string com = @"SELECT Person.Name As Imie, Person.Surname As Nazwisko, Department.Name As Dział,
                            Position.Name As Stanowisko, Employment.Salary As Pensja,
                            Employment.Date_of_employment As 'Data zatrudnienia',
                            Employment.Date_of_release as 'Data zwolnienia' FROM Employment
                            JOIN Person ON Person.ID=Employment.PersonID
                            JOIN Department ON Department.ID=Employment.DepartmentID
                            JOIN Position ON Position.ID=Employment.PositionID";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
            FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void AddSomeMoney(SqlConnection sqlConnection, DataGridView dataGridView, int money)
        {
            try
            {
                sqlConnection.Open();
                string command = $"UPDATE Employment SET Salary = Salary + '{money}'";
                Console.WriteLine(command);
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowEmployment(sqlConnection, dataGridView);
                MessageBox.Show("Podwyżka się udała!");
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Błąd!");
                throw;
            }
        }
    }
}
