using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace SimpleWPFApp
{
    class MyWPFApp: Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            MyWPFApp app = new MyWPFApp();
            app.Startup += AppStartUp;
            //app.Exit += AppExit;
            //app.Deactivated += AppDeactivated;
            app.Run();
        }

        static void AppDeactivated(object sender, EventArgs e)
        {
            MessageBox.Show("Deactivated");
        }

        static void AppExit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("App has exited");
        }

        static void AppStartUp(object sender, StartupEventArgs e)
        {
            Application.Current.Properties["GodMode"] = false;

            foreach(string arg in e.Args)
            {
                if (arg.ToLower() == "/godmode")
                {
                    Application.Current.Properties["GodMode"] = true;
                    break;
                }
            }
            MainWindow wnd = new MainWindow("Sample title", 500, 500);
            
            //Window mainWindow = new Window();
            //mainWindow.Title = "My First Window";
            //mainWindow.Height = 200;
            //mainWindow.Width = 300;
            //mainWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //mainWindow.Show();
        }

    }

    class MainWindow: Window
    {
        private Button btnExitApp = new Button();
        public MainWindow(string windowTitle, int height, int width)
        {
            //btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
            btnExitApp.Click += new RoutedEventHandler((sender, e) => { Application.Current.Shutdown(); });
            btnExitApp.Height = 25;
            btnExitApp.Width = 100;
            btnExitApp.Content = "Exit Application";
            this.AddChild(btnExitApp);
            this.Closing += MainWindow_Closing;
            this.MouseDoubleClick += MainWindow_MouseDoubleClick;

            this.Title = windowTitle;
            this.Height = height;
            this.Width = width;
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            this.Show();
        }

        private void MainWindow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string msg = "Do you want to close?";

            MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        static void MinimizeAllWindows()
        {
            foreach(Window wnd in Application.Current.Windows)
            {
                wnd.WindowState = WindowState.Minimized;
            }
        }

        private static void btnExitApp_Clicked(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            MinimizeAllWindows();
            
        }
    }
}
