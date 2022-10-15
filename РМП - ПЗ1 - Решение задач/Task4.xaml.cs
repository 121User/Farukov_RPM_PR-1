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
	/// Логика взаимодействия для Task4.xaml
	/// </summary>
	public partial class Task4 : Window
	{
		public Task4()
		{
			InitializeComponent();
		}

		private void btn_Start_Click(object sender, RoutedEventArgs e)
		{
			tb_Result.Text = "";
			// Ввод элементов массива
			string str = tb_Input.Text;
			string[] masS = str.Split();
			int[] masN = new int[masS.Length];
			bool realize = true;
			for(int i = 0; i < masS.Length; i++)
            {
				if (int.TryParse(masS[i], out masN[i])) continue; // Проверка значений
				else
				{
					realize = false;
					break;
				}
            }

			if (realize)
            {
				// Сортировка массива по возрастанию
				for(int i = 0; i < masN.Length; i++)
                {
					for(int j = i+ 1; j < masN.Length; j++)
                    {
						int n;
                        if (masN[i] > masN[j])
                        {
							n = masN[i];
                            masN[i] = masN[j];
                            masN[j] = n;
                        }
                    }
                }

				for (int i = 0; i < masN.Length; i++)
				{
					tb_Result.Text = tb_Result.Text + masN[i] + " ";
				}
				// Разбиение маассива на две части
				for (int i = 0; i < masN.Length/2; i = i+2)
                {
					int n = masN[i];
					masN[i] = masN[masN.Length - 1 - i];
					masN[masN.Length - 1 - i] = n;
                }
				// Формирование сумм двух частей
				int sum1 = 0;
				int sum2 = 0;
				for(int i = 0; i < masN.Length; i++)
                {
					if (i < masN.Length / 2)
                    {
						sum1 += masN[i];
                    }
                    else
                    {
						sum2 += masN[i];
					}
                }
				// Проверка условия
				double difference = 0;
				if (sum1 > sum2)
                {
					difference = sum1 / sum2;
                }
                else
                {
					difference = sum2 / sum1;
                }

				// Вывод результата
				if (difference < 1.5)
                {
					tb_Result.Text = tb_Result.Text + "\r\n" + "Часть 1: ";
					for (int i = 0; i < masN.Length / 2; i++)
					{
						tb_Result.Text = tb_Result.Text + masN[i] + " ";
					}
					tb_Result.Text = tb_Result.Text + "\r\n" + "Часть 2: ";
					for (int i = masN.Length / 2; i < masN.Length; i++)
					{
						tb_Result.Text = tb_Result.Text + masN[i] + " ";
					}

					tb_Result.Text = tb_Result.Text + "\r\n" + "Сумма 1: " + sum1 + " ";
					tb_Result.Text = tb_Result.Text + "Сумма 2: " + sum2;
				}
				else
                {
					tb_Result.Text = tb_Result.Text + "\r\n" + "Нельзя разделить на две части, суммы которых отличались бы не более чем в 1,5 раз";
				}
			}
			else
            {
				tb_Result.Text = "Элементами массива должны быть целые числа!";
			}
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
