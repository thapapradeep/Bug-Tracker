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
            Console.WriteLine("hello");
            ConnectToDB cd = new ConnectToDB();


            if (user.Equals(null))
            {
                MessageBox.Show("Please Enter Username");
            }
            else if (pass.Equals(null))
            {
                MessageBox.Show("Please Enter Password");
            }
            else
            {
                OracleConnection con = ConnectToDB.Connect();
                con.Open();
                OracleCommand command= con.CreateCommand();
                command.CommandText= "select u.user_id, t.type_name from ASE.user_table u, ASE.user_type t where t.type_id = u.type_id and username =:username and password =:password";


                OracleParameter op = new OracleParameter();
                command.Parameters.Add(":username", user);
                command.Parameters.Add(":password", pass);



                OracleDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    int user_id=0;
                    String post="1";
                    while (dr.Read()) {
                        user_id = dr.GetInt32(0);
                         post = dr.GetString(1);
                        
                    }
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
            Signup sn = new Signup();
            sn.Show();
            this.Hide();
        }
    }
}
