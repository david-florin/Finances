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
    public partial class Main : Form
    {


        // I created a conncection to the databse

        static string connectionString = "Data Source=DESKTOP-U35MOIR;Initial Catalog=Finances1;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);



        public Main()
        {

            InitializeComponent();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the Balance amount when the form loads
            labelBalanceAmount.Text = Finances.Balance.DisplayBalance().ToString();



            // Display all the transactions

            Transaction.DisplayTransactions(dataGridViewTransactions, dateTimePickerDateSelector.Value);

            dataGridViewTransactions.Columns["ID"].Visible = false;


            // Display the Transaction section as the Home Page
            tabControlPages.SelectTab(1);


            
                

            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dataGridViewTransactions.SelectedRows.Count > 0)
                {
                    textBoxDisplaySum.Text = dataGridViewTransactions.SelectedRows[0].Cells["Value"].Value.ToString();
                    textBoxDisplayNote.Text = dataGridViewTransactions.SelectedRows[0].Cells["Note"].Value.ToString();
                    dateTimePickerDisplayDate.Text = dataGridViewTransactions.SelectedRows[0].Cells["Date"].Value.ToString();
                    textBoxDisplayCategory.Text = dataGridViewTransactions.SelectedRows[0].Cells["Category"].Value.ToString();



                }





            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }



        }

        private void buttonAddAmount_Click(object sender, EventArgs e)
        {

            try
            {
                // Update the balance amount using specific Method
                Finances.Balance.UpdateBalance(double.Parse(textBoxAddAmount.Text));

                // Display the Balance amount displayed when the amount updates
                labelBalanceAmount.Text = Finances.Balance.DisplayBalance().ToString();


                // Confirm that the Balance was updated
                MessageBox.Show("Balance Updated!");
            }
            catch (Exception ex )
            {
                MessageBox.Show("Error");
                
            }
            
            

        }

        private void buttonAddTrans_Click(object sender, EventArgs e)
        {


            try
            {
                // When clicking the Add transaction button a new instance of the Transaction class is created and the properties of the new Transaction object are updated. 
                Transaction T1 = new Transaction();


                T1.Value = float.Parse(textBoxTransactionSum.Text);
                T1.Date = dateTimePickerTransactionDate.Value;
                T1.Category = comboBoxTransactionCategory.Text;
                T1.Note = textBoxTransactionNote.Text;

                Transaction.AddTransaction(T1.Value, T1.Date.ToString(), T1.Category, T1.Note);


                // Updating the balance value 
                Finances.Balance Balance1 = new Finances.Balance();

                Balance1.Value = Finances.Balance.DisplayBalance();


                Finances.Balance.UpdateBalance((Balance1.Value - T1.Value));

                //Display the updated balance value after adding a transaction 
                labelBalanceAmount.Text = Finances.Balance.DisplayBalance().ToString();


                // When a new transaction is added I update the Day associated with that transaction in the database. If there is no day for that transaction, a new day is added to the database
                List<Finances.Day> DayList = new List<Finances.Day>();
                DayList = Finances.Day.AddDaysToList();

                bool dayUpdated = false;

                for (int i = 0; i < DayList.Count; i++)
                {
                    if (DayList[i].Date.Date == T1.Date.Date)
                    {
                        DayList[i].Expenditure = DayList[i].Expenditure + T1.Value;
                        DayList[i].NumberOfTransactions = DayList[i].NumberOfTransactions + 1;

                        Finances.Day.UpdateDay(DayList[i]);
                        dayUpdated = true;
                    }



                }
                if (dayUpdated == false)
                {
                    Finances.Day.AddDay(T1.Value, T1.Date.ToString(), 1);
                }

                MessageBox.Show("Transaction Successfully Added!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void tabPageTransactions_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateSelector_ValueChanged(object sender, EventArgs e)
        {
            Transaction.DisplayTransactions(dataGridViewTransactions, dateTimePickerDateSelector.Value);
        }

        private void buttonDisplayTransaction_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateTransaction_Click(object sender, EventArgs e)
        {

            try
            {
                Transaction T1 = new Transaction();


                double.TryParse(textBoxDisplaySum.Text, out double number);
                T1.Value = number;
                T1.Note = textBoxDisplayNote.Text;
                T1.Date = dateTimePickerDisplayDate.Value;
                T1.Category = textBoxDisplayCategory.Text;
                T1.TransactionID = int.Parse(dataGridViewTransactions.SelectedRows[0].Cells["ID"].Value.ToString());


                Transaction.UpdateTransaction(T1);

                double difference = double.Parse(dataGridViewTransactions.SelectedRows[0].Cells["Value"].Value.ToString()) - number;

                double updatedBalance = double.Parse(labelBalanceAmount.Text) + difference;

                Finances.Balance.UpdateBalance(updatedBalance);
                labelBalanceAmount.Text = Finances.Balance.DisplayBalance().ToString();


                Transaction.DisplayTransactions(dataGridViewTransactions, dateTimePickerDateSelector.Value);

                dataGridViewTransactions.Columns["ID"].Visible = false;




                List<Finances.Day> DayList = new List<Finances.Day>();
                DayList = Finances.Day.AddDaysToList();



                for (int i = 0; i < DayList.Count; i++)
                {
                    if (DayList[i].Date.Date == T1.Date.Date)
                    {
                        DayList[i].Expenditure = DayList[i].Expenditure - difference;


                        Finances.Day.UpdateDay(DayList[i]);

                    }



                }

                MessageBox.Show("Transaction Updated!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void buttonDeleteTransaction_Click(object sender, EventArgs e)
        {

            try
            {
                Transaction T1 = new Transaction();

                T1.TransactionID = int.Parse(dataGridViewTransactions.SelectedRows[0].Cells["ID"].Value.ToString());
                T1.Value = double.Parse(dataGridViewTransactions.SelectedRows[0].Cells["Value"].Value.ToString());
                T1.Date = dateTimePickerDisplayDate.Value;
                Transaction.DeleteTransaction(T1);

                double updatedBalance = double.Parse(labelBalanceAmount.Text) + T1.Value;
                Finances.Balance.UpdateBalance(updatedBalance);
                labelBalanceAmount.Text = Finances.Balance.DisplayBalance().ToString();


                Transaction.DisplayTransactions(dataGridViewTransactions, dateTimePickerDateSelector.Value);

                dataGridViewTransactions.Columns["ID"].Visible = false;



                List<Finances.Day> DayList = new List<Finances.Day>();
                DayList = Finances.Day.AddDaysToList();



                for (int i = 0; i < DayList.Count; i++)
                {


                    if (DayList[i].Date.Date == T1.Date.Date)
                    {
                        DayList[i].Expenditure = DayList[i].Expenditure - T1.Value;

                        DayList[i].NumberOfTransactions = DayList[i].NumberOfTransactions - 1;
                        Finances.Day.UpdateDay(DayList[i]);

                    }

                    if (DayList[i].NumberOfTransactions == 0)
                    {
                        Finances.Day.DeleteDay(DayList[i]);
                    }


                }

                MessageBox.Show("Transaction deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

       
        private void buttonLoadCharts_Click(object sender, EventArgs e)
        {

            try
            {
                this.chartDays.Series["Expenditure"].Points.Clear();



                List<Finances.Day> DayList = new List<Finances.Day>();
                DayList = Finances.Day.AddDaysToList();

                List<Finances.Day> SortedDayList = DayList.OrderBy(o => o.Date).ToList();


                for (int i = 0; i < SortedDayList.Count; i++)
                {
                    this.chartDays.Series["Expenditure"].Points.AddXY(SortedDayList[i].Date.Date.ToString("dd/MM/yyyy"), SortedDayList[i].Expenditure);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            


          
        }

        private void tabPageReports_Click(object sender, EventArgs e)
        {

        }
    }
}
  