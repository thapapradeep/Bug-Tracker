namespace Bug_Tracker
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log In Credentials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(246, 176);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(246, 120);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(100, 20);
            this.txt_user.TabIndex = 5;
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Location = new System.Drawing.Point(157, 242);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_in.TabIndex = 6;
            this.btn_sign_in.Text = "Sign In";
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.btn_sign_in_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 363);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Bug Tracker  User Verification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_sign_in;
    }
}

