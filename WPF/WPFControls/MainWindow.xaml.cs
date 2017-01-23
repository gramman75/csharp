using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFControls
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            labValue.Content = Convert.ToInt32(labValue.Content) + 1;

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            labValue.Content = Convert.ToInt32(labValue.Content) - 1;
        }
    }
}
