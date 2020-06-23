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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ZombiesRound
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
       

        private void BO2_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Bo4 = new BlackOps4();
            Bo4.tc_BO4.SelectedIndex = 0;
            this.Close();
            Bo4.Show();
        }

        private void BO3btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show");
        }

        private void BO1btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Show");
        }
    }
}
