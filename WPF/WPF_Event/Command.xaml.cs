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
    /// Command.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Command : Page
    {
        public Command()
        {
            InitializeComponent();
        }

        private void cmdBind_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Console.WriteLine("Can Execute");
            // e.CanExecute = false;

        }

        private void cmdBind_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Executed");
        }
    }
}
