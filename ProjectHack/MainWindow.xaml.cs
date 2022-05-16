using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User Currentuser = new User();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void connectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(id.Text))
                    throw new Exception("Bad input");
                if (String.IsNullOrEmpty(PasswordHidden.Password))
                    throw new Exception("Bad input");
                string user = id.Text;
                string password1 = PasswordHidden.Password;
                if (!Currentuser.CheckPassword(user, password1))
                    throw new Exception("Bad input");
                Currentuser = Currentuser.getUser(id.Text);
                Form1 form = new Form1();
                form.CurrentUser1 = Currentuser;
                form.init();
                form.Show();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TextBox_GotFocus;
        }


        private void ShowPassword_PreviewMouseUp(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
        private void ShowPassword_MouseLeave(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
        private void ShowPassword_PreviewMouseDown(object sender, MouseButtonEventArgs e) => ShowPasswordFunction();

        private void ShowPasswordFunction()
        {
            ShowPassword.Text = "hide";
            Password.Visibility = Visibility.Visible;
            PasswordHidden.Visibility = Visibility.Hidden;
            Password.Text = PasswordHidden.Password;

        }
        private void HidePasswordFunction()
        {
            ShowPassword.Text = "show";
            Password.Visibility = Visibility.Hidden;
            PasswordHidden.Visibility = Visibility.Visible;
        }

        private void signInButton_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow win = new SignInWindow();
            win.ShowDialog();
        }

    }
}