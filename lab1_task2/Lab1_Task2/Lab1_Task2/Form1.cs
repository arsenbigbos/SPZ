using System.Data.SqlClient;

//На систему Windows встановіть програму SQL Management Studio, приєднайтесь до
//працюючого MSSQL-сервера, що встановлено разом з VisualStudio. Як правило цей сервер має ім`я
//(LocalDB)\v11.0 (замість 11 може бути 12,13,14) або
//(LocalDB)\MSSQLLocalDB або
//HOSTNAME\SQLEXPRESS
//де HOSTNAME — ім`я вузла операційної системи Windows, яке можна дізнатись командою
//hostname
//Створіть нову базу «TestDatabase», вказавши, що файл і журнали бази створюються в підкаталозі
//...\LAB-1\Task-6. В базі створіть нову таблицю MyHomeAnimals з двома полями: ID типу «int» і Name
//типу nvarchar(max). Вручну додайте в таблицю три рядки, два з которих повинні бути українською
//мовою, наприклад:
//ID Name
//1 Морські свинки
//2 Змії і ящірки
//3 Evil Sharks

namespace Lab1_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            string connetion_string = "Data Source=ServerName; Server=(LocalDB)\\MSSQLLocalDB";
            string req = "use TestDatabase; select * from  MyHomeAnimals;";
            SqlConnection myConnection = new SqlConnection(connetion_string);
            myConnection.Open();
            SqlCommand command = new SqlCommand(req, myConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
    }
}