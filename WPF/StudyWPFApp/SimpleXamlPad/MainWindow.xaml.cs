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
using System.IO;
using System.Windows.Markup;

namespace SimpleXamlPad
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

        private void Window_Closed(object sender, EventArgs e)
        {
            File.WriteAllText("myxaml.xaml", txtXaml.Text);

        }

        private void btnXamlView_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("myxaml.xaml", txtXaml.Text);
            Window myWindow = null;
            using (Stream stm = File.Open("myxaml.xaml", FileMode.Open))
            {
                myWindow = (Window)XamlReader.Load(stm);
            }

            myWindow.Show();
        }

        private void Window_Loaded(object sender, EventArgs e)
        {
            if (File.Exists(System.Environment.CurrentDirectory + "\\myxaml.xaml"))
            {
                txtXaml.Text = File.ReadAllText("myxaml.xaml");
            } else
            {
                txtXaml.Text =
                    "<Window xmlns=\"http://schemas.microsoft.com"
                    + "/winfx/2006/xaml/presentation\"\n"
                    + "xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\""
                    + " Height =\"400\" Width =\"500\" WindowStartupLocation=\"CenterScreen\">\n"
                    + "<StackPanel>\n"
                    + "</StackPanel>\n"
                    + "</Window>";
            }
        }
    }
}
