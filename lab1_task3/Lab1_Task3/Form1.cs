using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_p5_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Ukrainets"))
                {
                    Object o = key.GetValue("P5");
                    string[] valuesstring = o as string[];
                    string output = String.Join("\n", valuesstring);
                    MessageBox.Show(output);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_p6_Click(object sender, System.EventArgs e)
        {
            try
            {
                RegistryKey key;
                key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Ukrainets", true);
                string[] write_str = {"Я - кмітливий студент", "кафедри", "комп'ютерної", "інженерії!"};
                key.SetValue("P6", write_str, RegistryValueKind.MultiString);
                key.Close();
                MessageBox.Show("успішно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
