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
using Oracle.ManagedDataAccess.Client;
using Bug_Tracker.Forms.DB;

namespace Bug_Tracker.Forms.Views
{
    public partial class Dashboard : Form
    {

        int id = 0;
        String post;
        ProgramAuthors pa;
        int program_id = 0;
        public Dashboard(int id, string post)
        {
            InitializeComponent();

            this.id = id;
            this.post = post;
            label1.Text = "Welcome" + " " + post;

            load_programs();
            load_users();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Login ls = new Login();
            ls.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String program = txt_program.Text;
            String language = txt_language.Text;
            if (String.IsNullOrEmpty(program) || String.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please provide full information");
            }
            else {
                Programs programs = new Programs()
                {
                    program_name = program,
                    language = language
                };

                ProgramDAO pro = new ProgramDAO();
                int done = pro.Insert(programs);
                if (done != 0)
                {
                    MessageBox.Show("New Program Created" + " " + done);
                    load_programs();


                }

            }
        }
        public void load_programs()
        {

            ProgramDAO us = new ProgramDAO();
            OracleDataAdapter data = us.GetPrograms();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            program_table.DataSource = bsource;
            data.Update(dataset);
        }
        public void load_users()
        {
            UserDAO us = new UserDAO();
            OracleDataAdapter data = us.GetUsers();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            user_table.DataSource = bsource;
            data.Update(dataset);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            load_users();
           
        }

        private void user_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            String value = user_table.Rows[e.RowIndex].Cells[0].Value.ToString();
            int user_id = int.Parse(value);
             pa = new ProgramAuthors()
            {

                program_id=program_id,
                user_id=user_id
            };


        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            ProgramDAO pro = new ProgramDAO();
            int insert = pro.AssignUsers(pa);
            if (insert != 0)
            {
                MessageBox.Show("Author Added");
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void program_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String value = program_table.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(value);
            program_id = int.Parse(value);


        }
    }
}
