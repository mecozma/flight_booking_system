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
        OleDbConnection connection;

        String  connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=cyanair.mdb";

        public admin_search()
        {
            InitializeComponent();
        }

        private void cyanairScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cyanairScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cyanairDataSet);

        }

       

        private void admin_search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairReservation' table. You can move, or remove it, as needed.
            this.cyanairReservationTableAdapter.Fill(this.cyanairDataSet.CyanairReservation);
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairSchedule' table. You can move, or remove it, as needed.
            this.cyanairScheduleTableAdapter.Fill(this.cyanairDataSet.CyanairSchedule);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String reference_no_textBox_value = reference_no_textBox.Text;
            String queryString;
            connection = new OleDbConnection(connectionString);
            connection.Open();

            try
            {

                if (reference_no_textBox_value != "")
                {
                    queryString = "SELECT * FROM CyanairReservation WHERE `Booking reference` LIKE '%" + reference_no_textBox_value + "%';";
                    connection = new OleDbConnection(connectionString);
                    OleDbDataAdapter myAdapter;
                    myAdapter = new OleDbDataAdapter(queryString, connection);
                    DataTable filteredData = new DataTable();
                    myAdapter.Fill(filteredData);
                    dataGridView1.DataSource = filteredData;
                    connection.Close();
                    MessageBox.Show("works");
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
