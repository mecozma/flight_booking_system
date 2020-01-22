﻿using System;
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
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairAirports' table. You can move, or remove it, as needed.
            this.cyanairAirportsTableAdapter.Fill(this.cyanairDataSet.CyanairAirports);

            //Calling the methods to load dropdown items in comboboxes
            load_from_airport_comboBox();
           // load_to_airport_comboBox();
            //load_departure_date_comboBox();
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
                    conn.Open();
                    string strSql = "SELECT * FROM CyanairAirports";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, conn));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    from_airport_comboBox.DataSource = ds.Tables[0];
                    from_airport_comboBox.DisplayMember = "Descriptions";
                    from_airport_comboBox.ValueMember = "Airport Codes";
                    
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
            //book_flights.Show();
            //Variable declaration for all the input fields
            String departure_airport = from_airport_comboBox.Text;
            String arrival_airport = to_airport_comboBox.Text;
            String flight_date = departure_date_comboBox.Text;
          // String passengers_no = passengers_no.Value;  // this line wont work

            if (return_flight_checkbox.Checked)
            {
                
                Console.WriteLine("works");
            }
            else
            {

            }
        }

       

       

        
        
       
    }
}
