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
    public partial class admin_actions : Form
    {
        //Declare and instantiate a new admin_search form
        Form admin_search = new admin_search();

        public admin_actions()
        {
            InitializeComponent();
        }

        private void admin_actions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cyanairDataSet.CyanairSchedule' table. You can move, or remove it, as needed.
            this.cyanairScheduleTableAdapter.Fill(this.cyanairDataSet.CyanairSchedule);

        }

        //Show the admin search form
        private void btn_search_flight_Click(object sender, EventArgs e)
        {
            admin_search.Show();
        }

        //Update flight event handler
        private void btn_update_flight_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cyanairScheduleBindingSource.EndEdit();
                this.cyanairScheduleTableAdapter.Update(this.cyanairDataSet.CyanairSchedule);
                MessageBox.Show("Flight updated sucessfully!");
            }
            catch (System.Exception exceptionName)
            {
                MessageBox.Show("Flight update failed with the following error: " + exceptionName);
            }
        }
        
        //Add flight method
        private void btn_add_flight_Click(object sender, EventArgs e)
        {
            cyanairScheduleBindingSource.AddNew();
        }

        //Delete flight method
        private void btn_delete_flight_Click(object sender, EventArgs e)
        {
            cyanairScheduleBindingSource.RemoveCurrent();
        }

        //Cancel changes method
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cyanairScheduleTableAdapter.Fill(cyanairDataSet.CyanairSchedule);
        }

        //Close the form
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }        
    }
}
