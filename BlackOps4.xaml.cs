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

namespace ZombiesRound
{
    /// <summary>
    /// Interaction logic for BlackOps4.xaml
    /// </summary>
    public partial class BlackOps4 : Window
    {
        public BlackOps4()
        {
            InitializeComponent();
        }

        private void Alpha_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 1;
        }

        private void Ancient_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 2;
        }

        private void IX_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 3;
        }

        private void voy_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 4;
        }

        private void Blood_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 5;
        }

        private void Call_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 8;
        }

        private void Class_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 6;
        }

        private void Dead_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 7;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 0;
        }
    }
}
