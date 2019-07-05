namespace Kanban
{
    partial class KanbanCreate
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
            this.btnCreateList = new System.Windows.Forms.Button();
            this.dgwKanban1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.tbxTableName = new System.Windows.Forms.TextBox();
            this.lblToDoItemName = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemDeadline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.dgvListItem = new System.Windows.Forms.DataGridView();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKanban1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateList
            // 
            this.btnCreateList.Location = new System.Drawing.Point(18, 248);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(115, 23);
            this.btnCreateList.TabIndex = 0;
            this.btnCreateList.Text = "Create New Table";
            this.btnCreateList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // dgwKanban1
            // 
            this.dgwKanban1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKanban1.Location = new System.Drawing.Point(12, 375);
            this.dgwKanban1.Name = "dgwKanban1";
            this.dgwKanban1.Size = new System.Drawing.Size(749, 209);
            this.dgwKanban1.TabIndex = 1;
            this.dgwKanban1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKanban1_CellContentClick);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(139, 248);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(134, 23);
            this.btnDeleteList.TabIndex = 2;
            this.btnDeleteList.Text = "Delete Current Table";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(18, 739);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Location = new System.Drawing.Point(23, 13);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(57, 13);
            this.lblGreetings.TabIndex = 5;
            this.lblGreetings.Text = "Hoş geldin";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Location = new System.Drawing.Point(93, 13);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(0, 13);
            this.lblLoginUser.TabIndex = 6;
            // 
            // tbxTableName
            // 
            this.tbxTableName.Location = new System.Drawing.Point(100, 215);
            this.tbxTableName.Name = "tbxTableName";
            this.tbxTableName.Size = new System.Drawing.Size(100, 20);
            this.tbxTableName.TabIndex = 7;
            // 
            // lblToDoItemName
            // 
            this.lblToDoItemName.AutoSize = true;
            this.lblToDoItemName.Location = new System.Drawing.Point(15, 218);
            this.lblToDoItemName.Name = "lblToDoItemName";
            this.lblToDoItemName.Size = new System.Drawing.Size(65, 13);
            this.lblToDoItemName.TabIndex = 8;
            this.lblToDoItemName.Text = "Table Name";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(99, 739);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 9;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(15, 605);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(35, 13);
            this.lblItemName.TabIndex = 10;
            this.lblItemName.Text = "Name";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Location = new System.Drawing.Point(15, 635);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(60, 13);
            this.lblItemDescription.TabIndex = 11;
            this.lblItemDescription.Text = "Description";
            // 
            // lblItemDeadline
            // 
            this.lblItemDeadline.AutoSize = true;
            this.lblItemDeadline.Location = new System.Drawing.Point(15, 672);
            this.lblItemDeadline.Name = "lblItemDeadline";
            this.lblItemDeadline.Size = new System.Drawing.Size(49, 13);
            this.lblItemDeadline.TabIndex = 12;
            this.lblItemDeadline.Text = "Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(85, 605);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(200, 20);
            this.tbxName.TabIndex = 14;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(85, 632);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(200, 20);
            this.tbxDescription.TabIndex = 15;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(180, 739);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateItem.TabIndex = 18;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(85, 666);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(200, 20);
            this.dtpDeadline.TabIndex = 19;
            // 
            // dgvListItem
            // 
            this.dgvListItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListItem.GridColor = System.Drawing.Color.Chocolate;
            this.dgvListItem.Location = new System.Drawing.Point(18, 50);
            this.dgvListItem.Name = "dgvListItem";
            this.dgvListItem.Size = new System.Drawing.Size(461, 150);
            this.dgvListItem.TabIndex = 20;
            this.dgvListItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListItemContentClick);
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(279, 248);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateList.TabIndex = 21;
            this.btnUpdateList.Text = "Update Current Table";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(85, 700);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(200, 21);
            this.cbxStatus.TabIndex = 22;
            // 
            // KanbanCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 822);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.btnUpdateList);
            this.Controls.Add(this.dgvListItem);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblItemDeadline);
            this.Controls.Add(this.lblItemDescription);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.lblToDoItemName);
            this.Controls.Add(this.tbxTableName);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.dgwKanban1);
            this.Controls.Add(this.btnCreateList);
            this.Name = "KanbanCreate";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.KanbanCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKanban1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.DataGridView dgwKanban1;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.TextBox tbxTableName;
        private System.Windows.Forms.Label lblToDoItemName;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.DataGridView dgvListItem;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.ComboBox cbxStatus;
    }
}