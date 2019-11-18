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

            }
        }

        private void BtnCheckIndex_Click(object sender, RoutedEventArgs e)
        {
            int irIndex = txtCheck1.Text.IndexOf(txtCheck2.Text);
            if (irIndex == -1)
                MessageBox.Show("text box 1 does not contain text box 2 text");
            else
                MessageBox.Show($"the index of text box 2 in text box 1 is {irIndex}");
        }
    }
}
