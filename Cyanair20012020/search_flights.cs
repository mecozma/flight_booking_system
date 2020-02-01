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
        Form book_flight = new book_flight();

        //New datatable instance
        DataTable sorted_flights_no = new DataTable();

        //The following global variables will be used to pass the flight data to the book_flight form
        public static string flight_no = "";
        public static string departing  = ""; 
        public static string arriving  = "";
        public static string date = "";
        public static string time = "";
        public static string economy_class = "";
        public static string business_class = "";
        public static string first_class = "";
        public static string flight_duration = "";

        //Variable used to change the description of the selected flight - outbound, inbound and extra flight
        public static String flight_identifier = "Outbound flight";

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
            flight_direction.Text = flight_identifier;
           

          /*  if (flight_identifier == "Outbound flight" || flight_identifier == "Extra flight")
            {
                flight_direction.Text = flight_identifier;
                //Calling the methods to load dropdown items in comboboxes
                load_from_airport_comboBox();
                load_to_airport_comboBox();
                //load_departure_date_comboBox();
            }

            if (flight_identifier == "Inbound flight")
            {
                from_airport_comboBox.DisplayMember = arriving;
                from_airport_comboBox.ValueMember = arriving;
                from_airport_comboBox.Enabled = false;
                to_airport_comboBox.DisplayMember = departing;
                to_airport_comboBox.DisplayMember = departing;
                to_airport_comboBox.Enabled = false;
            }

           */
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
                    //sql query string
                    string strSql = "SELECT * FROM CyanairAirports";
                    //New data adapter
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    //New dataset
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    //populate from_airport_combobox
                    from_airport_comboBox.DataSource = ds.Tables[0];
                    from_airport_comboBox.DisplayMember = "Descriptions";
                    from_airport_comboBox.ValueMember = "Airport Codes";
                    //database connection is closed
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
                    //connection to the database and filling the adapter with the queried data
                    conn.Open();
                    string strSql = "SELECT * FROM CyanairAirports";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataTable ds = new DataTable();
                    adapter.Fill(ds);
                    
                    //populate to_airport_combobox
                    to_airport_comboBox.DataSource = ds;
                    //The displayed value in the dropbox shows the airport names
                    to_airport_comboBox.DisplayMember = "Descriptions";
                    //The airport code assigned to each airport
                    to_airport_comboBox.ValueMember = "Airport Codes";
                    //Database connection closed
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The program is terminated with the following error: " + ex);
            }
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

            //condition to check if the departure anr arrival airport are different and if the selected date not in the past
            if (departure_airport != arrival_airport && flight_date.Value.Date >= DateTime.Today) 
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", @"\\prod\ServiceRequests");
                //connection string
                String strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

                try
                {
                    using (OleDbConnection conn = new OleDbConnection(strCon))
                    {
                        conn.Open();
                        //Sql query string
                        string strSql = "SELECT * FROM CyanairSchedule WHERE  Date LIKE '%" +
                            flight_dates + "%' AND Departing LIKE '%" + departure_airport +
                            "%' AND Arriving LIKE '%" + arrival_airport +
                            "%';";
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

                        /*assigned the value of the filtered data table to the global variable in order to be able
                         * to reuse the table globaly
                         */
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

        /*
         * This method is an event listener who listens to changes in the flight_no_combobox 
        and identifys the specific row of data in the sorted_flights_no table
         * */
        private void flight_no_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //the  String variable is initiated with the flight_combo_box text value
            String selected_flight = flight_no_comboBox.Text;

            //Assgn values to the global variables
            flight_no = selected_flight;
           


            //Loop through the filtered data in order to find the row selected in the combobox
            foreach (DataRow row in sorted_flights_no.Rows)
            {
                if (row["Flight No"].ToString() == selected_flight)
                {
                    departing = row["Departing"].ToString();
                    arriving = row["Arriving"].ToString();
                    date = row["Date"].ToString().Substring(0,11);
                    time = row["Time"].ToString().Substring(10);
                    economy_class = row["Economy"].ToString();
                    business_class = row["Business"].ToString();
                    first_class = row["First"].ToString();
                    flight_duration = row["Duration"].ToString();

                    break;
                }
            }

            //Test if the seat type is available
            if (economy_class == "0" && business_class == "0" && first_class == "0")
            {
                MessageBox.Show("Flight fully booked. Please choose a different flight!");
            }
            
        }

        //Event listener
        private void open_book_flight_form_Click(object sender, EventArgs e)
        {
            //Flight fully booked restriction logic
             if (economy_class == "0" && business_class == "0" && first_class == "0")
            {
                MessageBox.Show("Flight fully booked. Please choose a different flight!");
            } else if (flight_no_comboBox.Text == ""){
                MessageBox.Show("There is no available flight on this date");

            }
             else
             {
                 book_flight.Show();
             }
            
        }
      
    }
}
