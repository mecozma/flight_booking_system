using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Cyanair20012020
{
    public partial class book_flight : Form
    {
        public book_flight()
        {
            InitializeComponent();
        }

        private void cyanairReservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cyanairReservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cyanairDataSet);

        }

        private void book_flight_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairReservation' table. You can move, or remove it, as needed.
            this.cyanairReservationTableAdapter.Fill(this.cyanairDataSet.CyanairReservation);


            cyanairReservationBindingSource.AddNew();
            cyanairReservationTableAdapter.Update(cyanairDataSet);
           


            flight_NoTextBox.Text = search_flights.flight_no;
            departingTextBox.Text = search_flights.departing;
            arrivingTextBox.Text = search_flights.arriving;
            dateTextBox.Text = search_flights.date;
            timeTextBox.Text = search_flights.time;
            booking_referenceTextBox.Text = generate_booking_reference_number(flight_NoTextBox.Text).Substring(0, 15);
            seat_ClassTextBox.Text = "Economy";


            
             

            

        }

        //the following three methods listen to changes in the radio buttons status and assign their value to a variable
        private void economy_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            seat_ClassTextBox.Text = economy_radioButton.Text;
        }

        private void business_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            seat_ClassTextBox.Text = business_radioButton.Text;
        }

        private void first_class_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            seat_ClassTextBox.Text = first_class_radioButton.Text;
        }


        //Generate booking reference number
        private string generate_booking_reference_number(String flight_number)
        {
            return string.Format("{0}_{1:N}", flight_number, Guid.NewGuid());
        }

        private void generate_ticket_button_Click(object sender, EventArgs e)
        {
            //Regular expression to test if the email format is valid
            var regex = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}";

            //The email is tested agains the regex
            var match = Regex.Match(emailTextBox.Text, regex, RegexOptions.IgnoreCase);

            try
            {
                //The if statement tests if none of the form fields are empty
                if (flight_NoTextBox.Text != "" && passenger_Full_NameTextBox.Text != "" &&
                   passport_NoTextBox.Text != "" && match.Success )
                {
                    this.Validate();
                    this.cyanairReservationBindingSource.EndEdit();
                    this.cyanairReservationTableAdapter.Update(this.cyanairDataSet.CyanairReservation);
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("No fields left empty!");
                }


            }
            catch (System.Exception exceptionName)
            {
                MessageBox.Show("Update failed \n:" + exceptionName);
            }
        }

        private void close_form_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       
    }
}
