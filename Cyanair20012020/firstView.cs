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

        private void adminUser_Click(object sender, EventArgs e)
        {
            //on click show the login form
            loginForm.Show();
            //on click close the curent form
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_flights.Show();
        }
    }
}
