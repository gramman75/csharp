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
    /// AttachedEvent.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AttachedEvent : Page
    {
        public AttachedEvent()
        {
            InitializeComponent();
            WPanel.AddHandler(Button.ClickEvent, new RoutedEventHandler(Panel_Click), true);
            WGrid.AddHandler(Button.ClickEvent, new RoutedEventHandler(Grid_Click));
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Panel");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Grid");
        }

        //void GenericHandler(object sender, RoutedEventArgs e)
        //{
        //    null;
        //}
    }
}
