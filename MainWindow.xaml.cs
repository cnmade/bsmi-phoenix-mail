using bsmi_phoenix_mail.area.about.view;
using bsmi_phoenix_mail.area.setting.view;
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

namespace bsmi_phoenix_mail
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            cfrm.Navigate(new AboutUs());
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            AllSetting asw = new AllSetting();
            asw.Show();
            
        }

        private void ExitApp(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
    }
}
