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

namespace WPFControlEvents
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string mouseActivity = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            mouseActivity += "Clicked the Button\n"; 
            MessageBox.Show(mouseActivity);
            mouseActivity = string.Empty;

        }

        private void outerEllpise_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("Clicked the outer ellipse");
            //this.Title = "Clicked the outer ellipse";
            mouseActivity += "Clicked the outer ellipse\n";
            e.Handled = false;
        }

        private void outerEllpise_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseActivity += "Preview Mousedown\n";
            e.Handled = false;
        }
    }
}
