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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_signout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_program = new System.Windows.Forms.TextBox();
            this.btn_add_Program = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_language = new System.Windows.Forms.TextBox();
            this.user_table = new System.Windows.Forms.DataGridView();
            this.btn_view_user = new System.Windows.Forms.Button();
            this.program_table = new System.Windows.Forms.DataGridView();
            this.btn_assign = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_load_program = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_table)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(969, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(961, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Panel";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register Error";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(961, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Error Details";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // txt_program
            // 
            this.txt_program.Location = new System.Drawing.Point(186, 46);
            this.txt_program.Name = "txt_program";
            this.txt_program.Size = new System.Drawing.Size(143, 20);
            this.txt_program.TabIndex = 4;
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
            // txt_language
            // 
            this.txt_language.Location = new System.Drawing.Point(186, 85);
            this.txt_language.Name = "txt_language";
            this.txt_language.Size = new System.Drawing.Size(143, 20);
            this.txt_language.TabIndex = 7;
            // 
            // user_table
            // 
            this.user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_table.Location = new System.Drawing.Point(0, 343);
            this.user_table.Name = "user_table";
            this.user_table.Size = new System.Drawing.Size(352, 124);
            this.user_table.TabIndex = 8;
            this.user_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_table_CellClick);
            // 
            // btn_view_user
            // 
            this.btn_view_user.Location = new System.Drawing.Point(277, 314);
            this.btn_view_user.Name = "btn_view_user";
            this.btn_view_user.Size = new System.Drawing.Size(75, 23);
            this.btn_view_user.TabIndex = 9;
            this.btn_view_user.Text = "Refresh";
            this.btn_view_user.UseVisualStyleBackColor = true;
            this.btn_view_user.Click += new System.EventHandler(this.button1_Click_1);
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
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(131, 476);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(75, 23);
            this.btn_assign.TabIndex = 11;
            this.btn_assign.Text = "Assign ";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "List of all users";
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
            // btn_load_program
            // 
            this.btn_load_program.Location = new System.Drawing.Point(277, 151);
            this.btn_load_program.Name = "btn_load_program";
            this.btn_load_program.Size = new System.Drawing.Size(75, 23);
            this.btn_load_program.TabIndex = 14;
            this.btn_load_program.Text = "Refresh";
            this.btn_load_program.UseVisualStyleBackColor = true;
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 588);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.program_table)).EndInit();
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
    }
}