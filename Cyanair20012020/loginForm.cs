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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int count = 0;
            String username = "admin";
            String password = "admin";
            String username_value;
               username_value = username_textbox.Text;
               String password_value;
               password_value = password_textbox.Text;
            
            if (username_value != username && password_value != password) {
                MessageBox.Show("Wrong Password");
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                this.Close();
                MessageBox.Show("Hello Admin user. You are authenticated and able to access your account");
                admin_actions.Show();
            } 
           
        }
    }
}
