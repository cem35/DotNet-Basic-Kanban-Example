namespace Kanban
{
    partial class Form1
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxPassName = new System.Windows.Forms.TextBox();
            this.tbxPassPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassUserNam = new System.Windows.Forms.Label();
            this.lblPassPassword = new System.Windows.Forms.Label();
            this.lbltry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(60, 31);
            this.dgwList.Name = "dgwList";
            this.dgwList.Size = new System.Drawing.Size(666, 150);
            this.dgwList.TabIndex = 0;
            this.dgwList.Visible = false;
            this.dgwList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(43, 362);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(167, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(110, 247);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(100, 20);
            this.tbxUserName.TabIndex = 2;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(110, 273);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxSurname.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(110, 299);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(110, 326);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(40, 250);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(40, 276);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 302);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 329);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-Mail";
            // 
            // tbxPassName
            // 
            this.tbxPassName.Location = new System.Drawing.Point(534, 246);
            this.tbxPassName.Name = "tbxPassName";
            this.tbxPassName.Size = new System.Drawing.Size(100, 20);
            this.tbxPassName.TabIndex = 11;
            // 
            // tbxPassPassword
            // 
            this.tbxPassPassword.Location = new System.Drawing.Point(534, 272);
            this.tbxPassPassword.Name = "tbxPassPassword";
            this.tbxPassPassword.PasswordChar = '*';
            this.tbxPassPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassPassword.TabIndex = 12;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(545, 302);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassUserNam
            // 
            this.lblPassUserNam.AutoSize = true;
            this.lblPassUserNam.Location = new System.Drawing.Point(458, 252);
            this.lblPassUserNam.Name = "lblPassUserNam";
            this.lblPassUserNam.Size = new System.Drawing.Size(60, 13);
            this.lblPassUserNam.TabIndex = 14;
            this.lblPassUserNam.Text = "User Name";
            // 
            // lblPassPassword
            // 
            this.lblPassPassword.AutoSize = true;
            this.lblPassPassword.Location = new System.Drawing.Point(461, 278);
            this.lblPassPassword.Name = "lblPassPassword";
            this.lblPassPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassPassword.TabIndex = 15;
            this.lblPassPassword.Text = "Password";
            // 
            // lbltry
            // 
            this.lbltry.AutoSize = true;
            this.lbltry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltry.ForeColor = System.Drawing.Color.Red;
            this.lbltry.Location = new System.Drawing.Point(269, 195);
            this.lbltry.Name = "lbltry";
            this.lbltry.Size = new System.Drawing.Size(0, 31);
            this.lbltry.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltry);
            this.Controls.Add(this.lblPassPassword);
            this.Controls.Add(this.lblPassUserNam);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassPassword);
            this.Controls.Add(this.tbxPassName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgwList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxPassName;
        private System.Windows.Forms.TextBox tbxPassPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassUserNam;
        private System.Windows.Forms.Label lblPassPassword;
        private System.Windows.Forms.Label lbltry;
    }
}

