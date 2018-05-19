using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bug_Tracker.Forms.Model;
using Bug_Tracker.Forms.DAO;


namespace Bug_Tracker.Forms.Views
{
    public partial class PasswordUpdate : Form
    {
        int id = 0;
        public PasswordUpdate( int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cur_pass = txt1.Text;
            String pass1 = txt2.Text;
            String pass2 = txt3.Text;

            if(String.IsNullOrEmpty(cur_pass) || String.IsNullOrEmpty(pass1) || String.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Please Provide valid Information");
            }
            else if (pass1 != pass2)
            {
                MessageBox.Show("Password donot match, please try again");


            }
            else
            {
             
                UserTable user = new UserTable()
                {
                    user_id = id,
                    password = pass1
                };
                UserDAO us = new UserDAO();
                int done = us.Update(user);
                MessageBox.Show(done.ToString());
                if (done != 0)
                {
                    MessageBox.Show("Successsfully Updated");
                    this.Dispose(); ;
                }
                else
                {
                    MessageBox.Show("Something went Wrrong");
                }
            }

        }
    }
}
