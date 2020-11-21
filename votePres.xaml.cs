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
using System.Windows.Shapes;

namespace eVote2020
{
    /// <summary>
    /// Interaction logic for votePres.xaml
    /// </summary>
    public partial class votePres : Window
    {
        public votePres()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (dT.IsChecked == true)
            {
                MessageBox.Show("Thank you, your vote for Donald Trump has been recorded.");
                System.Windows.Application.Current.Shutdown();
            }
            else if (jB.IsChecked == true)
            {
                MessageBox.Show("Thank you, your vote for Joe Biden has been recorded.");
                System.Windows.Application.Current.Shutdown();
            }
            else if (jJ.IsChecked == true)
            {
                MessageBox.Show("Thank you, your vote for Jo Jorgensen has been recorded.");
                System.Windows.Application.Current.Shutdown();
            }
            else if (hH.IsChecked == true)
            {
                MessageBox.Show("Thank you, your vote for Howie Hankins has been recorded.");
                System.Windows.Application.Current.Shutdown();
            }
        }
    }
}
