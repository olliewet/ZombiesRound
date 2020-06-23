using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        public static SqlConnection sqlConnection;
        string queryA = "select * from ZombiesRounds where Map='Alpha' ";
        string queryB = "select * from ZombiesRounds where Map='Ancient'";
        string queryC = "select * from ZombiesRounds where Map='IX'";
        string queryR = "delete from ZombiesRounds where id = @ZombiesRoundsId";



        public BlackOps4()
        {            
            InitializeComponent();
            cleartextbox();
            string connectionString = ConfigurationManager.ConnectionStrings["ZombiesRound.Properties.Settings.SQLZOOConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlConnect.ShowRound(listRounds, queryA,sqlConnection);
            SqlConnect.ShowRound(listAnicent, queryB,sqlConnection);
            SqlConnect.ShowRound(listIX, queryC, sqlConnection);
            

        }       
        private void cleartextbox()
        {
            myTextBox.Clear();
            myTextBoxA.Clear();
            myTextBoxI.Clear();
        }

        private void Alpha_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 1;
            cleartextbox();
        }

        private void Ancient_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 2;
            cleartextbox();
        }

        private void IX_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 3;
            cleartextbox();
        }

        private void voy_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 4;
            cleartextbox();
        }

        private void Blood_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 5;
            cleartextbox();
        }

        private void Call_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 8;
            cleartextbox();
        }

        private void Class_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 6;
            cleartextbox();
        }

        private void Dead_btn_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 7;
            cleartextbox();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tc_BO4.SelectedIndex = 0;
            cleartextbox();
        }

        private void AddRound_Click(object sender, RoutedEventArgs e)
        {         
                string text;
                int round;
                string map = "Alpha";
                text = myTextBox.Text;
                              
                if (!int.TryParse(text, out round))
                    {
                        MessageBox.Show("Not an integer");
                    }

                else                   
            {
                SqlConnect.AddRound(listRounds, queryA, sqlConnection, map, round);
                SqlConnect.ShowRound(listRounds, queryA, sqlConnection);
            }

        }

        private void listRounds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddRoundIX_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "IX";
            text = myTextBoxI.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listIX, queryC, sqlConnection, map, round);
                SqlConnect.ShowRound(listIX, queryC, sqlConnection);
            }
        }

        private void AddRoundAN_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "Ancient";
            text = myTextBoxA.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listAnicent, queryB, sqlConnection, map, round);
                SqlConnect.ShowRound(listAnicent, queryB, sqlConnection);
            }
        }

        private void RemoveA_btn_Click(object sender, RoutedEventArgs e)
        {           
            SqlConnect.RemoveRound(listRounds, queryR, sqlConnection);
            SqlConnect.ShowRound(listRounds, queryA, sqlConnection);
        }
    }
}
