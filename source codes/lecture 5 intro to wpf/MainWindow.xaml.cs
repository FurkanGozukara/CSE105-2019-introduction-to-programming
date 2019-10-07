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

namespace lecture_5_intro_to_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnIfElse.Content = "if else test";
        }

        private void if_else_test_click_event(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            int irRandomNumber = rng.Next(10, 200);
            if (irRandomNumber < 25)
            {
                lblIfElseResult.Content = $"generated random number is {irRandomNumber} and case 1";
            }
            else
            if (irRandomNumber >= 25 && irRandomNumber < 75)
            {
                lblIfElseResult.Content = $"generated random number is {irRandomNumber} and case 2";
            }
            else
            if (irRandomNumber >= 75 && irRandomNumber < 150)
            {
                lblIfElseResult.Content = $"generated random number is {irRandomNumber} and case 3";
            }
            else
                lblIfElseResult.Content = $"generated random number is {irRandomNumber} and case 4";



            if (irRandomNumber > 70)
            {
                lblIf.Content = $"generated random number is {irRandomNumber} and case 3";
            }
            if (irRandomNumber > 50)
            {
                lblIf.Content = $"generated random number is {irRandomNumber} and case 2";
            }
            if (irRandomNumber > 20)
            {
                lblIf.Content = $"generated random number is {irRandomNumber} and case 1";
            }

            if (irRandomNumber > 70)
            {
                lblIfElseTwo.Content = $"generated random number is {irRandomNumber} and case 3";
            }
            else
            if (irRandomNumber > 50)
            {
                lblIfElseTwo.Content = $"generated random number is {irRandomNumber} and case 2";
            }
            else
            if (irRandomNumber > 20)
            {
                lblIfElseTwo.Content = $"generated random number is {irRandomNumber} and case 1";
            }
        }

        private void sum_two_numbers(object sender, RoutedEventArgs e)
        {
            double dblNum1, dblNum2;

            double.TryParse(txtinput1.Text, out dblNum1);//this handles errors
            //Convert.ToDouble this does not handle the errors
            double.TryParse(txtinput2.Text, out dblNum2);

            txtoutput.Text = (dblNum1 + dblNum2).ToString("N3");

            var sum = dblNum1 + dblNum2;

            lblFullNumber.Content = sum;

            var vrRounded = Math.Round(sum, 3);

            lblRoundedNumber.Content = vrRounded;

            var vrResult = $"{dblNum1} + {dblNum2} = {vrRounded}";

            lstResults.Items.Add(vrResult);
            lstResultsBottomUp.Items.Insert(0, vrResult);
        }
    }
}
