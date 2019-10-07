using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace lecture_5_wpf_and_while_loop
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

        private void print_to_screen_with_for(object sender, RoutedEventArgs e)
        {
            var childTask = new Task(() =>
            {
                for (int i = 0; i < 10000000; i++)
                {
                    Thread.Sleep(500);

                    Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                    {
                        lblFor.Content = "for loop: " + i;
                    }));
                }
            }, TaskCreationOptions.AttachedToParent);
            childTask.Start();
        }
    }
}
