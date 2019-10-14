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

namespace lecture_6_more_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbBoxLessons.Items.Add("Please Pick a Lesson");
            cmbBoxLessons.SelectedIndex = 0;
            cmbBoxLessons.Items.Add("Programming 1");
            cmbBoxLessons.Items.Add("Programming 2");
            cmbBoxLessons.Items.Add("Programming 3");
        }

        private void print_selected(object sender, RoutedEventArgs e)
        {
            switch (cmbBoxLessons.SelectedValue.ToString())
            {
                default:
                    lblSelected.Content = "Warning! You have not selected any lesson correctly!";
                    break;
                case "Programming 1":
                    lblSelected.Content = "You have selected Programming 1 and your course starts at 7 AM";
                    break;
                case "Programming 2":
                    lblSelected.Content = "You have selected Programming 2 and your course starts at 10 AM";
                    break;
                case "Programming 3":
                    MessageBox.Show("Error! You can not select Programming 3");
                    break;
            }
        }
    }
}
