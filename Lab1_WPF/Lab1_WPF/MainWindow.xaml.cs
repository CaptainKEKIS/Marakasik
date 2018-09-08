﻿using System;
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

namespace Lab1_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //берем значение из текстбокса и конвертируем его в число:
            int year = Convert.ToInt32( textBox1.Text );
            //вызываем функцию для проверки:
	        bool result = DateFunctions.IsLeapYear( year );
	        //показываем сообщение пользователю:
	        MessageBox.Show( result ? "Високосный" : "Не високосный"); 

        }
    }
}
