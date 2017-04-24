using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Szymon_Pruszek_Labolatorium3
{
    public partial class FormMain : Form
    {
        private static SqlConnection sqlConnection;
        public FormMain()
        {
            InitializeComponent();
            sqlConnection=new SqlConnection("Data source=DESKTOP-0LAPMIA; database=COMPANY; Trusted_Connection=yes");
            //Uupełniam ComboBoxy
            comboBoxTables.Items.Add("Województwa");
            comboBoxTables.Items.Add("Powiaty");
            comboBoxTables.Items.Add("Osoby");
            comboBoxTables.Items.Add("Zatrudnienie");
            comboBoxTables.Items.Add("Działy");
            comboBoxTables.Items.Add("Stanowiska");

            comboBoxEducation.Items.Add("średnie");
            comboBoxEducation.Items.Add("wyższe");
            comboBoxEducation.Items.Add("podstawowe");
            comboBoxEducation.Items.Add("zasadnicze");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ComboBoxText();
        }

        private void buttonAddPersonEdit_Click(object sender, EventArgs e)
        {
            //pictureBoxMonster.Visible - znika obrazek potwora, który był na poczatku.
            //Teraz wyświetlimy w tym miejscu baze danych
            pictureBoxMonster.Visible = false;
            int age = 0;
            Int32.TryParse(textBoxAge.Text, out age);
            if (textBoxID.Text == "")
            {
                Person.AddPerson(sqlConnection, dataGridView, textBoxName.Text, textBoxSurname.Text
                    , age, comboBoxEducation.Text);
            }
            else
            {
                int id = 0;
                Int32.TryParse(textBoxID.Text, out id);
                Person.UpdatePerson(sqlConnection, dataGridView, id, textBoxName.Text, textBoxSurname.Text
                    , age, comboBoxEducation.Text);
            }
        }
        /// <summary>
        /// W zależnosci od wyboru w ComboBoxie, dana tabela się wyświetli
        /// </summary>
        public void ComboBoxText()
        {
            String command = "";
            if (comboBoxTables.Text == "") MessageBox.Show("Najpierw wybierz tabelę!");
            else
            {
                pictureBoxMonster.Visible = false;
                if (comboBoxTables.Text == "Województwa")
                    command = "SELECT Name As Województwo, Capital As Stolica FROM Voivodeship";
                if (comboBoxTables.Text == "Powiaty")
                    command = @"SELECT County.ID, County.Name as Powiat, County.Capital as 'Stolica Powiatu',
                    Voivodeship.Name as 'Województwo', Voivodeship.Capital as 'Stolica Województwa'
                    FROM County JOIN Voivodeship ON County.VoivodeshipID=Voivodeship.ID";
                if (comboBoxTables.Text == "Osoby") command = @"SELECT ID, Name As Imię,Surname As Nazwisko,
                    Age as Wiek, Education As Wykształcenie FROM Person";
                if (comboBoxTables.Text == "Zatrudnienie")
                    command = @"SELECT Person.Name As Imie, Person.Surname As Nazwisko, Department.Name As Dział,
                            Position.Name As Stanowisko, Employment.Salary As Pensja,
                            Employment.Date_of_employment As 'Data zatrudnienia',
                            Employment.Date_of_release as 'Data zwolnienia' FROM Employment
                            JOIN Person ON Person.ID=Employment.PersonID
                            JOIN Department ON Department.ID=Employment.DepartmentID
                            JOIN Position ON Position.ID=Employment.PositionID";
                if (comboBoxTables.Text == "Działy") command = "SELECT Name as Dział FROM Department";
                if (comboBoxTables.Text == "Stanowiska") command = "SELECT Name As Stanowisko FROM Position";
                ShowTable(command);
            }
        }

        public void ShowTable(string com)
        {
                pictureBoxMonster.Visible = false;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(com, sqlConnection);
                FillDataGridView(sqlDataAdapter, dataGridView);
        }

        public static void FillDataGridView(SqlDataAdapter sqlDataAdapter, DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }

        private void buttonDeletePerson_Click(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            int id = 0;
            Int32.TryParse(textBoxIDtoDelete.Text, out id);
            Person.DeletePerson(sqlConnection, dataGridView, id);

        }
        // Komenda wywołuje się po każdej zmianie w textBoxie. Jest to wyszukiwanie dynamiczne
        private void textBoxSerchName_TextChanged(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            Person.SearchByName(sqlConnection,dataGridView,textBoxSerchName.Text);
        }

        private void buttonSortByEmployment_Click(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            Employment.ShowEmployment(sqlConnection,dataGridView);
            //Sortowanie odbędzie się względem 5 kolumny (po dacie zatrudnienia)
            dataGridView.Sort(dataGridView.Columns[5], ListSortDirection.Ascending);
        }

        private void buttonShowCounty_Click(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            int number = 0;
            Int32.TryParse(textBoxAmountofCounty.Text, out number);
            County.ShowCounty(sqlConnection,dataGridView,number);

        }

        private void buttonShowAvarageAge_Click(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            Person.getAvarageofAge(sqlConnection, dataGridView);
        }

        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            pictureBoxMonster.Visible = false;
            int money = 0;
            Int32.TryParse(textBoxAddMoney.Text, out money);
            Employment.AddSomeMoney(sqlConnection,dataGridView,money);
        }
    }
}
