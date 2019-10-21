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
            while(true)
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
    }
}
