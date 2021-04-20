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

namespace Spending_App2
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }

        //I created a connection String

        static string connectionString = "Data Source=DESKTOP-U35MOIR;Initial Catalog=Finances1;Integrated Security=True";


        // The method to display all transactions in the Data Grid View

        public static void DisplayTransactions(DataGridView Display, DateTime date)
        {

            // I created a connection to the database
            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 
            connection.Open();

            // I created an SQL command to add all the transactions from a specific date to the table and display them
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Transaction2 WHERE date = '" + date.ToString("yyyy-MM-dd") + "' ", connection);

            // I created a table to serve as the source of the DataGridView
            DataTable table = new DataTable();

            sqlDa.Fill(table);

            Display.DataSource = table;

            connection.Close();


        }

        public static DataTable GetTransactionTable(DateTime date)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 
            connection.Open();

            string SQLString = "SELECT * FROM Transaction2 WHERE date = '" + date.ToString("yyyy-MM-dd") + "' ";

            // I created an SQL command to add all the transactions from a specific date to the table and display them
            SqlDataAdapter sqlDa = new SqlDataAdapter(SQLString, connection);

            // I created a table to serve as the source of the DataGridView
            DataTable table = new DataTable();

            sqlDa.Fill(table);

            connection.Close();

            return table;
        }

        public static List<Transaction> AddTransactionsToList()
        {

            // I created a connection to the database
            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 
            connection.Open();

            List<Transaction> TransactionList = new List<Transaction>();

            try
            {



                // I created an SQLDataAdapter to export the data from the SQL Table to a C# Data table and I filled in the data table
                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Transaction2", connection);

                DataTable transactionTable = new DataTable();

                sqlDA.Fill(transactionTable);


                // I looped thorugh all the rows and added the data to the Transaction and added the Transactions to the list
                foreach (DataRow row in transactionTable.Rows)
                {

                    TransactionList.Add(new Transaction()

                    {

                        TransactionID = (int.Parse(row["ID"].ToString())),
                        Value = double.Parse(row["Value"].ToString()),
                        Category = row["Category"].ToString(),
                        Note = row["Note"].ToString(),
                        Date = DateTime.Parse(row["Date"].ToString())

                    });

                }


                return TransactionList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                connection.Close();
            }

            return TransactionList;








        }

        // I created a method to insert a transaction to the Database 

        public static void AddTransaction(double value, string date, string category, string note)
        {

            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 

            connection.Open();

            try
            {
                // SQL Query to Add a transaction 

                string sqlQueryAdd = "INSERT INTO Transaction2 (Value, Category, Note, Date) VALUES (" + value + ", '" + category + "','" + note + "', '" + date + "')";


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




        public static void UpdateTransaction(Transaction transaction)
        {
            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 

            connection.Open();


            try
            {
                // SQL Query to Update the transaction 

                string sqlQueryUpdate = "UPDATE Transaction2 SET Value = " + transaction.Value + ", Category = '" + transaction.Category + "', Note = '" + transaction.Note + "', Date =  '" + transaction.Date.ToString() + "' WHERE ID = " + transaction.TransactionID + "";


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

        public static void DeleteTransaction(Transaction transaction)
        {
            // I created a connection to the database

            SqlConnection connection = new SqlConnection(connectionString);

            // I opened the connection 

            connection.Open();


            try
            {
                // SQL Query to Update the transaction 

                string sqlQueryUpdate = "DELETE FROM Transaction2 WHERE ID = " + transaction.TransactionID + "";


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
