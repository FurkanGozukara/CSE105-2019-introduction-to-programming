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
using NCalc;

namespace lecture_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cbmBoxUsers.Items.Add("ahmet");
            cbmBoxUsers.Items.Add("mehmet");
            cbmBoxUsers.Items.Add("ali");
            cbmBoxUsers.SelectedIndex = 0;
        }

        //write calculated result to the selected users file
        //show calculated results in the listbox with reverse order

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            NCalc.Expression myExpression = new NCalc.Expression(txtMath.Text);
            try
            {
                double dblResult = (double)myExpression.Evaluate();//casting object type into double type
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message.ToString());
            }   
        }
    }
}
