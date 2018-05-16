using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker.Forms.Views
{
    public partial class Dashboard : Form
    {

        int id = 0;
        String post;
        public Dashboard( int id, string post)
        {
            InitializeComponent();
            
            this.id = id;
            this.post = post;
            label1.Text="Welcome" + " " + post;
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Login ls = new Login();
            ls.Show();
            this.Dispose();
        }
    }
}
