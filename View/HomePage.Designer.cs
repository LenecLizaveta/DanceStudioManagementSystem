namespace DanceStudioManagementSystem
{
    partial class HomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.AttendanceButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsListDataGridView = new System.Windows.Forms.DataGridView();
            this.ID_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddlerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_ID_Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteClientButton = new Guna.UI2.WinForms.Guna2Button();
            this.CnahgeButton = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Имя = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.checkBoxForm = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveChangedButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.StatisticsButton);
            this.panel1.Controls.Add(this.AttendanceButton);
            this.panel1.Controls.Add(this.ScheduleButton);
            this.panel1.Controls.Add(this.ClientsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::DanceStudioManagementSystem.Properties.Resources.sign_out;
            this.Exit.Location = new System.Drawing.Point(-3, 448);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 84);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.FlatAppearance.BorderSize = 0;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticsButton.ForeColor = System.Drawing.Color.White;
            this.StatisticsButton.Image = global::DanceStudioManagementSystem.Properties.Resources.graph_line;
            this.StatisticsButton.Location = new System.Drawing.Point(0, 355);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(200, 84);
            this.StatisticsButton.TabIndex = 4;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // AttendanceButton
            // 
            this.AttendanceButton.FlatAppearance.BorderSize = 0;
            this.AttendanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttendanceButton.ForeColor = System.Drawing.Color.White;
            this.AttendanceButton.Image = global::DanceStudioManagementSystem.Properties.Resources.table;
            this.AttendanceButton.Location = new System.Drawing.Point(0, 242);
            this.AttendanceButton.Name = "AttendanceButton";
            this.AttendanceButton.Size = new System.Drawing.Size(200, 84);
            this.AttendanceButton.TabIndex = 3;
            this.AttendanceButton.Text = "Attendance";
            this.AttendanceButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AttendanceButton.UseVisualStyleBackColor = true;
            this.AttendanceButton.Click += new System.EventHandler(this.AttendanceButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.FlatAppearance.BorderSize = 0;
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleButton.ForeColor = System.Drawing.Color.White;
            this.ScheduleButton.Image = global::DanceStudioManagementSystem.Properties.Resources.note;
            this.ScheduleButton.Location = new System.Drawing.Point(0, 137);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(200, 84);
            this.ScheduleButton.TabIndex = 2;
            this.ScheduleButton.Text = "Schedule";
            this.ScheduleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ScheduleButton.UseVisualStyleBackColor = true;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.FlatAppearance.BorderSize = 0;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsButton.ForeColor = System.Drawing.Color.White;
            this.ClientsButton.Image = global::DanceStudioManagementSystem.Properties.Resources.organization__6_;
            this.ClientsButton.Location = new System.Drawing.Point(2, 34);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(198, 84);
            this.ClientsButton.TabIndex = 1;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(248, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients base";
            // 
            // ClientsListDataGridView
            // 
            this.ClientsListDataGridView.AllowUserToAddRows = false;
            this.ClientsListDataGridView.AllowUserToDeleteRows = false;
            this.ClientsListDataGridView.AllowUserToOrderColumns = true;
            this.ClientsListDataGridView.AllowUserToResizeColumns = false;
            this.ClientsListDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClientsListDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientsListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsListDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientsListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsListDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientsListDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientsListDataGridView.ColumnHeadersHeight = 18;
            this.ClientsListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Client,
            this.Name,
            this.Surname,
            this.MiddlerName,
            this.PhoneNumber,
            this.Discount,
            this.Adress,
            this.Form,
            this.Discount_ID_Discount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientsListDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientsListDataGridView.EnableHeadersVisualStyles = false;
            this.ClientsListDataGridView.GridColor = System.Drawing.Color.White;
            this.ClientsListDataGridView.Location = new System.Drawing.Point(256, 116);
            this.ClientsListDataGridView.Name = "ClientsListDataGridView";
            this.ClientsListDataGridView.ReadOnly = true;
            this.ClientsListDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientsListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientsListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsListDataGridView.Size = new System.Drawing.Size(776, 179);
            this.ClientsListDataGridView.TabIndex = 2;
            this.ClientsListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_Client
            // 
            this.ID_Client.DataPropertyName = "ID_Client";
            this.ID_Client.HeaderText = "ID_Client";
            this.ID_Client.Name = "ID_Client";
            this.ID_Client.ReadOnly = true;
            this.ID_Client.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 98.90017F;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.FillWeight = 98.90017F;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // MiddlerName
            // 
            this.MiddlerName.DataPropertyName = "MiddlerName";
            this.MiddlerName.FillWeight = 98.90017F;
            this.MiddlerName.HeaderText = "Middle Name";
            this.MiddlerName.Name = "MiddlerName";
            this.MiddlerName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 98.90017F;
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.FillWeight = 98.90017F;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.FillWeight = 98.90017F;
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Form
            // 
            this.Form.DataPropertyName = "Form";
            this.Form.FillWeight = 106.599F;
            this.Form.HeaderText = "Form";
            this.Form.Name = "Form";
            this.Form.ReadOnly = true;
            // 
            // Discount_ID_Discount
            // 
            this.Discount_ID_Discount.DataPropertyName = "Discount_ID_Discount";
            this.Discount_ID_Discount.HeaderText = "Discount_ID_Discount";
            this.Discount_ID_Discount.Name = "Discount_ID_Discount";
            this.Discount_ID_Discount.ReadOnly = true;
            this.Discount_ID_Discount.Visible = false;
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteClientButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteClientButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteClientButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteClientButton.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.DeleteClientButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteClientButton.ForeColor = System.Drawing.Color.White;
            this.DeleteClientButton.Location = new System.Drawing.Point(853, 498);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(170, 34);
            this.DeleteClientButton.TabIndex = 4;
            this.DeleteClientButton.Text = "Delete Chosen Client";
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // CnahgeButton
            // 
            this.CnahgeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CnahgeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CnahgeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CnahgeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CnahgeButton.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.CnahgeButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CnahgeButton.ForeColor = System.Drawing.Color.White;
            this.CnahgeButton.Location = new System.Drawing.Point(515, 498);
            this.CnahgeButton.Name = "CnahgeButton";
            this.CnahgeButton.Size = new System.Drawing.Size(161, 34);
            this.CnahgeButton.TabIndex = 5;
            this.CnahgeButton.Text = "Change client\'s data";
            this.CnahgeButton.Click += new System.EventHandler(this.CnahgeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(250, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 44);
            this.label6.TabIndex = 42;
            this.label6.Text = "new client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(428, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Middle Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiddleName.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMiddleName.Location = new System.Drawing.Point(577, 449);
            this.txtMiddleName.Multiline = true;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(160, 24);
            this.txtMiddleName.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Location = new System.Drawing.Point(428, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(428, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name:";
            // 
            // Имя
            // 
            this.Имя.AutoSize = true;
            this.Имя.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Имя.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.Имя.Location = new System.Drawing.Point(428, 354);
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(120, 26);
            this.Имя.TabIndex = 37;
            this.Имя.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLastName.Location = new System.Drawing.Point(551, 401);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 24);
            this.txtLastName.TabIndex = 36;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtFirstName.Location = new System.Drawing.Point(554, 354);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(174, 24);
            this.txtFirstName.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Location = new System.Drawing.Point(428, 426);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.Location = new System.Drawing.Point(428, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 1);
            this.panel4.TabIndex = 33;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(428, 498);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(81, 34);
            this.AddButton.TabIndex = 53;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // checkBoxForm
            // 
            this.checkBoxForm.AutoSize = true;
            this.checkBoxForm.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxForm.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.checkBoxForm.Location = new System.Drawing.Point(283, 502);
            this.checkBoxForm.Name = "checkBoxForm";
            this.checkBoxForm.Size = new System.Drawing.Size(83, 30);
            this.checkBoxForm.TabIndex = 52;
            this.checkBoxForm.Text = "Form";
            this.checkBoxForm.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(763, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Adress:";
            // 
            // txtAdress
            // 
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdress.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAdress.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAdress.Location = new System.Drawing.Point(849, 449);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(174, 24);
            this.txtAdress.TabIndex = 50;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel5.Location = new System.Drawing.Point(763, 474);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 1);
            this.panel5.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(763, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 48;
            this.label5.Text = "Discount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(763, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Phone Number:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscount.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDiscount.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiscount.Location = new System.Drawing.Point(872, 401);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(151, 24);
            this.txtDiscount.TabIndex = 46;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumber.Location = new System.Drawing.Point(933, 356);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(90, 24);
            this.txtPhoneNumber.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel6.Location = new System.Drawing.Point(763, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 1);
            this.panel6.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel7.Location = new System.Drawing.Point(763, 380);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 1);
            this.panel7.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DanceStudioManagementSystem.Properties.Resources.account__2_;
            this.pictureBox1.Location = new System.Drawing.Point(258, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(604, 20);
            this.textBox1.TabIndex = 55;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SaveChangedButton
            // 
            this.SaveChangedButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveChangedButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveChangedButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveChangedButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveChangedButton.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.SaveChangedButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangedButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangedButton.Location = new System.Drawing.Point(682, 498);
            this.SaveChangedButton.Name = "SaveChangedButton";
            this.SaveChangedButton.Size = new System.Drawing.Size(161, 34);
            this.SaveChangedButton.TabIndex = 56;
            this.SaveChangedButton.Text = "Save changed data";
            this.SaveChangedButton.Click += new System.EventHandler(this.SaveChangedButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.SaveChangedButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.checkBoxForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Имя);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.CnahgeButton);
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.ClientsListDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dance Studio Managment System";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.Button AttendanceButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientsListDataGridView;
        private Guna.UI2.WinForms.Guna2Button DeleteClientButton;
        private Guna.UI2.WinForms.Guna2Button CnahgeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddlerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Form;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_ID_Discount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Имя;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckBox checkBoxForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button SaveChangedButton;
    }
}