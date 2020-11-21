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
    /// Interaction logic for verifyVoter.xaml
    /// </summary>
    public partial class verifyVoter : Window
    {
        public verifyVoter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            votePres tt = new votePres();
            tt.Show();
            this.Close();
        }
    }
}
