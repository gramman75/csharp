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

namespace WPF_Event
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PackmanWindow.MouseDown += new MouseButtonEventHandler(PackmanWindow_MouseLeftButtonDown);
            
        }

        private void PackmanWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            lbxPackman.Items.Add("Window Event");
        }

        private void btnPackman_Click(object sender, RoutedEventArgs e)
        {
            lbxPackman.Items.Add("Button Event");

        }

        private void cvsPackman_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbxPackman.Items.Add("Canvas Event");

        }
    }
}
