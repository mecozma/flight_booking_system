using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cyanair20012020
{
    public partial class search_flights : Form
    {
        //Create a new form
        Form book_flights = new book_flights();
        DataTable sorted_flights_no = new DataTable();

      
        public search_flights()
        {
            InitializeComponent();
        }

        private void cyanairAirportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cyanairAirportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cyanairDataSet);

        }

        private void search_flights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairSchedule' table. You can move, or remove it, as needed.
            this.cyanairScheduleTableAdapter.Fill(this.cyanairDataSet.CyanairSchedule);
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairAirports' table. You can move, or remove it, as needed.
            this.cyanairAirportsTableAdapter.Fill(this.cyanairDataSet.CyanairAirports);

            //Calling the methods to load dropdown items in comboboxes
            load_from_airport_comboBox();
            load_to_airport_comboBox();
            //load_departure_date_comboBox();
        }

        //Generate booking reference number
        private string generate_booking_reference_number(String client_name)
        {
            return string.Format("{0}_{1:N}", client_name, Guid.NewGuid());
        }

        // Populate the departure airport combobox
        private void load_from_airport_comboBox()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");
            //connection string
            String strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    
                    string strSql = "SELECT * FROM CyanairAirports";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    //populate from_airport_combobox
                    from_airport_comboBox.DataSource = ds.Tables[0];
                    from_airport_comboBox.DisplayMember = "Descriptions";
                    from_airport_comboBox.ValueMember = "Airport Codes";

                    conn.Close();
                                                          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The program is terminated with the following error: " + ex);
            }
        }

        // Populate the arrival airport combobox
        private void load_to_airport_comboBox()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");
            //connection string
            String strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

            try
            {
                using (OleDbConnection conn = new OleDbConnection(strCon))
                {
                    conn.Open();
                    string strSql = "SELECT * FROM CyanairAirports";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);

                    //Adapt this code to add an empty entry in the combobox
                  //  DataRow row = dataTable.NewRow();

                   // row["Code"] = "None";

                  //  row["Name"] = "None";

                  //  dataTable.Rows.InsertAt(row, 0);

                  //  comboBox1.DisplayMember = "Name";

                  //  comboBox1.ValueMember = "Code";



                   // comboBox1.DataSource = dataTable;



                    
                    //populate to_airport_combobox
                    to_airport_comboBox.DataSource = ds;
                    to_airport_comboBox.DisplayMember = "Descriptions";
                    to_airport_comboBox.ValueMember = "Airport Codes";

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The program is terminated with the following error: " + ex);
            }
        }

        //This method handles the changes in the combobox
        private void from_airport_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(from_airport_comboBox.SelectedValue.ToString());
        }
            
        //Hide the search_flights form
        private void cancel_search_flights_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void search_flights_btn_Click(object sender, EventArgs e)
        {
            
            //Variable declaration for all the input fields
            String departure_airport = from_airport_comboBox.SelectedValue.ToString();
            String arrival_airport = to_airport_comboBox.SelectedValue.ToString();
            String flight_dates = flight_date.Value.ToShortDateString();
          // String passengers_no = passengers_no.Value;  // this line wont work
            Console.WriteLine("Departure airport: " + departure_airport + "code: " + from_airport_comboBox.SelectedValue.ToString());
            Console.WriteLine("Arrival airport: " + arrival_airport + "code" + to_airport_comboBox.SelectedValue.ToString());
            Console.WriteLine("departure airpoty code!!!!: " + departure_airport);

        //Variable used in the ticket booking section
            //assign values to the departure and arriving disabled textboxes
            departing_inactive_comboBox.Text = from_airport_comboBox.Text;
            arriving_inactive_checkbox.Text = to_airport_comboBox.Text;
            //date_inactive_checkbox.Text = flight_dates;
           
            //test booking reference
            String reference_number = generate_booking_reference_number("Robocop");
            MessageBox.Show(reference_number);

            if (departure_airport != arrival_airport) // && flight_date.Value.Date >= DateTime.Today   add this here
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");
                //connection string
                String strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

                try
                {
                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open();
                        string strSql = "SELECT * FROM CyanairSchedule WHERE  Date LIKE '%" +
                            flight_dates + "%' AND Departing LIKE '%" + departure_airport +
                            "%' AND Arriving LIKE '%" + arrival_airport +
                            "%' ORDER BY Time DESC;";
                        OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                        
                        
                  
                        // Create a new dataTable that will be filled with the data processed/filtered by the myAdapter from the database
                        DataTable filteredData = new DataTable();
                        //The filteredData table is filled with the data processed by the myAdapter
                        adapter.Fill(filteredData);
                        //The dataGridView added to the search_flights form is populated with data
                        filtered_flights.DataSource = filteredData;

                        //Assign flightnumber to the flight ckeckbox in order to create the ticket
                       flight_no_comboBox.DataSource = filteredData;
                       flight_no_comboBox.DisplayMember = "Flight No";
                       flight_no_comboBox.ValueMember = "Flight No";

                     


                       //time_inactive_checkBox.Text = filteredData.
                       //time_inactive_checkBox.Text = "Time";

                        //Loop through table to find the selected flight
                       sorted_flights_no = filteredData;
                      

                      

                        //the connection to the database id closed
                        conn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The program is terminated with the following error: " + ex);
                }

            }
            else
            {
                MessageBox.Show("Oops! One of the fields is empty.");
            }
        }

       private void flight_no_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String flight_time = "";
            String flight_date = "";
            //time_inactive_checkBox.Text = flight_time;
           // date_inactive_checkbox.Text = flight_date;
           foreach (DataRow row in sorted_flights_no.Rows)
            {
                time_inactive_checkBox.Text = row["Time"].ToString().Substring(10);

                //flight_date = row["Date"];
               // Console.WriteLine(flight_no_comboBox.DisplayMember == row["Flight no"].ToString());
                Console.WriteLine(row["Time"].ToString().Substring(10));
                Console.WriteLine("222 " + flight_date);
                break;
            }
           
        }

       private void filtered_flights_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       } 
    }
}
