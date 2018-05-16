namespace Bug_Tracker.Forms.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_load_program = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_assign = new System.Windows.Forms.Button();
            this.program_table = new System.Windows.Forms.DataGridView();
            this.btn_view_user = new System.Windows.Forms.Button();
            this.user_table = new System.Windows.Forms.DataGridView();
            this.txt_language = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_Program = new System.Windows.Forms.Button();
            this.txt_program = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_signout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FastColour = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cause = new System.Windows.Forms.TextBox();
            this.txt_sym = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.program_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.error_table = new System.Windows.Forms.DataGridView();
            this.btn_bug_assign = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_desc1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FastColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txt_desc1);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.btn_bug_assign);
            this.tabPage1.Controls.Add(this.error_table);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btn_load_program);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_assign);
            this.tabPage1.Controls.Add(this.program_table);
            this.tabPage1.Controls.Add(this.btn_view_user);
            this.tabPage1.Controls.Add(this.user_table);
            this.tabPage1.Controls.Add(this.txt_language);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_add_Program);
            this.tabPage1.Controls.Add(this.txt_program);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_signout);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_load_program
            // 
            this.btn_load_program.Location = new System.Drawing.Point(277, 151);
            this.btn_load_program.Name = "btn_load_program";
            this.btn_load_program.Size = new System.Drawing.Size(75, 23);
            this.btn_load_program.TabIndex = 14;
            this.btn_load_program.Text = "Refresh";
            this.btn_load_program.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "List of all projects";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "List of all users";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(294, 376);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(118, 23);
            this.btn_assign.TabIndex = 11;
            this.btn_assign.Text = "Assign to Program";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // program_table
            // 
            this.program_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.program_table.Location = new System.Drawing.Point(0, 177);
            this.program_table.Name = "program_table";
            this.program_table.Size = new System.Drawing.Size(352, 89);
            this.program_table.TabIndex = 10;
            this.program_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.program_table_CellClick);
            // 
            // btn_view_user
            // 
            this.btn_view_user.Location = new System.Drawing.Point(446, 376);
            this.btn_view_user.Name = "btn_view_user";
            this.btn_view_user.Size = new System.Drawing.Size(75, 23);
            this.btn_view_user.TabIndex = 9;
            this.btn_view_user.Text = "Refresh";
            this.btn_view_user.UseVisualStyleBackColor = true;
            this.btn_view_user.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // user_table
            // 
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_table.Location = new System.Drawing.Point(306, 405);
            this.user_table.Name = "user_table";
            this.user_table.Size = new System.Drawing.Size(351, 124);
            this.user_table.TabIndex = 8;
            this.user_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_table_CellClick);
            // 
            // txt_language
            // 
            this.txt_language.Location = new System.Drawing.Point(186, 85);
            this.txt_language.Name = "txt_language";
            this.txt_language.Size = new System.Drawing.Size(143, 20);
            this.txt_language.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Programmming language Used";
            // 
            // btn_add_Program
            // 
            this.btn_add_Program.Location = new System.Drawing.Point(3, 110);
            this.btn_add_Program.Name = "btn_add_Program";
            this.btn_add_Program.Size = new System.Drawing.Size(75, 23);
            this.btn_add_Program.TabIndex = 5;
            this.btn_add_Program.Text = "Add";
            this.btn_add_Program.UseVisualStyleBackColor = true;
            this.btn_add_Program.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_program
            // 
            this.txt_program.Location = new System.Drawing.Point(186, 46);
            this.txt_program.Name = "txt_program";
            this.txt_program.Size = new System.Drawing.Size(143, 20);
            this.txt_program.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Program Name";
            // 
            // btn_signout
            // 
            this.btn_signout.Location = new System.Drawing.Point(805, 0);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(75, 23);
            this.btn_signout.TabIndex = 1;
            this.btn_signout.Text = "Sign out";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_link);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txt_name);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.FastColour);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.txt_cause);
            this.tabPage2.Controls.Add(this.txt_sym);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_browse);
            this.tabPage2.Controls.Add(this.txt_path);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_method);
            this.tabPage2.Controls.Add(this.txt_line);
            this.tabPage2.Controls.Add(this.txt_class);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.program_grid);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register Error";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(243, 522);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(161, 20);
            this.txt_link.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(274, 494);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Source Link";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(243, 451);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(161, 20);
            this.txt_name.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 435);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Image Description";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(797, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Paste The Code Block Here";
            // 
            // FastColour
            // 
            this.FastColour.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FastColour.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.FastColour.BackBrush = null;
            this.FastColour.CharHeight = 14;
            this.FastColour.CharWidth = 8;
            this.FastColour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastColour.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastColour.IsReplaceMode = false;
            this.FastColour.Location = new System.Drawing.Point(496, 64);
            this.FastColour.Name = "FastColour";
            this.FastColour.Paddings = new System.Windows.Forms.Padding(0);
            this.FastColour.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastColour.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastColour.ServiceColors")));
            this.FastColour.Size = new System.Drawing.Size(458, 409);
            this.FastColour.TabIndex = 26;
            this.FastColour.Zoom = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 229);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // txt_cause
            // 
            this.txt_cause.Location = new System.Drawing.Point(170, 262);
            this.txt_cause.Multiline = true;
            this.txt_cause.Name = "txt_cause";
            this.txt_cause.Size = new System.Drawing.Size(161, 45);
            this.txt_cause.TabIndex = 24;
            // 
            // txt_sym
            // 
            this.txt_sym.Location = new System.Drawing.Point(170, 211);
            this.txt_sym.Multiline = true;
            this.txt_sym.Name = "txt_sym";
            this.txt_sym.Size = new System.Drawing.Size(161, 45);
            this.txt_sym.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mention Symptoms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mention Cause";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(337, 310);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(28, 23);
            this.btn_browse.TabIndex = 20;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(170, 313);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(161, 20);
            this.txt_path.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Select Image";
            // 
            // txt_method
            // 
            this.txt_method.Location = new System.Drawing.Point(170, 150);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(161, 20);
            this.txt_method.TabIndex = 17;
            // 
            // txt_line
            // 
            this.txt_line.Location = new System.Drawing.Point(170, 187);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(161, 20);
            this.txt_line.TabIndex = 16;
            this.txt_line.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(170, 122);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(161, 20);
            this.txt_class.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-3, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Enter Class Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Enter Method Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Enter Line Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select program that have bug";
            // 
            // program_grid
            // 
            this.program_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.program_grid.Location = new System.Drawing.Point(3, 52);
            this.program_grid.Name = "program_grid";
            this.program_grid.Size = new System.Drawing.Size(328, 67);
            this.program_grid.TabIndex = 1;
            this.program_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.program_grid_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Error  Here";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(961, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Error Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // error_table
            // 
            this.error_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.error_table.Location = new System.Drawing.Point(458, 85);
            this.error_table.Name = "error_table";
            this.error_table.Size = new System.Drawing.Size(500, 150);
            this.error_table.TabIndex = 16;
            this.error_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.error_table_CellClick);
            // 
            // btn_bug_assign
            // 
            this.btn_bug_assign.Location = new System.Drawing.Point(571, 376);
            this.btn_bug_assign.Name = "btn_bug_assign";
            this.btn_bug_assign.Size = new System.Drawing.Size(100, 23);
            this.btn_bug_assign.TabIndex = 17;
            this.btn_bug_assign.Text = "Assign to Bug";
            this.btn_bug_assign.UseVisualStyleBackColor = true;
            this.btn_bug_assign.Click += new System.EventHandler(this.btn_bug_assign_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(455, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "List of all errors";
            // 
            // txt_desc1
            // 
            this.txt_desc1.Location = new System.Drawing.Point(673, 241);
            this.txt_desc1.Name = "txt_desc1";
            this.txt_desc1.Size = new System.Drawing.Size(281, 20);
            this.txt_desc1.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoEllipsis = true;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(455, 244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(199, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Enter description of bug before assigning";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.program_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FastColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_Program;
        private System.Windows.Forms.TextBox txt_program;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_language;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_view_user;
        private System.Windows.Forms.DataGridView user_table;
        private System.Windows.Forms.DataGridView program_table;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_load_program;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView program_grid;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private FastColoredTextBoxNS.FastColoredTextBox FastColour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_cause;
        private System.Windows.Forms.TextBox txt_sym;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_bug_assign;
        private System.Windows.Forms.DataGridView error_table;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_desc1;
    }
}