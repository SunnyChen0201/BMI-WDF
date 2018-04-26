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

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = "";
            HeightBox.Background = Brushes.HotPink;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double h = double.Parse(HeightBox.Text)/100;
            double kg = double.Parse(kgbox.Text);
            double bmi = h / (kg * kg);

            
            Ans.Text = bmi.ToString();
        }

        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void HeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeightBox.Text = HeightBar.Value.ToString();

            double h = double.Parse(HeightBox.Text) / 100;
            double kg = double.Parse(kgbox.Text);
            double bmi =kg / (h * h);


            Ans.Text = bmi.ToString();
        }

        private void kgBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            kgbox.Text = kgBar.Value.ToString();

            double h = double.Parse(HeightBox.Text) / 100;
            double kg = double.Parse(kgbox.Text);
            double bmi = kg / (h * h)  ;


            Ans.Text = bmi.ToString();

        }
    }
}
