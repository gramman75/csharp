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
    /// Direct_EventSetter.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Direct_EventSetter : Page
    {
        public Direct_EventSetter()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Background = new SolidColorBrush(Colors.Red);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            b.Background = new SolidColorBrush(Colors.Yellow);
            e.Handled = true;
        }
    }
}
