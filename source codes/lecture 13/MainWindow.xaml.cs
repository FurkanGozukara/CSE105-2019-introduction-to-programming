using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace lecture_13
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

        private void BtnGenerateUser_Click(object sender, RoutedEventArgs e)
        {
            int irBegining = 1;
            if (File.Exists("last.txt"))
            {
                foreach (var item in File.ReadLines("last.txt"))
                {
                    if (item.Length < 1)
                        continue;
                    if (Convert.ToInt32(item) > irBegining)
                        irBegining = Convert.ToInt32(item);
                }
            }

            StreamWriter swLastTxt = new StreamWriter("last.txt");
            StreamWriter swUsers = new StreamWriter("user.txt", append: true);
            //swUsers.AutoFlush = true;
            //swLastTxt.AutoFlush = true;

            for (int i = irBegining; i < 2000000000; i++)
            {
                swUsers.WriteLine($"user{i};password{i}");
                swLastTxt.WriteLine(i);
                if (i % 100000 == 0)
                {
                    swUsers.Flush();
                    swLastTxt.Flush();
                }
            }

            //it should be able to continue from where it left when i close and open app
            //generate a text file that
            //contais user name and password up to 2 billion
            //user1;password1
            //user2;password2
        }

        private void BtnCheckUser_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch swTimer = new Stopwatch();
            swTimer.Start();
            bool blRest = checkUserAndPw(txtUser.Text, txtPassword.Text);
            swTimer.Stop();
            MessageBox.Show("user check result: " + blRest + " \t in " + swTimer.ElapsedMilliseconds + " ms");
        }

        private bool checkUserAndPw(string srUserName, string srPassword)
        {
            //this will be written by you
            return false;
        }
    }
}
