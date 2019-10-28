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
    }
}
