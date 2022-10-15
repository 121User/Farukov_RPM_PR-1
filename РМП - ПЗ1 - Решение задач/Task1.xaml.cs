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
using System.Numerics;

namespace РМП___ПЗ1___Решение_задач
{
    /// <summary>
    /// Логика взаимодействия для Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

		private void btn_Start_Click(object sender, RoutedEventArgs e)
		{
			string text = tb_Input.Text;
			double num;
			// Проверка числа
			if (double.TryParse(text, out num))
			{
				if (num > 1000)
				{
					tb_Result.Text = "Введите число: N <= 1000!";
				}
				else
				{
					tb_Result.Text = "";
					if (num < 0) num *= (-1);
					// Вывод N^N
					/*
					string powNum = num.ToString();
					powNum = Convert.ToString(Math.Round(Math.Pow(num, num),5)
					*/
					BigInteger p = new BigInteger(num);
					BigInteger powNum = p;
					for (int i = 1; i < num; i++)
                    {
						powNum *= p;
                    }
					tb_Result.Text = tb_Result.Text + "(Число N в степени N: " + powNum + ")\r\n";
					// Подсчет цифр в числе
					int[] mas = new int[10];
					while (powNum != 0)
					{
						int ost = (int)(powNum % 10);
						mas[ost]++;
						powNum /= 10;
					}
					// Вывод результатов
					for (int i = 0; i<10; i++)
                    {
						tb_Result.Text = tb_Result.Text + i + ": " + mas[i] + "\r\n";
					}
				}
			}
			else
			{
				tb_Result.Text = "Введите число!";
			}
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}