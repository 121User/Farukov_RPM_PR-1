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

namespace РМП___ПЗ1___Решение_задач
{
	/// <summary>
	/// Логика взаимодействия для Task3.xaml
	/// </summary>
	public partial class Task3 : Window
	{
		public Task3()
		{
			InitializeComponent();
		}

		private void btn_Start_Click(object sender, RoutedEventArgs e)
		{
			int N;
			if (int.TryParse(tb_Input.Text, out N))
			{
				// Создание и заполнение массива
				int[] mas = new int[N];
				Random rnd = new Random();

				for (int i = 0; i < N; i++)
				{
					mas[i] = rnd.Next(10);
				}
				// Вывод массива
				tb_Result.Text = "(Массив: ";
				for (int i = 0; i < N; i++)
				{
					tb_Result.Text = tb_Result.Text + mas[i];
					if(i != N-1) tb_Result.Text = tb_Result.Text + ", ";
				}
				tb_Result.Text = tb_Result.Text + ")\r\n";
				// Создание вспомогательного массива count для подсчета
				int[,] count = new int[2, N]; 

				for(int i = 0; i < N; i++)
				{
					count[0, i] = mas[i];
				}

				// Подсчет повторений
				for (int i = 0; i < N; i++)
				{
					for(int j = 0; j < N; j++)
					{
						if (count[0, i] == mas[j])
						{
							count[1, i]++;
						}
					}
				}

				// Удаление неуникальных чисел из массива count
				for (int i = 0; i < N; i++)
				{
					for (int j = N-1; j > i; j--)
					{
						if (count[0, i] == count[0, j] && count[1, i] == count[1, j])
						{
							count[0, j] = 0;
							count[1, j] = 0;
						}
					}
				}

				// Вывод результатов
				for (int i = 0; i < N; i++)
				{
					if (count[1, i] != 0)
					{
						tb_Result.Text = tb_Result.Text + count[0, i] + ": " + count[1, i] + "\r\n";
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
