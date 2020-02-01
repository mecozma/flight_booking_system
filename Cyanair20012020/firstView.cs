using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyanair20012020
{
    public partial class firstView : Form
    {
       //Create new form
        Form loginForm = new loginForm();
        Form search_flights = new search_flights();
            
        public firstView()
        {
            InitializeComponent();
        }

        //admin user button event listener
        private void adminUser_Click(object sender, EventArgs e)
        {
            //on click show the login form
            loginForm.Show();
            
        }

        // button event listener
        private void book_flights_button_Click(object sender, EventArgs e)
        {
            //Display seatch_flights form
            search_flights.Show();
        }

       
    }
}
