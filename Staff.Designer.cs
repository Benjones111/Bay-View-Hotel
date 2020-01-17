namespace Bay_View_Hotel
{
    partial class Staff
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
            this.usernamelbl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.staffGrid = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeStaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userlastloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bayviewhotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bay_view_hotelDataSet = new Bay_View_Hotel.bay_view_hotelDataSet();
            this.staffTableAdapter = new Bay_View_Hotel.bay_view_hotelDataSetTableAdapters.staffTableAdapter();
            this.updateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.staffidtxt = new System.Windows.Forms.TextBox();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startdatePicker = new System.Windows.Forms.DateTimePicker();
            this.startdatelbl = new System.Windows.Forms.Label();
            this.enddatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatelbl = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.usertypelbox = new System.Windows.Forms.ListBox();
            this.usertypelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayviewhotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bay_view_hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelbl
            // 
            this.usernamelbl.Location = new System.Drawing.Point(3, 3);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(123, 34);
            this.usernamelbl.TabIndex = 22;
            this.usernamelbl.Text = "Back";
            this.usernamelbl.UseVisualStyleBackColor = true;
            this.usernamelbl.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Location = new System.Drawing.Point(-1, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 41);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Image = global::Bay_View_Hotel.Properties.Resources.bed;
            this.pictureBox2.Location = new System.Drawing.Point(215, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label4.Location = new System.Drawing.Point(134, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "Bay View";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 47);
            this.panel2.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(1080, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 47);
            this.panel4.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Administrator";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Khaki;
            this.label7.Location = new System.Drawing.Point(487, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 41);
            this.label7.TabIndex = 31;
            this.label7.Text = "View Staff Users";
            // 
            // staffGrid
            // 
            this.staffGrid.AutoGenerateColumns = false;
            this.staffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.firstnameStaffDataGridViewTextBoxColumn,
            this.lastnameStaffDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.startDateStaffDataGridViewTextBoxColumn,
            this.endDateStaffDataGridViewTextBoxColumn,
            this.staffPasswordDataGridViewTextBoxColumn,
            this.usertypeStaffDataGridViewTextBoxColumn,
            this.userlastloginDataGridViewTextBoxColumn});
            this.staffGrid.DataSource = this.staffBindingSource;
            this.staffGrid.Location = new System.Drawing.Point(215, 64);
            this.staffGrid.MultiSelect = false;
            this.staffGrid.Name = "staffGrid";
            this.staffGrid.Size = new System.Drawing.Size(947, 447);
            this.staffGrid.TabIndex = 39;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // firstnameStaffDataGridViewTextBoxColumn
            // 
            this.firstnameStaffDataGridViewTextBoxColumn.DataPropertyName = "Firstname_Staff";
            this.firstnameStaffDataGridViewTextBoxColumn.HeaderText = "Firstname_Staff";
            this.firstnameStaffDataGridViewTextBoxColumn.Name = "firstnameStaffDataGridViewTextBoxColumn";
            // 
            // lastnameStaffDataGridViewTextBoxColumn
            // 
            this.lastnameStaffDataGridViewTextBoxColumn.DataPropertyName = "Lastname_Staff";
            this.lastnameStaffDataGridViewTextBoxColumn.HeaderText = "Lastname_Staff";
            this.lastnameStaffDataGridViewTextBoxColumn.Name = "lastnameStaffDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // startDateStaffDataGridViewTextBoxColumn
            // 
            this.startDateStaffDataGridViewTextBoxColumn.DataPropertyName = "Start_Date_Staff";
            this.startDateStaffDataGridViewTextBoxColumn.HeaderText = "Start_Date_Staff";
            this.startDateStaffDataGridViewTextBoxColumn.Name = "startDateStaffDataGridViewTextBoxColumn";
            // 
            // endDateStaffDataGridViewTextBoxColumn
            // 
            this.endDateStaffDataGridViewTextBoxColumn.DataPropertyName = "End_Date_Staff";
            this.endDateStaffDataGridViewTextBoxColumn.HeaderText = "End_Date_Staff";
            this.endDateStaffDataGridViewTextBoxColumn.Name = "endDateStaffDataGridViewTextBoxColumn";
            // 
            // staffPasswordDataGridViewTextBoxColumn
            // 
            this.staffPasswordDataGridViewTextBoxColumn.DataPropertyName = "Staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.HeaderText = "Staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.Name = "staffPasswordDataGridViewTextBoxColumn";
            // 
            // usertypeStaffDataGridViewTextBoxColumn
            // 
            this.usertypeStaffDataGridViewTextBoxColumn.DataPropertyName = "User_type_Staff";
            this.usertypeStaffDataGridViewTextBoxColumn.HeaderText = "User_type_Staff";
            this.usertypeStaffDataGridViewTextBoxColumn.Name = "usertypeStaffDataGridViewTextBoxColumn";
            // 
            // userlastloginDataGridViewTextBoxColumn
            // 
            this.userlastloginDataGridViewTextBoxColumn.DataPropertyName = "User_last_login";
            this.userlastloginDataGridViewTextBoxColumn.HeaderText = "User_last_login";
            this.userlastloginDataGridViewTextBoxColumn.Name = "userlastloginDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.bayviewhotelDataSetBindingSource;
            // 
            // bayviewhotelDataSetBindingSource
            // 
            this.bayviewhotelDataSetBindingSource.DataSource = this.bay_view_hotelDataSet;
            this.bayviewhotelDataSetBindingSource.Position = 0;
            // 
            // bay_view_hotelDataSet
            // 
            this.bay_view_hotelDataSet.DataSetName = "bay_view_hotelDataSet";
            this.bay_view_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(17, 64);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(148, 33);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(17, 132);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(148, 33);
            this.clearBtn.TabIndex = 42;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // staffidtxt
            // 
            this.staffidtxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_ID", true));
            this.staffidtxt.Location = new System.Drawing.Point(166, 203);
            this.staffidtxt.Name = "staffidtxt";
            this.staffidtxt.Size = new System.Drawing.Size(26, 20);
            this.staffidtxt.TabIndex = 43;
            this.staffidtxt.Visible = false;
            // 
            // firstnametxt
            // 
            this.firstnametxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Firstname_Staff", true));
            this.firstnametxt.Location = new System.Drawing.Point(17, 203);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(100, 20);
            this.firstnametxt.TabIndex = 44;
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelbl.Location = new System.Drawing.Point(14, 184);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(73, 16);
            this.firstnamelbl.TabIndex = 45;
            this.firstnamelbl.Text = "First Name";
            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.Location = new System.Drawing.Point(17, 245);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(100, 20);
            this.lastnametxt.TabIndex = 46;
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelbl.Location = new System.Drawing.Point(14, 226);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(73, 16);
            this.lastnamelbl.TabIndex = 47;
            this.lastnamelbl.Text = "Last Name";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(17, 287);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 20);
            this.usernametxt.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Username";
            // 
            // startdatePicker
            // 
            this.startdatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatePicker.CustomFormat = "dd/MM/yyyy";
            this.startdatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startdatePicker.Location = new System.Drawing.Point(17, 329);
            this.startdatePicker.Name = "startdatePicker";
            this.startdatePicker.Size = new System.Drawing.Size(114, 22);
            this.startdatePicker.TabIndex = 50;
            this.startdatePicker.Value = new System.DateTime(1888, 1, 1, 0, 0, 0, 0);
            // 
            // startdatelbl
            // 
            this.startdatelbl.AutoSize = true;
            this.startdatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatelbl.Location = new System.Drawing.Point(14, 310);
            this.startdatelbl.Name = "startdatelbl";
            this.startdatelbl.Size = new System.Drawing.Size(67, 16);
            this.startdatelbl.TabIndex = 51;
            this.startdatelbl.Text = "Start Date";
            // 
            // enddatePicker
            // 
            this.enddatePicker.CustomFormat = "dd/MM/yyyy";
            this.enddatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddatePicker.Location = new System.Drawing.Point(17, 373);
            this.enddatePicker.Name = "enddatePicker";
            this.enddatePicker.Size = new System.Drawing.Size(114, 22);
            this.enddatePicker.TabIndex = 52;
            this.enddatePicker.Value = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            // 
            // enddatelbl
            // 
            this.enddatelbl.AutoSize = true;
            this.enddatelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddatelbl.Location = new System.Drawing.Point(14, 354);
            this.enddatelbl.Name = "enddatelbl";
            this.enddatelbl.Size = new System.Drawing.Size(64, 16);
            this.enddatelbl.TabIndex = 53;
            this.enddatelbl.Text = "End Date";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(17, 417);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.passwordtxt.TabIndex = 54;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(14, 398);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(68, 16);
            this.passwordlbl.TabIndex = 55;
            this.passwordlbl.Text = "Password";
            // 
            // usertypelbox
            // 
            this.usertypelbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypelbox.FormattingEnabled = true;
            this.usertypelbox.ItemHeight = 16;
            this.usertypelbox.Items.AddRange(new object[] {
            "User",
            "Manager"});
            this.usertypelbox.Location = new System.Drawing.Point(17, 459);
            this.usertypelbox.Name = "usertypelbox";
            this.usertypelbox.Size = new System.Drawing.Size(120, 52);
            this.usertypelbox.TabIndex = 56;
            // 
            // usertypelbl
            // 
            this.usertypelbl.AutoSize = true;
            this.usertypelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertypelbl.Location = new System.Drawing.Point(14, 440);
            this.usertypelbl.Name = "usertypelbl";
            this.usertypelbl.Size = new System.Drawing.Size(72, 16);
            this.usertypelbl.TabIndex = 57;
            this.usertypelbl.Text = "User Type";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1177, 652);
            this.Controls.Add(this.usertypelbl);
            this.Controls.Add(this.usertypelbox);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.enddatelbl);
            this.Controls.Add(this.enddatePicker);
            this.Controls.Add(this.startdatelbl);
            this.Controls.Add(this.startdatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.lastnametxt);
            this.Controls.Add(this.firstnamelbl);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.staffidtxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.staffGrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayviewhotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bay_view_hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button usernamelbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView staffGrid;
        private System.Windows.Forms.BindingSource bayviewhotelDataSetBindingSource;
        private bay_view_hotelDataSet bay_view_hotelDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private bay_view_hotelDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeStaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userlastloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox staffidtxt;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label startdatelbl;
        private System.Windows.Forms.DateTimePicker enddatePicker;
        private System.Windows.Forms.DateTimePicker startdatePicker;
        private System.Windows.Forms.Label enddatelbl;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.ListBox usertypelbox;
        private System.Windows.Forms.Label usertypelbl;
    }
}