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
    public partial class loginForm : Form
    {
        Form admin_actions = new admin_actions();
       
        public loginForm()
        {
            InitializeComponent();
        }

        //Button event listener
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        //Button event listener
        private void btn_login_Click(object sender, EventArgs e)
        {
         
            String username = "admin";
            String password = "admin";
            String username_value;
               username_value = username_textbox.Text;
               String password_value;
               password_value = password_textbox.Text;
            //Condition to verify if the inserted credentials are correct
            if (username_value != username && password_value != password) {
                MessageBox.Show("Wrong Password");
            }
            else
            {
                //Show spinner and close the form
                Cursor.Current = Cursors.WaitCursor;
                this.Hide();
               
                //Show the admin actions form and display the welcome message
                admin_actions.Show();
                MessageBox.Show("Hello Admin user. You are authenticated and able to access your account");
            } 
           
        }
    }
}
