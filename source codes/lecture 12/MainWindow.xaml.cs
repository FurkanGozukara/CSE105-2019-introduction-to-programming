using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
            csPublicFunctions.dicUserValues.Add("3123", new csPublicFunctions.userVals());
            cbmBoxUsers.Items.Add("ahmet");
            cbmBoxUsers.Items.Add("mehmet");
            cbmBoxUsers.Items.Add("ali");
            cbmBoxUsers.SelectedIndex = 0;
            GlobalVariables.srLoggedUserName = cbmBoxUsers.SelectedValue.ToString();
            btnPlus.ToolTip = "This writes + to the input box";


        }



        //write calculated result to the selected users file
        //show calculated results in the listbox with reverse order
        //if i change a user, show that users history in list box with reverse order

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double dblResult;
    
            try
            {
                dblResult = Convert.ToDouble(new DataTable().Compute(txtMath.Text, null));
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
                return;
            }
            var vrtext=  txtMath.Text + "\t: " + dblResult.ToString("N2");

            csPublicFunctions.appendToLogFile(cbmBoxUsers.SelectedValue.ToString(),vrtext);
            lstBoxUserLogs.Items.Insert(0, vrtext);
        }

        private void Stringcomparison_Click(object sender, RoutedEventArgs e)
        {
            string srName1 = "Şeyma";
            string srName2 = "seYma";
            string srName3 = "İbrahim";
            string srName4 = "IbraHım";

            var vrName1 = normalizeUserName(srName1);
            var vrName2 = normalizeUserName(srName2);
            var vrName3 = normalizeUserName(srName3);
            var vrName4 = normalizeUserName(srName4);
        }

        private string normalizeUserName(string srUserNameofUser)
        {
            var vrnormal1 = srUserNameofUser.ToUpper(culture: System.Globalization.CultureInfo.CreateSpecificCulture("tr-TR")).ToLower(culture: System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));

            return RemoveDiacritics(vrnormal1);
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        private void CbmBoxUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            csPublicFunctions.readToListBox(this, cbmBoxUsers.SelectedValue.ToString());
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMath.IsFocused && e.Key != Key.Enter)
                return;
            if (e.Key == Key.Add)
            {
                txtMath.Text += "+";
            }
            if (e.Key == Key.Enter)
            {
                BtnCalculate_Click(this, null);
            }
        }

        private void BtnShowPassword_Click(object sender, RoutedEventArgs e)
        {
            var vrSelectedUser = cbmBoxUsers.SelectedValue.ToString();

            if (csPublicFunctions.dicUserValues.ContainsKey(vrSelectedUser))
            {
                MessageBox.Show(csPublicFunctions.dicUserValues[vrSelectedUser].srUserPassword);
            }
            else
                MessageBox.Show("this user does not exists");

            string srUsers = "";

            foreach (var vrPerUser in csPublicFunctions.dicUserValues)
            {
                srUsers += vrPerUser.Key+";"+vrPerUser.Value.srUserPassword+string.Join("\n",vrPerUser.Value.lstUserLogs) + "\t";
            }

            MessageBox.Show(srUsers);
        }

        private void BtnTEstClass_Click(object sender, RoutedEventArgs e)
        {
            StudentList gg1 = new StudentList();
            MessageBox.Show(string.Join(":", gg1.lstStudents));

            StudentList gg2 = new StudentList(new List<string> { "student 1","student 2"});
            MessageBox.Show(string.Join(":", gg2.lstStudents));
        }
    }
}
