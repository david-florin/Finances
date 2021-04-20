using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Finances
{
    public class Day
    {
        // Day Properties

        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Expenditure { get; set; }
        public int NumberOfTransactions { get; set; }


        // I created a connection to the database

        static string connectionString = "Data Source=DESKTOP-U35MOIR;Initial Catalog=Finances1;Integrated Security=True";

        
        SqlConnection connection = new SqlConnection(connectionString);



        // I created a list that will return a list with all the days in the Database
        public static List<Finances.Day> AddDaysToList()
        {

            // I created a connection to the database
            SqlConnection connection = new SqlConnection(connectionString);

           
            connection.Open();


            List<Day> DayList = new List<Day>();

            try
            {



                // I created an SQLDataAdapter to export the data from the SQL Table to a C# Data table 

                // I filled in the data table
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Day", connection);

                DataTable dayTable = new DataTable();

                sqlDA.Fill(dayTable);


                // I looped thorugh all the rows and added the data to the Transaction and added the Transactions to the list
                foreach (DataRow row in dayTable.Rows)
                {

                    DayList.Add(new Day()

                    {
                        ID = (int.Parse(row["ID"].ToString())),
                        NumberOfTransactions = (int.Parse(row["NumberOfTransactions"].ToString())),
                        Expenditure = double.Parse(row["Expenditure"].ToString()),
                        Date = DateTime.Parse(row["Date"].ToString())



                    }) ;

                }


                return DayList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }

            return DayList;








        }

        public static void UpdateDay(Day day)
        {
            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

          

            connection.Open();


            try
            {
                // SQL Query to Update the transaction 

                string sqlQueryUpdate = "UPDATE Day SET Expenditure = " + day.Expenditure + ", NumberOfTransactions = " + day.NumberOfTransactions + " WHERE ID = " + day.ID + "";


                // Sql Command to add the data to the database 

                SqlCommand commandAdd = new SqlCommand(sqlQueryUpdate, connection);


                // I checked if the query was executed 
                int i = commandAdd.ExecuteNonQuery();

                if (i != 0)
                {
                
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }


        }

        public static void AddDay(double expenditure, string date, int numberOfTransactions)
        {

            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 

            connection.Open();

            try
            {
                // SQL Query to Add a transaction 

                string sqlQueryAdd = "INSERT INTO Day (Expenditure,Date, NumberOfTransactions) VALUES (" + expenditure + ", '" + date + "', "+ numberOfTransactions +")";


                // Sql Command to add the data to the database 

                SqlCommand commandAdd = new SqlCommand(sqlQueryAdd, connection);


                // I checked if the query was executed 
                int i = commandAdd.ExecuteNonQuery();

                if (i != 0)
                {
                
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }


        }

        public static void DeleteDay(Finances.Day day)
        {
            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 

            connection.Open();


            try
            {
                // SQL Query to Update the transaction 

                string sqlQueryUpdate = "DELETE FROM Day WHERE ID = " + day.ID + "";


                // Sql Command to add the data to the database 

                SqlCommand commandAdd = new SqlCommand(sqlQueryUpdate, connection);


                // I checked if the query was executed 
                int i = commandAdd.ExecuteNonQuery();

                if (i != 0)
                {
                  
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }


        }
    }
}
