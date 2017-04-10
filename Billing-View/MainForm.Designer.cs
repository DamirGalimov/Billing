namespace Billing_View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxEmployees = new System.Windows.Forms.GroupBox();
            this.EmployeegroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxWages = new System.Windows.Forms.TextBox();
            this.labelWages = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.labelHourCost = new System.Windows.Forms.Label();
            this.textBoxDaysWorked = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxHourCost = new System.Windows.Forms.TextBox();
            this.labelDaysWorked = new System.Windows.Forms.Label();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxPaymentType = new System.Windows.Forms.TextBox();
            this.billingGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOpenTest = new System.Windows.Forms.Button();
            this.buttonAutoCreate = new System.Windows.Forms.Button();
            this.buttonSaveTest = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmpl = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonReturnList = new System.Windows.Forms.Button();
            this.labelEnter = new System.Windows.Forms.Label();
            this.labelCriterion = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxEmployees.SuspendLayout();
            this.EmployeegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEmployeeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployees
            // 
            this.groupBoxEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEmployees.Controls.Add(this.billingGridView);
            this.groupBoxEmployees.Location = new System.Drawing.Point(12, 27);
            this.groupBoxEmployees.Name = "groupBoxEmployees";
            this.groupBoxEmployees.Size = new System.Drawing.Size(719, 228);
            this.groupBoxEmployees.TabIndex = 1;
            this.groupBoxEmployees.TabStop = false;
            this.groupBoxEmployees.Text = "Employees";
            // 
            // EmployeegroupBox
            // 
            this.EmployeegroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeegroupBox.Controls.Add(this.textBoxWages);
            this.EmployeegroupBox.Controls.Add(this.labelWages);
            this.EmployeegroupBox.Controls.Add(this.textBoxName);
            this.EmployeegroupBox.Controls.Add(this.labelHoursWorked);
            this.EmployeegroupBox.Controls.Add(this.textBoxHoursWorked);
            this.EmployeegroupBox.Controls.Add(this.labelHourCost);
            this.EmployeegroupBox.Controls.Add(this.textBoxDaysWorked);
            this.EmployeegroupBox.Controls.Add(this.labelRate);
            this.EmployeegroupBox.Controls.Add(this.labelSalary);
            this.EmployeegroupBox.Controls.Add(this.textBoxHourCost);
            this.EmployeegroupBox.Controls.Add(this.labelDaysWorked);
            this.EmployeegroupBox.Controls.Add(this.labelPaymentType);
            this.EmployeegroupBox.Controls.Add(this.labelAge);
            this.EmployeegroupBox.Controls.Add(this.labelSurname);
            this.EmployeegroupBox.Controls.Add(this.labelName);
            this.EmployeegroupBox.Controls.Add(this.textBoxRate);
            this.EmployeegroupBox.Controls.Add(this.textBoxSurname);
            this.EmployeegroupBox.Controls.Add(this.textBoxAge);
            this.EmployeegroupBox.Controls.Add(this.textBoxSalary);
            this.EmployeegroupBox.Controls.Add(this.textBoxPaymentType);
            this.EmployeegroupBox.Location = new System.Drawing.Point(484, 27);
            this.EmployeegroupBox.Name = "EmployeegroupBox";
            this.EmployeegroupBox.Size = new System.Drawing.Size(243, 300);
            this.EmployeegroupBox.TabIndex = 1;
            this.EmployeegroupBox.TabStop = false;
            this.EmployeegroupBox.Text = "Employee:";
            // 
            // textBoxWages
            // 
            this.textBoxWages.Location = new System.Drawing.Point(137, 117);
            this.textBoxWages.Name = "textBoxWages";
            this.textBoxWages.ReadOnly = true;
            this.textBoxWages.Size = new System.Drawing.Size(100, 20);
            this.textBoxWages.TabIndex = 16;
            // 
            // labelWages
            // 
            this.labelWages.AutoSize = true;
            this.labelWages.Location = new System.Drawing.Point(8, 120);
            this.labelWages.Name = "labelWages";
            this.labelWages.Size = new System.Drawing.Size(44, 13);
            this.labelWages.TabIndex = 15;
            this.labelWages.Text = "Wages:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(137, 13);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(9, 275);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(125, 13);
            this.labelHoursWorked.TabIndex = 9;
            this.labelHoursWorked.Text = "Amount of hours worked:";
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(138, 270);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.ReadOnly = true;
            this.textBoxHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoursWorked.TabIndex = 12;
            // 
            // labelHourCost
            // 
            this.labelHourCost.AutoSize = true;
            this.labelHourCost.Location = new System.Drawing.Point(9, 247);
            this.labelHourCost.Name = "labelHourCost";
            this.labelHourCost.Size = new System.Drawing.Size(56, 13);
            this.labelHourCost.TabIndex = 8;
            this.labelHourCost.Text = "Hour cost:";
            // 
            // textBoxDaysWorked
            // 
            this.textBoxDaysWorked.Location = new System.Drawing.Point(137, 169);
            this.textBoxDaysWorked.Name = "textBoxDaysWorked";
            this.textBoxDaysWorked.ReadOnly = true;
            this.textBoxDaysWorked.Size = new System.Drawing.Size(100, 20);
            this.textBoxDaysWorked.TabIndex = 14;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(8, 198);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(75, 13);
            this.labelRate.TabIndex = 6;
            this.labelRate.Text = "Rate of salary:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(8, 146);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Monthly salary:";
            // 
            // textBoxHourCost
            // 
            this.textBoxHourCost.Location = new System.Drawing.Point(138, 244);
            this.textBoxHourCost.Name = "textBoxHourCost";
            this.textBoxHourCost.ReadOnly = true;
            this.textBoxHourCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxHourCost.TabIndex = 13;
            // 
            // labelDaysWorked
            // 
            this.labelDaysWorked.AutoSize = true;
            this.labelDaysWorked.Location = new System.Drawing.Point(7, 172);
            this.labelDaysWorked.Name = "labelDaysWorked";
            this.labelDaysWorked.Size = new System.Drawing.Size(122, 13);
            this.labelDaysWorked.TabIndex = 5;
            this.labelDaysWorked.Text = "Days worked per month:";
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Location = new System.Drawing.Point(7, 94);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(74, 13);
            this.labelPaymentType.TabIndex = 3;
            this.labelPaymentType.Text = "Payment type:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(7, 68);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(7, 42);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(137, 195);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 11;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(137, 39);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 7;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(137, 65);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 8;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(137, 143);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.ReadOnly = true;
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 10;
            // 
            // textBoxPaymentType
            // 
            this.textBoxPaymentType.Location = new System.Drawing.Point(137, 91);
            this.textBoxPaymentType.Name = "textBoxPaymentType";
            this.textBoxPaymentType.ReadOnly = true;
            this.textBoxPaymentType.Size = new System.Drawing.Size(100, 20);
            this.textBoxPaymentType.TabIndex = 9;
            // 
            // billingGridView
            // 
            this.billingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingGridView.AutoGenerateColumns = false;
            this.billingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.Wages});
            this.billingGridView.DataSource = this.iEmployeeBindingSource;
            this.billingGridView.Location = new System.Drawing.Point(6, 19);
            this.billingGridView.Name = "billingGridView";
            this.billingGridView.ReadOnly = true;
            this.billingGridView.RowHeadersVisible = false;
            this.billingGridView.Size = new System.Drawing.Size(461, 203);
            this.billingGridView.TabIndex = 0;
            this.billingGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingGridView_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 76;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 75;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 76;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 75;
            // 
            // Wages
            // 
            this.Wages.DataPropertyName = "Wages";
            this.Wages.HeaderText = "Wages";
            this.Wages.Name = "Wages";
            this.Wages.ReadOnly = true;
            // 
            // iEmployeeBindingSource
            // 
            this.iEmployeeBindingSource.DataSource = typeof(Billing.IEmployee);
            // 
            // buttonOpenTest
            // 
            this.buttonOpenTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenTest.Location = new System.Drawing.Point(305, 318);
            this.buttonOpenTest.Name = "buttonOpenTest";
            this.buttonOpenTest.Size = new System.Drawing.Size(66, 23);
            this.buttonOpenTest.TabIndex = 6;
            this.buttonOpenTest.Text = "Open Test";
            this.buttonOpenTest.UseVisualStyleBackColor = true;
            this.buttonOpenTest.Click += new System.EventHandler(this.OpenTestButton_Click);
            // 
            // buttonAutoCreate
            // 
            this.buttonAutoCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAutoCreate.Location = new System.Drawing.Point(377, 318);
            this.buttonAutoCreate.Name = "buttonAutoCreate";
            this.buttonAutoCreate.Size = new System.Drawing.Size(103, 23);
            this.buttonAutoCreate.TabIndex = 5;
            this.buttonAutoCreate.Text = "Automation Create";
            this.buttonAutoCreate.UseVisualStyleBackColor = true;
            this.buttonAutoCreate.Click += new System.EventHandler(this.AutoCreatebutton_Click);
            // 
            // buttonSaveTest
            // 
            this.buttonSaveTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveTest.Location = new System.Drawing.Point(233, 318);
            this.buttonSaveTest.Name = "buttonSaveTest";
            this.buttonSaveTest.Size = new System.Drawing.Size(66, 23);
            this.buttonSaveTest.TabIndex = 4;
            this.buttonSaveTest.Text = "Save Test";
            this.buttonSaveTest.UseVisualStyleBackColor = true;
            this.buttonSaveTest.Click += new System.EventHandler(this.SaveTestButton_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(114, 318);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(113, 23);
            this.buttonRemoveEmployee.TabIndex = 3;
            this.buttonRemoveEmployee.Text = "Remove employee";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmpl_Click);
            // 
            // buttonAddEmpl
            // 
            this.buttonAddEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddEmpl.Location = new System.Drawing.Point(12, 317);
            this.buttonAddEmpl.Name = "buttonAddEmpl";
            this.buttonAddEmpl.Size = new System.Drawing.Size(96, 23);
            this.buttonAddEmpl.TabIndex = 2;
            this.buttonAddEmpl.Text = "Add employee";
            this.buttonAddEmpl.UseVisualStyleBackColor = true;
            this.buttonAddEmpl.Click += new System.EventHandler(this.buttonAddEmpl_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.createToolStripMenuItem.Text = "New";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.closeFileToolStripMenuItem.Text = "Close";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem,
            this.modifyEmployeeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removeEmployeeToolStripMenuItem.Text = "Remove employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeEmployeeToolStripMenuItem_Click);
            // 
            // modifyEmployeeToolStripMenuItem
            // 
            this.modifyEmployeeToolStripMenuItem.Name = "modifyEmployeeToolStripMenuItem";
            this.modifyEmployeeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modifyEmployeeToolStripMenuItem.Text = "Modify employee";
            this.modifyEmployeeToolStripMenuItem.Click += new System.EventHandler(this.modifyEmployeeToolStripMenuItem_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.buttonReturnList);
            this.groupBoxSearch.Controls.Add(this.labelEnter);
            this.groupBoxSearch.Controls.Add(this.labelCriterion);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(486, 261);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(245, 80);
            this.groupBoxSearch.TabIndex = 7;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // buttonReturnList
            // 
            this.buttonReturnList.Location = new System.Drawing.Point(166, 16);
            this.buttonReturnList.Name = "buttonReturnList";
            this.buttonReturnList.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnList.TabIndex = 5;
            this.buttonReturnList.Text = "Return list";
            this.buttonReturnList.UseVisualStyleBackColor = true;
            this.buttonReturnList.Click += new System.EventHandler(this.buttonReturnList_Click);
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(7, 59);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(35, 13);
            this.labelEnter.TabIndex = 4;
            this.labelEnter.Text = "Enter:";
            // 
            // labelCriterion
            // 
            this.labelCriterion.AutoSize = true;
            this.labelCriterion.Location = new System.Drawing.Point(7, 22);
            this.labelCriterion.Name = "labelCriterion";
            this.labelCriterion.Size = new System.Drawing.Size(48, 13);
            this.labelCriterion.TabIndex = 3;
            this.labelCriterion.Text = "Criterion:";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Name",
            "Surname",
            "Age",
            "Payment type"});
            this.comboBoxSearch.Location = new System.Drawing.Point(58, 19);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(58, 56);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(166, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 353);
            this.Controls.Add(this.EmployeegroupBox);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonSaveTest);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonAddEmpl);
            this.Controls.Add(this.buttonAutoCreate);
            this.Controls.Add(this.buttonOpenTest);
            this.Controls.Add(this.groupBoxEmployees);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Employees Manager - KLaboratory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBoxEmployees.ResumeLayout(false);
            this.EmployeegroupBox.ResumeLayout(false);
            this.EmployeegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEmployeeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployees;
        private System.Windows.Forms.DataGridView billingGridView;
        private System.Windows.Forms.Button buttonAddEmpl;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.BindingSource iEmployeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button buttonSaveTest;
        private System.Windows.Forms.Button buttonAutoCreate;
        private System.Windows.Forms.Button buttonOpenTest;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelCriterion;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonReturnList;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.GroupBox EmployeegroupBox;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelDaysWorked;
        private System.Windows.Forms.Label labelHourCost;
        private System.Windows.Forms.TextBox textBoxWages;
        private System.Windows.Forms.Label labelWages;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.TextBox textBoxDaysWorked;
        private System.Windows.Forms.TextBox textBoxHourCost;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxPaymentType;
    }
}

