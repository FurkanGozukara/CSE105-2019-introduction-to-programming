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

namespace lecture_8_panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 1; i < 11; i++)
            {
                cmbNumbers.Items.Add(i);
            }
            cmbNumbers.SelectedIndex = 0;
        }

        StreamWriter swWrite;
        private void BtnWrite_Click(object sender, RoutedEventArgs e)
        {
            double dblPower = Convert.ToDouble(cmbNumbers.SelectedValue.ToString());

            if (swWrite == null)
                swWrite = new StreamWriter("numbers.txt", true);
            swWrite.WriteLine(DateTime.Now.ToString());
            swWrite.WriteLine();
            for (int i = 0; i < Math.Pow(2, dblPower); i++)
            {
                swWrite.WriteLine(i);
            }
            swWrite.WriteLine("============");
            swWrite.WriteLine();
            swWrite.Flush();
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            listBoxItems.Items.Clear();//clears the items in listbox
            List<string> lstReadLines = new List<string>();

            //the using means that when exited from the using scope, opened streams are automatically closed > https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement

            //this method allow us to read locked file
            //the numbers.txt is locked until the streamwriter is closed which is opened in write button
            using (FileStream fileStream = new FileStream("numbers.txt",
                FileMode.Open,
                FileAccess.Read,
              FileShare.ReadWrite))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (true)
                    {
                        var vrLine = streamReader.ReadLine();
                        if (vrLine == null)
                            break;
                        lstReadLines.Add(vrLine);
                    }
                }
                //streamReader. this does not exists anymore after exited from scope of using
            }
            if (chkReverseSort.IsChecked == true)
                lstReadLines.Reverse();//reverse sorts the list
            foreach (var item in lstReadLines)
            {
                listBoxItems.Items.Add(item);
            }

        }
    }
}
