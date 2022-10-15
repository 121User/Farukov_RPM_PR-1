using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Globalization;

namespace РМП___ПЗ1___Решение_задач
{
    /// <summary>
    /// Логика взаимодействия для Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            string str = tb_Input.Text;

            int rus = Regex.Matches(str, @"[абвгдеёжзийклмнопрстуфхцчшщьыъэюя]", RegexOptions.IgnoreCase).Count;
            if (rus != 0)
            {
                TextInfo upp = new CultureInfo("ru-RU", false).TextInfo;
                string result = upp.ToTitleCase(str);
                tb_Result.Text = result;
            }
            else
            {
                tb_Result.Text = "Введите строку на руссском языке!";
            }
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
