﻿using System;
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

        private void test_switch_number(object sender, RoutedEventArgs e)
        {
            int irNumber = -1;

            try
            {
                irNumber = Convert.ToInt32(txtNumber.Text);
                irNumber = Int32.Parse(txtNumber.Text);
            }
            catch (Exception E)
            {
                //MessageBox.Show("Error! You have entered an invalid number\n\n"
                //    +
                //    E.Message.ToString()
                //    +"\n\n"+
                //    E.StackTrace.ToString());

                string srErrorMsg = string.Format("Error! You have entered an invalid number\n\n{0}\n\n{1}", E.Message.ToString(), E.StackTrace.ToString());

                MessageBox.Show(srErrorMsg);
            }
            bool blResult = Int32.TryParse(txtNumber.Text, out irNumber);
            
            if(!blResult) // (blResult==False)
            {
                MessageBox.Show("Error! You have entered an invalid number");
            }

            switch (irNumber)
            {
                case 1:
                    lblSelected.Content = "award winner 1";
                    MessageBox.Show("award winner 1");
                    break;
                case 1000:
                    MessageBox.Show("correct choice");
                    break;
                default:
                    MessageBox.Show("no number is selected");
                    break;
            }
        }

        private void write_to_text_file(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("text_box_content.txt", txtArticle.Text, Encoding.UTF8);
        }
    }
}
