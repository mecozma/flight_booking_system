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
    public partial class admin_search : Form
    {
        //OleDb declaration
        OleDbConnection connection;

        //Connection string declaration
        String  connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

        public admin_search()
        {
            InitializeComponent();
        }

        private void admin_search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairReservation' table. You can move, or remove it, as needed.
            this.cyanairReservationTableAdapter.Fill(this.cyanairDataSet.CyanairReservation);
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairSchedule' table. You can move, or remove it, as needed.
            this.cyanairScheduleTableAdapter.Fill(this.cyanairDataSet.CyanairSchedule);

        }

        //Searach button event listener
        private void btn_search_Click(object sender, EventArgs e)
        {
            // This varable is assigned the textbol value
            String reference_no_textBox_value = reference_no_textBox.Text;
            //variable declaration 
            String queryString;
            //A new oledb connection is asigned to the connection variable
            connection = new OleDbConnection(connectionString);
            // The oledb connection is open
            connection.Open();

            try
            {
                //This condition checks if the text box is not empty
                if (reference_no_textBox_value != "")
                {
                    //the queryString selects all the rables from the database that match the booking reference field with the text in the textbox
                    queryString = "SELECT * FROM CyanairReservation WHERE `Booking reference` LIKE '%" + reference_no_textBox_value + "%';";
                    connection = new OleDbConnection(connectionString);
                    //Oledb dataadapter declaration and assignment
                    OleDbDataAdapter myAdapter;
                    myAdapter = new OleDbDataAdapter(queryString, connection);
                    //A new dataTable instance
                    DataTable filteredData = new DataTable();
                    //The datatable is filled with data
                    myAdapter.Fill(filteredData);
                    //the gridview is populated with the filtered table 
                    dataGridView1.DataSource = filteredData;
                    //The database connection is closed
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Oops! No reference number typed in!");
                }


            }
            catch (System.Exception exceptionName)
            {
                MessageBox.Show("Search failed with the following error \n:" + exceptionName);
            }

           

        }

        //Button event listener
        private void btn_close_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
        }
    }
}
