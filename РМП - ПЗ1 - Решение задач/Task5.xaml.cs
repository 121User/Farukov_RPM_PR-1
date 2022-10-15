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
using System.Data;

namespace РМП___ПЗ1___Решение_задач
{
	/// <summary>
	/// Логика взаимодействия для Task5.xaml
	/// </summary>
	public partial class Task5 : Window
	{
		public Task5()
		{
			InitializeComponent();
		}

		private void btn_Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		//Создание таблицы из элементов массива
		public static class ArrExtension
		{
			public static DataTable ToDataTable(int[,] array)
			{
				var res = new DataTable();

				for (int j = 0; j < array.GetLength(1); j++)
				{
					res.Columns.Add("col" + j);	
				}

				for (int i = 0; i < array.GetLength(0); i++)
				{
					var row = res.NewRow();

					for (int j = 0; j < array.GetLength(1); j++)
					{
						row[j] = array[i, j];
					}

					res.Rows.Add(row);
				}

				return res;
			}
		}

		// Преобразование одномерного массива в двумерный
		public static int[,] OneToTwo(int[] arr, int N, int M)
		{
			int[,] array = new int[N, M];
			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < M; j++)
				{
					array[i, j] = arr[j + i * M];
				}
			}
			return array;
		}

		private void btn_Start_Click(object sender, RoutedEventArgs e)
		{

			// Создание двумерного массива
			int N = 0, M = 0;
			if (int.TryParse(tb_Row.Text, out  N) && int.TryParse(tb_Column.Text, out M) && N != 0 && M != 0)
			{
				tb_Result.Text = null;

				int[,] mas = new int[N, M];
				Random rnd = new Random();

				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < M; j++)
					{
						mas[i, j] = rnd.Next(-10, 10);
					}
				}
				// Создание таблицы
				dataGrid_Mas.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;

				// Сортировка массива
				int[] m = new int[N * M];
				for (int i = 0; i < N; i++)
				{
					for (int j = 0; j < M; j++)
					{
						m[j + i * M] = mas[i, j];
					}
				}

				// По возрастанию
				for (int i = 0; i < N*M; i++)
				{
					for (int j = i + 1; j < N*M; j++)
					{
						int n;
						if (m[i] > m[j])
						{
							n = m[i];
							m[i] = m[j];
							m[j] = n;
						}
					}
				}
				mas = OneToTwo(m, N, M);
				dataGrid_Upper.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;

				// По убыванию
				for (int i = 0; i < N*M; i++)
				{
					for (int j = i + 1; j < N*M; j++)
					{
						int n;
						if (m[i] < m[j])
						{
							n = m[i];
							m[i] = m[j];
							m[j] = n;
						}
					}
				}
				mas = OneToTwo(m, N, M);
				dataGrid_Lower.ItemsSource = ArrExtension.ToDataTable(mas).DefaultView;
				
				// Поиск максимального и минимального значений
				int max = m[0];
				int min = m[0];
				for (int i = 1; i < N*M; i++)
				{
					if (max < m[i]) max = m[i];
					if (min > m[i]) min = m[i];
				}
				tb_Max.Text = max.ToString();
				tb_Min.Text = min.ToString();
			}
			else
			{
				tb_Result.Text = "Введите числа (N и M не могут быть 0)!";
				tb_Max.Text = null;
				tb_Min.Text = null;
				dataGrid_Mas.ItemsSource = null;
				dataGrid_Upper.ItemsSource = null;
				dataGrid_Lower.ItemsSource = null;
			}
		}
	}
}
