using System;
using System.Collections.Generic;
using System.IO;
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

namespace lecture_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string srUsernameDefault = "please enter a username";

        public MainWindow()
        {
            InitializeComponent();
            txtUserName.Text = srUsernameDefault;
        }

        private void TxtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == srUsernameDefault)
                txtUserName.Text = "";
        }

        private void TxtUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text.Length < 3)
                txtUserName.Text = srUsernameDefault;
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            string srSelectedUserName = txtUserName.Text;
            if(srSelectedUserName.Length<3)
            {
                MessageBox.Show("invalid username. username has to be minimum 3 characters!");
                return;
            }
            List<char> lstChars = new List<char>();
            foreach (var vrChar in System.IO.Path.GetInvalidFileNameChars())
            {
                lstChars.Add(vrChar);
            }

            if(srSelectedUserName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) >= 0)
            {
                //MessageBox.Show("there is an invalid character in your username. check again!");
                //return;
            }

            //this below equals to what does above code do
            bool blInvalidCharExists = false;
            string srInvalidChar = "";
            foreach (var vrChar in System.IO.Path.GetInvalidFileNameChars())
            {
                if (srSelectedUserName.IndexOf(vrChar) != -1)
                {
                    blInvalidCharExists = true;
                    srInvalidChar = vrChar.ToString();
                    break;
                }
            }
            if (blInvalidCharExists)
            {
                MessageBox.Show($"Your username contains invalid character ({srInvalidChar}) \t Please fix your username!");
                return;
            }
            if(txtUserName.Text==srUsernameDefault)
            {
                //dont forget this
            }

            string srPw1 = pwBox1_Copy.Password.ToString();
            string srPw2 = pwBox1_Copy1.Password.ToString();

            if(srPw1!=srPw2)
            {
                MessageBox.Show($"your password is not matching. please re-enter");
                return;
            }

            if(csPublicFunctions.checkUserExists(srSelectedUserName))
            {
                MessageBox.Show($"this username already exists. please select another username!");
                return;
            }

            string srHashedPassword = encrtpy.ComputeSha256Hash(srPw1);

            File.AppendAllText("users.txt", srSelectedUserName + csPublicFunctions.crUsernamePasswordSeperator + srHashedPassword+"\r\n");
        }

        private void BtnCheckIndex_Click(object sender, RoutedEventArgs e)
        {
            int irIndex = txtCheck1.Text.IndexOf(txtCheck2.Text);
            if (irIndex == -1)
                MessageBox.Show("text box 1 does not contain text box 2 text");
            else
                MessageBox.Show($"the index of text box 2 in text box 1 is {irIndex}");
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
          if(csPublicFunctions.checkPasswordTrue(txtLogin_UserName.Text, pwLogin_pass.Password.ToString()))
            {
                MessageBox.Show("correct username and password");
            }
          else
                MessageBox.Show("incorrect username and password");
        }
    }
}
