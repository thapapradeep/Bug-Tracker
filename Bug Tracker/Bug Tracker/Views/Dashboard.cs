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
using System.IO;

namespace Bug_Tracker.Forms.Views
{
    public partial class Dashboard : Form
    {

        int id = 0;
        byte[] imgdata;
        int bug_id = 0;
        int user_id = 0;
        String post;
        ProgramAuthors pa;
        int program_id = 0;
        public Dashboard(int id, string post)
        {
            InitializeComponent();

            FastColour.Language = FastColoredTextBoxNS.Language.CSharp;
            this.id = id;
            this.post = post;
            label1.Text = "Welcome" + " " + post;

            load_programs();
            load_users();
            loadErrors(); 
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
        public void loadErrors()
        {
            BugDAO us = new BugDAO();
            OracleDataAdapter data = us.GetBugs();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            error_table.DataSource = bsource;
            data.Update(dataset);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            load_users();
           
        }

        private void user_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            String value = user_table.Rows[e.RowIndex].Cells[0].Value.ToString();
            user_id = int.Parse(value);
          


        }

        private void btn_assign_Click(object sender, EventArgs e)
        {
            ProgramDAO pro = new ProgramDAO();
            pa = new ProgramAuthors()
            {

                program_id = program_id,
                user_id = user_id
            };
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
            program_id = int.Parse(value);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            txt_path.Text = ofd.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(ofd.FileName);



            FileStream file = new FileStream(txt_path.Text, FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(file);
            FileInfo fs = new FileInfo(txt_path.Text);
            imgdata = br.ReadBytes((int)fs.Length);
            file.Close();
            br.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgramDAO us = new ProgramDAO();
            OracleDataAdapter data = us.GetPrograms();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            program_grid.DataSource = bsource;
            data.Update(dataset);
        }

        private void program_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String value = program_table.Rows[e.RowIndex].Cells[0].Value.ToString();
            program_id = int.Parse(value);
        }

        public void ClearFields()
        {
            txt_class.Text = "";
            txt_method.Text = "";
            txt_line.Text = "";
            txt_path.Text = "";
            txt_sym.Text = "";
            txt_cause.Text = "";
            txt_name.Text = "";
            txt_link.Text = "";
            FastColour.Text = "";
            pictureBox1.Image = null;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String class_name = txt_class.Text;
            String method = txt_method.Text;
            String line = txt_line.Text;
           int linee = int.Parse(line);
            String path = txt_path.Text;
            String symptom = txt_sym.Text;
            String cause = txt_cause.Text;
            String img_desc = txt_name.Text;
            String code_block = FastColour.Text;
            String source_link = txt_link.Text;

            if(String.IsNullOrEmpty(class_name)|| String.IsNullOrEmpty(method) || String.IsNullOrEmpty(symptom) || String.IsNullOrEmpty(cause) || String.IsNullOrEmpty(path) || String.IsNullOrEmpty(img_desc) || program_id==0 || String.IsNullOrEmpty(code_block) || String.IsNullOrEmpty(source_link))
            {

                
                MessageBox.Show("Please Provide Valid Information");
            }
            else{
                Bug bug = new Bug()
                 {
                     program = program_id,
                     class_name = class_name,
                     method_name=method,
                     line_number=linee

                 };
                 BugDAO bu = new BugDAO();
                 bug_id = bu.Insert(bug);
                 Console.WriteLine(bug_id);

                BugDetails bugd = new BugDetails()
                {
                    bug_id = bug_id,
                    image = imgdata,
                    symptom = symptom,
                    cause = cause,
                    image_name = img_desc,
                    code_block = code_block,
                    source_link = source_link

                };
                BugDetailsDAO db = new BugDetailsDAO();

                int done = db.Insert(bugd);
                if (done != 0 && bug_id != 0)
                {
                    MessageBox.Show("inserted");
                    ClearFields();
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void error_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String value = error_table.Rows[e.RowIndex].Cells[0].Value.ToString();
             bug_id = int.Parse(value);
          
        }

        private void btn_bug_assign_Click(object sender, EventArgs e)
        {
            String desc = txt_desc1.Text;
            UserAssign us = new UserAssign()
            {
                bug_id = bug_id,
                user_id = user_id,
                assigned_by = id,
                description=desc
            };
            UserAssignDAO usd = new UserAssignDAO();
            int done = usd.Insert(us);
            if (done != 0)
            {
                MessageBox.Show("User Assigned to bug");
                txt_desc1.Text = "";
            }

        }
    }
}
