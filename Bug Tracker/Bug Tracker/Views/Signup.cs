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

namespace Bug_Tracker.Forms
{
    public partial class Signup : Form
    {

        int type;
        public Signup()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            
            String fname = Txt_fname.Text;
            String lname = txt_lname.Text;
            String con = Txt_Con.Text;
            String add = Txt_add.Text;
            String user = Txt_user.Text;
            String pass1 = Txt_pass1.Text;
            String pass2 = Txt_pass2.Text;
            String post = cmb_post.Text;

            if (post == "Admin")
            {
                type = 1;
            }
            else if (post == "Tester")
            {
                type = 2;
            }
            else if (post == "Developer")
            {
                type = 3;
            }


            if (string.IsNullOrEmpty(fname))
            {
                MessageBox.Show("Please Enter First Name");
            }


            else if (string.IsNullOrEmpty(lname))
            {
                MessageBox.Show("Please Enter Lastname");
            }


            else if (string.IsNullOrEmpty(con))
            {
                MessageBox.Show("Please Enter Contact No");
            }
            else if (string.IsNullOrEmpty(add))
            {
                MessageBox.Show("Please Enter Address");
            }
            else if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (string.IsNullOrEmpty(pass1))
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (string.IsNullOrEmpty(pass2))
            {
                MessageBox.Show("Please Enter password");
            }
            
            else if (pass1 != pass2)
            {
                MessageBox.Show("Password Do not Math");
            }
            else
            {
                UserTable us = new UserTable()
                {
                    address = add,
                    contact = con,
                    fname = fname,
                    lname = lname,
                    username = user,
                    password = pass1,
                    type_id = type 
                };
                UserDAO users = new UserDAO();
                int done=users.Insert(us);
                if (done != 0)
                {
                    MessageBox.Show("user registered");
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }


            }

        }
    }
}
