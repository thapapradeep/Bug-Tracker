using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bug_Tracker.Forms;
using Bug_Tracker.Forms.Views;
using Bug_Tracker.Forms.DB;
using Bug_Tracker.Forms.Model;
using Bug_Tracker.Forms.DAO;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace Bug_Tracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_sign_in_Click(object sender, EventArgs e)
        {
            String user = txt_user.Text;
            String pass = txt_pass.Text;
            

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please Enter Username and Password Correctly");
            }
         
            else
            {
                UserTable us = new UserTable()
                {
                    username = user,
                    password = pass
                };
                UserDAO usdao = new UserDAO();
                OracleDataReader dr = usdao.UserLogin(us);
                if (dr.HasRows)
                {
                    int user_id=0;
                    String post="1";
                    while (dr.Read()) {
                        user_id = dr.GetInt32(0);
                         post = dr.GetString(1);
                        
                    }
                    dr.Dispose();
                    Dashboard db = new Dashboard(user_id, post);
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login unSuccessful");
                }

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
