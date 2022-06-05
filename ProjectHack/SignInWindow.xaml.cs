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
using System.Text.RegularExpressions;

namespace ProjectHack
{
    /// <summary>
    /// Interaction logic for SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        User user = new User();
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void ShowPassword_PreviewMouseUp(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
        private void ShowPassword_MouseLeave(object sender, MouseButtonEventArgs e) => HidePasswordFunction();
        private void ShowPassword_PreviewMouseDown(object sender, MouseButtonEventArgs e) => ShowPasswordFunction();

        private void ShowPasswordFunction()
        {
            ShowPassword.Text = "hide";
            PasswordUnmask.Visibility = Visibility.Visible;
            PasswordHidden.Visibility = Visibility.Hidden;
            PasswordUnmask.Text = PasswordHidden.Password;

        }
        private void HidePasswordFunction()
        {
            ShowPassword.Text = "show";
            PasswordUnmask.Visibility = Visibility.Hidden;
            PasswordHidden.Visibility = Visibility.Visible;
        }
        private void ShowPassword_PreviewMouseUp1(object sender, MouseButtonEventArgs e) => HidePasswordFunction1();
        private void ShowPassword_MouseLeave1(object sender, MouseButtonEventArgs e) => HidePasswordFunction1();
        private void ShowPassword_PreviewMouseDown1(object sender, MouseButtonEventArgs e) => ShowPasswordFunction1();

        private void ShowPasswordFunction1()
        {
            ShowPassword1.Text = "HIDE";
            PasswordUnmask1.Visibility = Visibility.Visible;
            PasswordHidden1.Visibility = Visibility.Hidden;
            PasswordUnmask1.Text = PasswordHidden1.Password;

        }
        private void HidePasswordFunction1()
        {
            ShowPassword1.Text = "SHOW";
            PasswordUnmask1.Visibility = Visibility.Hidden;
            PasswordHidden1.Visibility = Visibility.Visible;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Button_CreateUser(object sender, RoutedEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(IdBox.Text))
                    throw new Exception("Bad input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Id is empty");
            }
            try
            {
                if (String.IsNullOrEmpty(UsernameBox.Text))
                    throw new Exception("Bad input");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username is empty");
            }
            try
            {
                string password1 = PasswordHidden1.Password;
                if (PasswordHidden.Password != password1)
                {

                    MessageBox.Show("Passwords don't match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Password is empty");
            }
            int id = int.Parse(IdBox.Text);
            string username = UsernameBox.Text;
            string password = PasswordHidden.Password;
            Form1 form = new Form1();

            form.CurrentUser1 = user.CreateNewUser(id, username, password);
            
            form.init();
            form.Show();
            this.Close();

        }
    }
}
