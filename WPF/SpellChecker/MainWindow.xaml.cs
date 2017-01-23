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

namespace SpellChecker
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

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void MouseEnterExitArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Exit Application";
        }

        private void MouseLeaveArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Ready";

        }

        private void MouseEnterToolsHintsArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Show Spelling Suggestions";

        }

        private void ToolsSpellingHints_Click(object sender, RoutedEventArgs e)
        {
            string hints = string.Empty;

            SpellingError err = txtData.GetSpellingError(txtData.CaretIndex);

            if (err != null)
            {
                foreach(string s in err.Suggestions)
                {
                    hints += string.Format("{0}\n", s);
                }

                lblSpellingHint.Content = hints;
                expenderSPelling.IsExpanded = true;
            } else
            {
                lblSpellingHint.Content = string.Empty;
            }


        }
    }
}
