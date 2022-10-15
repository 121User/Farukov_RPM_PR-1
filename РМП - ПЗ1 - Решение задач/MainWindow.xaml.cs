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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace РМП___ПЗ1___Решение_задач
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Task1_Click_1(object sender, RoutedEventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void btn_Task2_Click(object sender, RoutedEventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void btn_Task3_Click(object sender, RoutedEventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }

        private void btn_Task4_Click(object sender, RoutedEventArgs e)
        {
            Task4 task4 = new Task4();
            task4.Show();
        }

        private void btn_Task5_Click(object sender, RoutedEventArgs e)
        {
            Task5 task5 = new Task5();
            task5.Show();
        }
    }
}
