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
    public class Balance
    {

        public double Value { get; set; }


        //I created a connection to the Database

        static string connectionString = "Data Source=DESKTOP-U35MOIR;Initial Catalog=Finances1;Integrated Security=True";

        static SqlConnection connection = new SqlConnection(connectionString);


        
        public static void UpdateBalance(double balanceValue)
        {


            // I open the connection to the database and updated the balance value using a SQL Query
            connection.Open();

            SqlCommand cmdUpdate = new SqlCommand("UPDATE Balance1 SET Sum ='" + balanceValue.ToString() + "' WHERE ID=1", connection);


            //I checked if the command was executed

            int i = cmdUpdate.ExecuteNonQuery();

            if (i != 0)
            {
               // MessageBox.Show("Balance Updated");
            }
            else
            {
                MessageBox.Show("Error");
                connection.Close();
            }

            connection.Close();

        }
        

        // I created a Method that will return the Balance amount
        public static double DisplayBalance()
        {
            
            double balanceAmount = 0;


             // I used a reader to get the value from the Database and assign it to a variable

            SqlCommand DisplayAmount = new SqlCommand("SELECT Sum FROM Balance1 WHERE ID = 1", connection);
            connection.Open();
            SqlDataReader reader = DisplayAmount.ExecuteReader();

            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    balanceAmount = Convert.ToDouble(reader.GetValue(0));
                    
                }
            }
            connection.Close();
            return balanceAmount;

            

            
        }
    }
}
