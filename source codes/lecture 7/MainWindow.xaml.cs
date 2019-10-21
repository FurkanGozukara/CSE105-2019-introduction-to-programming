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
using System.IO;

namespace lecture_7
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

        private void BtnWrite_Click(object sender, RoutedEventArgs e)
        {
            //compose a stream writer and write numbers 1-1000000 to a text file
            StreamWriter swWrite = new StreamWriter("1million.txt");
            for (int i = 1; i < 10000001; i++)
            {
                swWrite.WriteLine(i);
            }
            swWrite.Flush();
            swWrite.Close();
        }

        private void BtnStreamReader_Click(object sender, RoutedEventArgs e)
        {
            StreamReader swRead = new StreamReader("1million.txt");
            Int64 irBigTotal = 0;
            while (true)
            {
                var vrLine = swRead.ReadLine();
                if (vrLine == null)
                    break;

                irBigTotal += Convert.ToInt64(vrLine);

                //irBigTotal = irBigTotal + Convert.ToInt64(vrLine); same as above
                //add read lines to irBigTotal variable
            }

            MessageBox.Show(irBigTotal.ToString("N0"));
        }

        private void CheckRadioButtons_Click(object sender, RoutedEventArgs e)
        {
            //if (rdMale.IsChecked == true)
            //    MessageBox.Show("Gender is Male");
            //if (rdFemale.IsChecked == true)
            //    MessageBox.Show("Gender is Female");
            //if (rdDoesntKnowEng.IsChecked == true)
            //    MessageBox.Show("Doesn't know English");
            //if (rdKnowENG.IsChecked == true)
            //    MessageBox.Show("Knows English");

            //make this a way that it only shows in 1 message box the selections
            //you can use List

            List<string> lstResults = new List<string>();

            if (rdMale.IsChecked == true)
                lstResults.Add("Gender is Male");
            if (rdFemale.IsChecked == true)
                lstResults.Add("Gender is Female");
            if (rdDoesntKnowEng.IsChecked == true)
                lstResults.Add("Doesn't know English");
            if (rdKnowENG.IsChecked == true)
                lstResults.Add("Knows English");

            MessageBox.Show(string.Join("\n\n", lstResults));

            if (rdMale.IsChecked == false &&
                rdFemale.IsChecked == false &&
                rdDoesntKnowEng.IsChecked == false &&
                rdKnowENG.IsChecked == false)
                MessageBox.Show("You did not make any selection");

            if (rdMale.IsChecked == true |
    rdFemale.IsChecked == true |
    rdDoesntKnowEng.IsChecked == true |
    rdKnowENG.IsChecked == true) { }
            else
                MessageBox.Show("You did not make any selection");

        }

        private void BtnStringJoin_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> lstCheckBoxes = new List<CheckBox>();
            lstCheckBoxes.Add(chkAuto);
            lstCheckBoxes.Add(chkCruse);
            lstCheckBoxes.Add(chkSunRoof);

            List<string> lstSelectedCheckBoxes = new List<string>();

            foreach (CheckBox vrCheckBox in lstCheckBoxes)
            {
                if (vrCheckBox.IsChecked == true)
                {
                    lstSelectedCheckBoxes.Add(vrCheckBox.Content.ToString());
                }
            }

            //write same above loop with for and while

            for (int i = 0; i < lstCheckBoxes.Count; i++)
            {
                if (lstCheckBoxes[i].IsChecked == true)
                {
                    lstSelectedCheckBoxes.Add(lstCheckBoxes[i].Content.ToString());
                }
            }

            int irIndex = 0;
            while (true)
            {
                if (lstCheckBoxes[irIndex].IsChecked == true)
                {
                    lstSelectedCheckBoxes.Add(lstCheckBoxes[irIndex].Content.ToString());
                }
                irIndex++;
                if (irIndex == lstCheckBoxes.Count)
                    break;
            }
            //this is next semesters feature linQ
            lstSelectedCheckBoxes = lstSelectedCheckBoxes.Distinct().ToList();

            string srMsg = "Checked Check Boxes : \t" + string.Join("\n", lstSelectedCheckBoxes);
            MessageBox.Show(srMsg);
        }
    }
}
