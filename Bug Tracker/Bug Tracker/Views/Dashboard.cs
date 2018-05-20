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
using System.Diagnostics;

namespace Bug_Tracker.Forms.Views
{
    public partial class Dashboard : Form
    {

        int id = 0;
        int Tbl_data_error_id = 0;
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
            txt_source1.Language = FastColoredTextBoxNS.Language.CSharp;
            this.id = id;
            this.post = post;
            
            if (post == "Admin")
            {
                label1.Text = "Welcome" + " " + post;
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage4);
                cmb_status.Enabled = false;
                btn_update.Enabled = false;
                load_programs();
                load_users();
                loadErrors();

            }
            else if (post == "Programmer")
            {
                lbl_programmer.Text = "Welcome" + " " + post;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(history_page);
                loadErrors();
                load_Programmer_bugs();

            }
            else
            {
                lbl_tester.Text = "Welcome" + " " + post;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(history_page);
                cmb_status.Enabled = false;
                btn_update.Enabled = false;
                loadErrors();
                load_tester_bugs();


            }
                
           
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
            Program_table.DataSource = bsource;
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
            User_table.DataSource = bsource;
            data.Update(dataset);
        }
        public void load_Programmer_bugs()
        {
            BugDAO us = new BugDAO();
            DataTable data = us.GetProgrammerBugs(id);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = data;
            Tbl_grid.DataSource = bsource;
        }

        public void load_tester_bugs()
        {
            BugDAO us = new BugDAO();
            DataTable data = us.GetTesterBugs(id);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = data;
            Tester_bug.DataSource = bsource;
        }

        public void loadErrors()
        {
            BugDAO us = new BugDAO();
            OracleDataAdapter data = us.GetBugs();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            Error_table.DataSource = bsource;
            Tbl_grid1.DataSource = bsource;
            Tbl_grid2.DataSource = bsource;
            data.Update(dataset);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            load_users();
           
        }

        private void user_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {

                String value = User_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                user_id = int.Parse(value);

            }

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
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
                String value = Program_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                program_id = int.Parse(value);
            }

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
            Program_grid.DataSource = bsource;
            data.Update(dataset);
        }

        private void program_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex != -1)
            {
                String value = Program_table.Rows[e.RowIndex].Cells[0].Value.ToString() ;
                program_id = int.Parse(value);
            }
            else
            {
                MessageBox.Show("Please select row");
            }
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

            if(String.IsNullOrEmpty(class_name))
            {

                
                MessageBox.Show("Please Provide Valid Information");
            }
            else if ( String.IsNullOrEmpty(method))
            {
                MessageBox.Show("Please Provide Valid mathod name");
            }
            else if (String.IsNullOrEmpty(symptom))
            {
                MessageBox.Show("Please Provide Valid Symptom");
            }
            else if (String.IsNullOrEmpty(cause))
            {
                MessageBox.Show("Please Provide Valid Cause");
            }
            else if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please Provide Valid Path");
            }
            else if (String.IsNullOrEmpty(img_desc))
            {
                MessageBox.Show("Please Provide Valid Image Description");
            }
            else if (program_id==0)
            {
                MessageBox.Show("Please Select program from Table");
            }
            else if (String.IsNullOrEmpty(source_link))
            {
                MessageBox.Show("Please Provide Valid Source Link");
            }
            else if (String.IsNullOrEmpty(code_block))
            {
                MessageBox.Show("Please Provide Error Code");
            }

            else
            {
                Bug bug = new Bug()
                {
                    program = program_id,
                    class_name = class_name,
                    method_name = method,
                    line_number = linee,
                    found_by = id

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
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
                String value = Error_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                bug_id = int.Parse(value);
            }
          
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

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void tbl_data_error_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            BugDAO us = new BugDAO();
            OracleDataAdapter data = us.GetBugs();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
           Tbl_data_error.DataSource = bsource;
            data.Update(dataset);

        }

        private void tbl_data_error_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
                BugDAO bg = new BugDAO();
                String value = Tbl_data_error.Rows[e.RowIndex].Cells[0].Value.ToString();
                Tbl_data_error_id = int.Parse(value);
                DataTable dr = bg.GetAllBugs(Tbl_data_error_id);
                if (dr.Rows.Count > 0)
                {

                    txt_program_name.Text = "Program:  " + dr.Rows[0][1].ToString();
                    txt_class_name.Text = "Class:  " + dr.Rows[0][2].ToString();
                    txt_method_name.Text = "Method:  " + dr.Rows[0][3].ToString();
                    txt_symptom1.Text = "Symptoms:  " + dr.Rows[0][6].ToString();
                    txt_cause1.Text = "Cause:  " + dr.Rows[0][7].ToString();
                    txt_date1.Text = " Date:  " + dr.Rows[0][5].ToString();
                    txt_description1.Text = "Image name:  " + dr.Rows[0][9].ToString();
                    txt_found_by.Text = "Found by: " + dr.Rows[0][12].ToString();
                    linkLabel1.Text = dr.Rows[0][10].ToString();
                    txt_source1.Text = dr.Rows[0][11].ToString();

                    byte[] imgData = (byte[])dr.Rows[0][8];
                    MemoryStream ms = new MemoryStream();
                    ms.Write(imgData, 0, imgData.Length);
                    Bitmap bmp = new Bitmap(ms, false);
                    pic_desc.Image = bmp;
                    ms.Dispose();

                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            String status = cmb_status.Text;
            String code_block = txt_source1.Text;
            BugHistory bg = new BugHistory()
            {
                bug_id = Tbl_data_error_id,
                user_id = id,
                status = status,
                code_block = code_block
             
            };
            BugHistoryDAO bug = new BugHistoryDAO();
            int done = bug.Insert(bg);
            if (done != 0)
            {
                MessageBox.Show("Updated");
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int type = 0;
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
                int done = users.Insert(us);
                if (done != 0)
                {
                    MessageBox.Show("user registered");
                    ClearUserFields();
                    
                   
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }

            }



            }

        public void ClearUserFields()
        {
            Txt_fname.Text = "";
            txt_lname.Text = "";
            Txt_Con.Text = "";
            Txt_add.Text = "";
            Txt_user.Text = "";
            Txt_pass1.Text = "";
            Txt_pass2.Text = "";
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            BugDAO us = new BugDAO();
            OracleDataAdapter data = us.GetBugs();
            DataTable dataset = new DataTable();
            data.Fill(dataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dataset;
            BugView.DataSource = bsource;
            data.Update(dataset);

            

        }

        private void tbl_bug_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex== -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
             
                String value = BugView.Rows[e.RowIndex].Cells[0].Value.ToString();
                bug_id = int.Parse(value);

                BugDAO us = new BugDAO();
                DataTable data = us.GetBugs(bug_id);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = data;
                Tbl_data_history.DataSource = bsource;
            }
            
          
        }

        private void tbl_data_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
                String value = Tbl_data_history.Rows[e.RowIndex].Cells[0].Value.ToString();
                int bug_id1 = int.Parse(value);


                BugHistory bg = new BugHistory()
                {
                    id = bug_id1

                };

                BugHistoryDAO bug = new BugHistoryDAO();
                String code = bug.GetCodeBlock(bg);
                fast1.Text = code;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Program_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                MessageBox.Show("You Cannot Select This Row");
            }
            else
            {
                String id = Program_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                program_id = int.Parse(id);
            }
        }

        private void btn_load_program_Click(object sender, EventArgs e)
        {
            load_programs();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Login ls = new Login();
            ls.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login ls = new Login();
            ls.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            PasswordUpdate pu = new PasswordUpdate(id);
            pu.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PasswordUpdate pu = new PasswordUpdate(id);
            pu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PasswordUpdate pu = new PasswordUpdate(id);
            pu.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkLabel1.LinkVisited = true;
        }
    }
}
