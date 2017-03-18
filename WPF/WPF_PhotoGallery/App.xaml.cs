using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_PhotoGallery
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);
            MessageBox.Show("Deactiaved");
        }
    }
}
