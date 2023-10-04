using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}