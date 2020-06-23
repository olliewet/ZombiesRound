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

namespace ZombiesRound
{
    public class SqlConnect
    {
      
        public static void ShowRound(ListBox list, string q, SqlConnection sqlConnection)
        {
            try
            {
                string query = q;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                using (sqlDataAdapter)
                {
                    
                    DataTable zombieTable = new DataTable();
                    sqlDataAdapter.Fill(zombieTable);
                    list.DisplayMemberPath = "Round";
                    list.SelectedValuePath = "Id";
                    list.ItemsSource = zombieTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public static void RemoveRound(ListBox list, string q, SqlConnection sqlConnection)
        {
            try
            {
                string query = q;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZombiesRoundsId", list.SelectedValue);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            finally
            {
                sqlConnection.Close();
                
            }                     
        }


        public static void AddRound(ListBox list, string q, SqlConnection sqlConnection, string map, int round)
        {
            try
            {
                
                string name = "Default";
                string query = "insert into ZombiesRounds (Map,Round,Name) Values (@Map, @Round , @Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Map", map);
                sqlCommand.Parameters.AddWithValue("@Round", round);
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.ExecuteScalar();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            finally
            {
                sqlConnection.Close();               
            }
        }
    }
}
