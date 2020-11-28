namespace DBapplication
{
    partial class Supplier
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
            this.insertButton = new System.Windows.Forms.Button();
            this.sNumTextBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sexlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProjectNumDel = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeptNumGet = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.GetAllButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ManagerSSN = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.TextBox();
            this.DeptNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labeldept = new System.Windows.Forms.Label();
            this.ProjectNumCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Enum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Mnum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Dnum = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SalaryUpdate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AddressUpdate = new System.Windows.Forms.TextBox();
            this.UpdateDep = new System.Windows.Forms.Button();
            this.UpdateSal = new System.Windows.Forms.Button();
            this.UpdateManager = new System.Windows.Forms.Button();
            this.UpdateAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(1451, 27);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(147, 31);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert Employee";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // sNumTextBox
            // 
            this.sNumTextBox.Location = new System.Drawing.Point(52, 27);
            this.sNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.sNumTextBox.Name = "sNumTextBox";
            this.sNumTextBox.Size = new System.Drawing.Size(132, 22);
            this.sNumTextBox.TabIndex = 1;
            this.sNumTextBox.TextChanged += new System.EventHandler(this.sNumTextBox_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(308, 27);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(132, 22);
            this.FirstName.TabIndex = 2;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(77, 87);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(132, 22);
            this.Address.TabIndex = 3;
            this.Address.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "S#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sexlabel
            // 
            this.sexlabel.AutoSize = true;
            this.sexlabel.Location = new System.Drawing.Point(232, 90);
            this.sexlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexlabel.Name = "sexlabel";
            this.sexlabel.Size = new System.Drawing.Size(31, 17);
            this.sexlabel.TabIndex = 7;
            this.sexlabel.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Project Number";
            // 
            // ProjectNumDel
            // 
            this.ProjectNumDel.Location = new System.Drawing.Point(133, 159);
            this.ProjectNumDel.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectNumDel.Name = "ProjectNumDel";
            this.ProjectNumDel.Size = new System.Drawing.Size(132, 22);
            this.ProjectNumDel.TabIndex = 10;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(308, 155);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 30);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete Project";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Department Number";
            // 
            // DeptNumGet
            // 
            this.DeptNumGet.Location = new System.Drawing.Point(222, 320);
            this.DeptNumGet.Margin = new System.Windows.Forms.Padding(4);
            this.DeptNumGet.Name = "DeptNumGet";
            this.DeptNumGet.Size = new System.Drawing.Size(132, 22);
            this.DeptNumGet.TabIndex = 14;
            this.DeptNumGet.TextChanged += new System.EventHandler(this.DeptNumGet_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1377, 586);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(147, 28);
            this.updateButton.TabIndex = 16;
            this.updateButton.Text = "Update All";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(574, 528);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(146, 28);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EmployeesDataGrid
            // 
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AllowUserToDeleteRows = false;
            this.EmployeesDataGrid.AllowUserToOrderColumns = true;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(20, 364);
            this.EmployeesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            this.EmployeesDataGrid.RowHeadersWidth = 51;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(700, 156);
            this.EmployeesDataGrid.TabIndex = 18;
            this.EmployeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGrid_CellContentClick);
            // 
            // GetAllButton
            // 
            this.GetAllButton.Location = new System.Drawing.Point(493, 314);
            this.GetAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetAllButton.Name = "GetAllButton";
            this.GetAllButton.Size = new System.Drawing.Size(146, 28);
            this.GetAllButton.TabIndex = 19;
            this.GetAllButton.Text = "Get All Employees";
            this.GetAllButton.UseVisualStyleBackColor = true;
            this.GetAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(308, 233);
            this.countButton.Margin = new System.Windows.Forms.Padding(4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(133, 28);
            this.countButton.TabIndex = 20;
            this.countButton.Text = "Count Employees";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Enabled = false;
            this.countTextBox.Location = new System.Drawing.Point(627, 239);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.ReadOnly = true;
            this.countTextBox.Size = new System.Drawing.Size(132, 22);
            this.countTextBox.TabIndex = 21;
            this.countTextBox.TextChanged += new System.EventHandler(this.countTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(490, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Employees Count";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(627, 85);
            this.Salary.Margin = new System.Windows.Forms.Padding(4);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(132, 22);
            this.Salary.TabIndex = 23;
            this.Salary.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(911, 27);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(132, 22);
            this.LastName.TabIndex = 24;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // ManagerSSN
            // 
            this.ManagerSSN.Location = new System.Drawing.Point(911, 85);
            this.ManagerSSN.Margin = new System.Windows.Forms.Padding(4);
            this.ManagerSSN.Name = "ManagerSSN";
            this.ManagerSSN.Size = new System.Drawing.Size(132, 22);
            this.ManagerSSN.TabIndex = 27;
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(1250, 27);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(132, 22);
            this.BirthDate.TabIndex = 28;
            // 
            // DeptNum
            // 
            this.DeptNum.Location = new System.Drawing.Point(1250, 85);
            this.DeptNum.Margin = new System.Windows.Forms.Padding(4);
            this.DeptNum.Name = "DeptNum";
            this.DeptNum.Size = new System.Drawing.Size(132, 22);
            this.DeptNum.TabIndex = 29;
            this.DeptNum.TextChanged += new System.EventHandler(this.DeptNum_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(490, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Salary";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(815, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Manager S#";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(824, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1124, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Birth Date";
            // 
            // labeldept
            // 
            this.labeldept.AutoSize = true;
            this.labeldept.Location = new System.Drawing.Point(1098, 85);
            this.labeldept.Name = "labeldept";
            this.labeldept.Size = new System.Drawing.Size(136, 17);
            this.labeldept.TabIndex = 34;
            this.labeldept.Text = "Department Number";
            this.labeldept.Click += new System.EventHandler(this.DeptNum_Click);
            // 
            // ProjectNumCount
            // 
            this.ProjectNumCount.Location = new System.Drawing.Point(133, 236);
            this.ProjectNumCount.Margin = new System.Windows.Forms.Padding(4);
            this.ProjectNumCount.Name = "ProjectNumCount";
            this.ProjectNumCount.Size = new System.Drawing.Size(132, 22);
            this.ProjectNumCount.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 239);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Project Number";
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(627, 27);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(132, 22);
            this.MiddleName.TabIndex = 37;
            this.MiddleName.TextChanged += new System.EventHandler(this.MiddleName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Middle Name";
            // 
            // Enum
            // 
            this.Enum.Location = new System.Drawing.Point(1140, 295);
            this.Enum.Margin = new System.Windows.Forms.Padding(4);
            this.Enum.Name = "Enum";
            this.Enum.Size = new System.Drawing.Size(132, 22);
            this.Enum.TabIndex = 39;
            this.Enum.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1079, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "S#";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1019, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 17);
            this.label15.TabIndex = 43;
            this.label15.Text = "Manager S#";
            // 
            // Mnum
            // 
            this.Mnum.Location = new System.Drawing.Point(1140, 454);
            this.Mnum.Margin = new System.Windows.Forms.Padding(4);
            this.Mnum.Name = "Mnum";
            this.Mnum.Size = new System.Drawing.Size(132, 22);
            this.Mnum.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(986, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 17);
            this.label14.TabIndex = 45;
            this.label14.Text = "Department Number";
            // 
            // Dnum
            // 
            this.Dnum.Location = new System.Drawing.Point(1140, 355);
            this.Dnum.Margin = new System.Windows.Forms.Padding(4);
            this.Dnum.Name = "Dnum";
            this.Dnum.Size = new System.Drawing.Size(132, 22);
            this.Dnum.TabIndex = 44;
            this.Dnum.TextChanged += new System.EventHandler(this.Dnum_TextChanged);
            // 
            // Sex
            // 
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Sex.Location = new System.Drawing.Point(308, 84);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(121, 24);
            this.Sex.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1056, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Salary";
            // 
            // SalaryUpdate
            // 
            this.SalaryUpdate.Location = new System.Drawing.Point(1140, 403);
            this.SalaryUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryUpdate.Name = "SalaryUpdate";
            this.SalaryUpdate.Size = new System.Drawing.Size(132, 22);
            this.SalaryUpdate.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1044, 507);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 49;
            this.label17.Text = "Address";
            // 
            // AddressUpdate
            // 
            this.AddressUpdate.Location = new System.Drawing.Point(1140, 507);
            this.AddressUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.AddressUpdate.Name = "AddressUpdate";
            this.AddressUpdate.Size = new System.Drawing.Size(132, 22);
            this.AddressUpdate.TabIndex = 48;
            this.AddressUpdate.TextChanged += new System.EventHandler(this.AddressUpdate_TextChanged);
            // 
            // UpdateDep
            // 
            this.UpdateDep.Location = new System.Drawing.Point(1377, 349);
            this.UpdateDep.Name = "UpdateDep";
            this.UpdateDep.Size = new System.Drawing.Size(147, 23);
            this.UpdateDep.TabIndex = 52;
            this.UpdateDep.Text = "Update Dno";
            this.UpdateDep.UseVisualStyleBackColor = true;
            this.UpdateDep.Click += new System.EventHandler(this.UpdateDep_Click);
            // 
            // UpdateSal
            // 
            this.UpdateSal.Location = new System.Drawing.Point(1377, 406);
            this.UpdateSal.Name = "UpdateSal";
            this.UpdateSal.Size = new System.Drawing.Size(147, 23);
            this.UpdateSal.TabIndex = 53;
            this.UpdateSal.Text = "Update Salary";
            this.UpdateSal.UseVisualStyleBackColor = true;
            this.UpdateSal.Click += new System.EventHandler(this.UpdateSal_Click);
            // 
            // UpdateManager
            // 
            this.UpdateManager.Location = new System.Drawing.Point(1377, 454);
            this.UpdateManager.Name = "UpdateManager";
            this.UpdateManager.Size = new System.Drawing.Size(147, 23);
            this.UpdateManager.TabIndex = 54;
            this.UpdateManager.Text = "Update Manager";
            this.UpdateManager.UseVisualStyleBackColor = true;
            this.UpdateManager.Click += new System.EventHandler(this.UpdateManager_Click);
            // 
            // UpdateAddress
            // 
            this.UpdateAddress.Location = new System.Drawing.Point(1377, 507);
            this.UpdateAddress.Name = "UpdateAddress";
            this.UpdateAddress.Size = new System.Drawing.Size(147, 23);
            this.UpdateAddress.TabIndex = 55;
            this.UpdateAddress.Text = "Update Address";
            this.UpdateAddress.UseVisualStyleBackColor = true;
            this.UpdateAddress.Click += new System.EventHandler(this.UpdateAddress_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 684);
            this.Controls.Add(this.UpdateAddress);
            this.Controls.Add(this.UpdateManager);
            this.Controls.Add(this.UpdateSal);
            this.Controls.Add(this.UpdateDep);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SalaryUpdate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.AddressUpdate);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Dnum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Mnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Enum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.ProjectNumCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labeldept);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeptNum);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.ManagerSSN);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.GetAllButton);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.DeptNumGet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ProjectNumDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sexlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.sNumTextBox);
            this.Controls.Add(this.insertButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox sNumTextBox;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sexlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProjectNumDel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DeptNumGet;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.Button GetAllButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ManagerSSN;
        private System.Windows.Forms.TextBox BirthDate;
        private System.Windows.Forms.TextBox DeptNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labeldept;
        private System.Windows.Forms.TextBox ProjectNumCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Enum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Mnum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Dnum;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox SalaryUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AddressUpdate;
        private System.Windows.Forms.Button UpdateDep;
        private System.Windows.Forms.Button UpdateSal;
        private System.Windows.Forms.Button UpdateManager;
        private System.Windows.Forms.Button UpdateAddress;
    }
}

