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
using System.Windows.Media.Animation;

namespace SlotMaschine2
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        
        public MainWindow()
        {
            InitializeComponent();
            MainWindow.GetWindow(this);
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //var wnd = new Login();
            //wnd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //wnd.ShowDialog();
            btnshow.Click += Btnshow_Click;
            btnclose.Click += Btnclose_Click;
            lblUsernameMain.Content = aktuellerUser.logindaten();
            
        }


        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var login = new Login();
            login.ShowDialog();
        }

        private void Btnclose_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["CloseMenu"] as Storyboard;
            sb.Begin(LeftMenu);
            ButtonVisibility();
        }
        private void Btnshow_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["OpenMenu"] as Storyboard;
            sb.Begin(LeftMenu);
            ButtonVisibility();
        }

        private void  ButtonVisibility()
        {
            if (btnshow.Visibility == Visibility.Visible)
            {
                btnshow.Visibility = Visibility.Hidden;
            }
            else
            {
                btnshow.Visibility = Visibility.Visible;
            }
        }



    }
}
