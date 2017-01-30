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

namespace WPF_Chapter4
{
    /// <summary>
    /// VSStyleWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VSStyleWindow : Window
    {
        public VSStyleWindow()
        {
            InitializeComponent();
        }

        private void pane1Button_Click(object sender, RoutedEventArgs e)
        {
            layer1.Visibility = Visibility.Visible;
            Grid.SetZIndex(layer1, 1);
        }
    }
}
