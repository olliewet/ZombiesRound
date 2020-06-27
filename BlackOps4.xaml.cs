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
        #region Variables and Query
        public static SqlConnection sqlConnection;
        string queryA = "select * from ZombiesRounds where Map='Alpha' ";
        string queryB = "select * from ZombiesRounds where Map='Ancient'";
        string queryC = "select * from ZombiesRounds where Map='IX'";
        string queryD = "select * from ZombiesRounds where Map='Voyage'";
        string queryE = "select * from ZombiesRounds where Map='Blood'";
        string queryF = "select * from ZombiesRounds where Map='Class'";
        string queryDE = "select * from ZombiesRounds where Map='Dead'";
        string queryR = "delete from ZombiesRounds where id = @ZombiesRoundsId";
        #endregion

        public BlackOps4()
        {            
            InitializeComponent();
            cleartextbox();
            string connectionString = ConfigurationManager.ConnectionStrings["ZombiesRound.Properties.Settings.SQLZOOConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            SqlConnect.ShowRound(listRounds, queryA,sqlConnection);
            SqlConnect.ShowRound(listAnicent, queryB,sqlConnection);
            SqlConnect.ShowRound(listIX, queryC, sqlConnection);
            SqlConnect.ShowRound(listV, queryD, sqlConnection);
            SqlConnect.ShowRound(listB, queryE, sqlConnection);
            SqlConnect.ShowRound(listC, queryF, sqlConnection);
            SqlConnect.ShowRound(listD, queryDE, sqlConnection);
        }    
                       

        #region Button Clicks
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
       

        #endregion

        #region Add Rounds 
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
        private void AddRoundV_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "Voyage";
            text = mytextboxV.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listV, queryD, sqlConnection, map, round);
                SqlConnect.ShowRound(listV, queryD, sqlConnection);
            }
        }

        private void AddRoundB_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "Blood";
            text = mytextboxB.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listB, queryE, sqlConnection, map, round);
                SqlConnect.ShowRound(listB, queryE, sqlConnection);
            }
        }
        private void AddRoundC_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "Class";
            text = mytextboxC.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listC, queryF, sqlConnection, map, round);
                SqlConnect.ShowRound(listC, queryF, sqlConnection);
            }
        }

        private void AddRoundD_Click(object sender, RoutedEventArgs e)
        {
            string text;
            int round;
            string map = "Dead";
            text = mytextboxD.Text;

            if (!int.TryParse(text, out round))
            {
                MessageBox.Show("Not an integer");
            }

            else
            {
                SqlConnect.AddRound(listD, queryDE, sqlConnection, map, round);
                SqlConnect.ShowRound(listD, queryDE, sqlConnection);
            }
        }

        #endregion 

        #region Selection Changed
        private void listRounds_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void listV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void listB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void listC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void listD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        #endregion

        #region Remove Buttons
        private void RemoveA_btn_Click(object sender, RoutedEventArgs e)
        {
            //If nothing is selected 
            if (listRounds.SelectedIndex == -1)             
            {
                MessageBox.Show("Select a round!");
            }
            else
            {


                SqlConnect.RemoveRound(listRounds, queryR, sqlConnection);
                SqlConnect.ShowRound(listRounds, queryA, sqlConnection);
            }
        }

        private void RemoveAN_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listRounds.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listAnicent, queryR, sqlConnection);
                SqlConnect.ShowRound(listAnicent, queryB, sqlConnection);
            }

        }

        private void RemoveIX_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listIX.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listIX, queryR, sqlConnection);
                SqlConnect.ShowRound(listIX, queryC, sqlConnection);
            }
        }
        private void RemoveV_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listV.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listV, queryR, sqlConnection);
                SqlConnect.ShowRound(listV, queryD, sqlConnection);
            }
        }

        private void RemoveB_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listB.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listV, queryR, sqlConnection);
                SqlConnect.ShowRound(listV, queryE, sqlConnection);
            }
        }
        private void RemoveC_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listC.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listC, queryR, sqlConnection);
                SqlConnect.ShowRound(listC, queryF, sqlConnection);
            }
        }

        private void RemoveD_btn_Click(object sender, RoutedEventArgs e)
        {
            if (listD.SelectedIndex == -1)
            {
                MessageBox.Show("Select a round!");
            }
            else
            {
                SqlConnect.RemoveRound(listD, queryR, sqlConnection);
                SqlConnect.ShowRound(listD, queryDE, sqlConnection);
            }
        }

        #endregion

        #region Home 
        private void HomeA_Click(object sender, RoutedEventArgs e)
        {
            home();
        }

        private void HomeIX_Click(object sender, RoutedEventArgs e)
        {
            home();
        }

        private void HomeV_Click(object sender, RoutedEventArgs e)
        {
            home();
        }
        private void HomeB_Click(object sender, RoutedEventArgs e)
        {
            home();
        }
        private void HomeC_Click(object sender, RoutedEventArgs e)
        {
            home();
        }
        private void HomeD_Click(object sender, RoutedEventArgs e)
        {
            home();
        }
        #endregion

        #region Misc Methods 
        private void cleartextbox()
        {
            myTextBox.Clear();
            myTextBoxA.Clear();
            myTextBoxI.Clear();
            mytextboxV.Clear();
            mytextboxB.Clear();
            mytextboxC.Clear();
            mytextboxD.Clear();
            
        }
        private void home()
        {
            tc_BO4.SelectedIndex = 0;
            cleartextbox();
        }














        #endregion

          
    }
}
