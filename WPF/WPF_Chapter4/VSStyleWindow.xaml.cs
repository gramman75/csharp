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
        ColumnDefinition column1CloneForLayer0;
        ColumnDefinition column2CloneForLayer0;
        ColumnDefinition column2CloneForLayer1;

        public VSStyleWindow()
        {
            InitializeComponent();
            column1CloneForLayer0 = new ColumnDefinition();
            column1CloneForLayer0.SharedSizeGroup = "column1";
            column2CloneForLayer0 = new ColumnDefinition();
            column2CloneForLayer0.SharedSizeGroup = "column2";
            column2CloneForLayer1 = new ColumnDefinition();
            column2CloneForLayer1.SharedSizeGroup = "column2";
        }

        public void DockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                pane1Button.Visibility = Visibility.Collapsed;

                layer0.ColumnDefinitions.Add(column1CloneForLayer0);
                
                if (pane2Button.Visibility == Visibility.Collapsed)
                {
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
                }
            } else if(paneNumber == 2)
            {
                pane2Button.Visibility = Visibility.Collapsed;
                layer0.ColumnDefinitions.Add(column2CloneForLayer0);

                if (pane1Button.Visibility == Visibility.Collapsed)
                {
                    layer1.ColumnDefinitions.Add(column2CloneForLayer1);
                }


            }
        }


        public void UndockPane(int paneNumber)
        {
            if (paneNumber == 1)
            {
                layer1.Visibility = Visibility.Visible;
                pane1Button.Visibility = Visibility.Visible;
                // Remove the cloned columns from layers 0 and 1:
                layer0.ColumnDefinitions.Remove(column1CloneForLayer0);
                // This won’t always be present, but Remove silently ignores bad columns:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
            else if (paneNumber == 2)
            {
                layer2.Visibility = Visibility.Visible;
                pane2Button.Visibility = Visibility.Visible;
                // Remove the cloned columns from layers 0 and 1:
                layer0.ColumnDefinitions.Remove(column2CloneForLayer0);
                // This won’t always be present, but Remove silently ignores bad columns:
                layer1.ColumnDefinitions.Remove(column2CloneForLayer1);
            }
        }

        public void pane1Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Collapsed)
                UndockPane(1);
            else
                DockPane(1);
        }

        public void pane2Pin_Click(object sender, RoutedEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Collapsed)
                UndockPane(2);
            else
                DockPane(2);
        }

        public void pane1_MouseEnter(object sender, RoutedEventArgs e)
        {

        }

        public void pane2_MouseEnter(object sender, RoutedEventArgs e)
        {

        }

        private void pane1Button_Click(object sender, RoutedEventArgs e)
        {
            layer1.Visibility = Visibility.Visible;
            Grid.SetZIndex(layer1, 1);
            Grid.SetZIndex(layer2, 0);

            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }

        public void pane2Button_Click(object sender, RoutedEventArgs e)
        {
            layer2.Visibility = Visibility.Visible;

            Grid.SetZIndex(layer1, 0);
            Grid.SetZIndex(layer2, 1);

            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;
        }

        private void pane1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }

        private void pane2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;

        }

        private void layer0_MouseDown(object sender, MouseEventArgs e)
        {
            if (pane1Button.Visibility == Visibility.Visible)
                layer1.Visibility = Visibility.Collapsed;

            if (pane2Button.Visibility == Visibility.Visible)
                layer2.Visibility = Visibility.Collapsed;
        }
      
    }
}
