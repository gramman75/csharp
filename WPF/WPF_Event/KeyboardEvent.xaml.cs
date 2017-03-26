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
    /// KeyboardEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class KeyboardEvent : Page
    {
        public KeyboardEvent()
        {
            InitializeComponent();
            this.MouseDown += new MouseButtonEventHandler(Grid_MouseLeftButtonDown);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Alt && (e.Key == Key.A || e.SystemKey == Key.A)){
                Console.WriteLine(e.SystemKey.ToString());                
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("a");
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Button");
        }
    }
}
