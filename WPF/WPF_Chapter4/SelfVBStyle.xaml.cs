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
    /// SelfVBStyle.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SelfVBStyle : Window
    {
        ColumnDefinition column1ForLayer0;
        ColumnDefinition column2ForLayer0;
        ColumnDefinition column2ForLayer1;

        public SelfVBStyle()
        {
            InitializeComponent();
            column1ForLayer0 = new ColumnDefinition();
            column1ForLayer0.SharedSizeGroup = "column1";

            column2ForLayer0 = new ColumnDefinition();
            column2ForLayer0.SharedSizeGroup = "column2";

            column2ForLayer1 = new ColumnDefinition();
            column2ForLayer1.SharedSizeGroup = "column2";
        }

        private void Dock(int layerNum)
        {
            if (layerNum == 1)
            {
                btnAlram.Visibility = Visibility.Collapsed;
                layer0.ColumnDefinitions.Add(column1ForLayer0);

                if (btnDiagnosis.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2ForLayer1);
                
            } else if(layerNum == 2)
            {
                btnDiagnosis.Visibility = Visibility.Collapsed;
                layer0.ColumnDefinitions.Add(column2ForLayer0);

                if (btnAlram.Visibility == Visibility.Collapsed)
                    layer1.ColumnDefinitions.Add(column2ForLayer1);
            }
        }

        private void Undock(int layerNum)
        {
            if (layerNum == 1)
            {
                btnAlram.Visibility = Visibility.Visible;
                layer0.ColumnDefinitions.Remove(column1ForLayer0);

                layer1.ColumnDefinitions.Remove(column2ForLayer1);
            } else if (layerNum == 2)
            {
                btnDiagnosis.Visibility = Visibility.Visible;
                layer0.ColumnDefinitions.Remove(column2ForLayer0);

                layer1.ColumnDefinitions.Remove(column2ForLayer1);
            }
        }

        private void btnAlram_Click(object sender, RoutedEventArgs e)
        {
            layer1.Visibility = Visibility.Visible;

            Grid.SetZIndex(layer1, 1);
            Grid.SetZIndex(layer2, 0);
            
        }

        private void btnDiagnosis_Click(object sender, RoutedEventArgs e)
        {
            layer2.Visibility = Visibility.Visible;

            Grid.SetZIndex(layer1, 0);
            Grid.SetZIndex(layer2, 1);

        }

        private void btnAlramPin_Click(object sender, RoutedEventArgs e)
        {
            if (btnAlram.Visibility == Visibility.Visible)
                Dock(1);
            else
                Undock(1);
        }

        private void btnDiagnosisPin_Click(object sender, RoutedEventArgs e)
        {
            if (btnDiagnosis.Visibility == Visibility.Visible)
                Dock(2);
            else
                Undock(2);
        }

        private void layer0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (btnAlram.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;

            if (btnDiagnosis.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;    


        }
    }
}
