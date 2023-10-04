using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Напишіть Windows-програму (проект C#/Windows Forms Application) з двома кнопками. Перша
//кнопка повинна виводити зміст всіх рядків параметра P5 за допомогою, наприклад,
//MessageBox.Show(“……”), незалежно від кількості рядків.
//Друга кнопка створює в гілці реєстра
// HKLM/Software/<ВАШЕ ПРІЗВИЩЕ ЛАТИНИЦЕЮ>,
// створює новий параметр P6 типу MultiString і записує в цей параметр два рядки:
//"Я - студент/студентка
//кафедрі
//комп’ютерної
//інженерії!"


namespace Lab1_Task3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
