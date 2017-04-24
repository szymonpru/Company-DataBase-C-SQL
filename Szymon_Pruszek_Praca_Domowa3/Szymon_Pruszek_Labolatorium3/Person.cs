using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Szymon_Pruszek_Labolatorium3
{
    class Person
    {

        public static void AddPerson(SqlConnection sqlConnection, DataGridView dataGridView, string name, string surname,
            int age, string education)
        {
            try
            {
                sqlConnection.Open();
                string command = $"INSERT INTO Person (Name, Surname, Age, Education, CountyID) values ('{name}','{surname}','{age}','{education}',1)";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowPersons(sqlConnection, dataGridView);
                MessageBox.Show("Dodano prawidłowo!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Błąd!");
                throw;
            }
        }

        public static void UpdatePerson(SqlConnection sqlConnection, DataGridView dataGridView,int id, string name, string surname,
            int age, string education)
        {
            try
            {
                sqlConnection.Open();
                string command = $"UPDATE Person SET Name = '{name}', Surname = '{surname}',Age='{age}',Education='{education}' WHERE ID = '{id}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                ShowPersons(sqlConnection, dataGridView);
                MessageBox.Show("Edytowano prawidłowo!");
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Błąd! Wpisałeś poprawnie wszytskie dane?");
                throw;
            }
        }

        public static void ShowPersons(SqlConnection sqlConnection, DataGridView dataGridView)
        {
            string com= @"SELECT ID, Name As Imię,Surname As Nazwisko,
                    Age as Wiek, Education As Wykształcenie FROM Person";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
            FillDataGridView(sqlDataAdapter,dataGridView);
        }

        public static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        public static void DeletePerson(SqlConnection sqlConnection, DataGridView dataGridView, int id)
        {
            try
            {
                //usuwając tylko z tabeli Person występuje
                //błąd bo od osoby są referencje do tabeli Employment.
                //Próbowałem to rozwiazać używając DELETE CASCADE, ale nie dałem rady.
                //Usuwam najpierw record z Employment, a potem record osoby z Person.
                sqlConnection.Open();
                string command = $"DELETE FROM Employment WHERE PersonID='{id}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();

                command = $"DELETE FROM Person WHERE ID = '{id}'";
                SqlCommand sqlCommand2 = new SqlCommand(command, sqlConnection);
                sqlCommand2.ExecuteNonQuery();
                ShowPersons(sqlConnection, dataGridView);
                MessageBox.Show("Usunięto prawidłowo!");
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Błąd! Wpisałeś poprawnie ID?");
                throw;
            }
        }

        public static void  SearchByName(SqlConnection sqlConnection, DataGridView dataGridView,string name)
        {
            sqlConnection.Open();
            SqlDataAdapter adapt = new SqlDataAdapter($"SELECT ID, Name As Imię,Surname As Nazwisko, Age as Wiek, Education As Wykształcenie FROM Person WHERE Name LIKE '%{name}%' OR Surname LIKE '%{name}%'", sqlConnection);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            sqlConnection.Close();
        }

        public static void getAvarageofAge(SqlConnection sqlConnection,DataGridView dataGridView)
        {
            string com = @"SELECT avg(Age) as 'Średnia wieku' FROM Person";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
            FillDataGridView(sqlDataAdapter,dataGridView);
        }
    }
}
