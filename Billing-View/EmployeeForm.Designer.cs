namespace Billing_View
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.radioButtonSalaryPayEmployee = new System.Windows.Forms.RadioButton();
            this.radioButtonHourlyPayEmployee = new System.Windows.Forms.RadioButton();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxDaysWorked = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDaysWorked = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxHourCost = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.labelHourCost = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxTypePayment = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.employeeControl1 = new Billing_View.EmployeeControl();
            this.groupBoxTypePayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(197, 108);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(146, 20);
            this.textBoxSurname.TabIndex = 4;
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(197, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(146, 20);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(197, 134);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(146, 20);
            this.textBoxAge.TabIndex = 5;
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(11, 115);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Surname:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(11, 141);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age:";
            // 
            // radioButtonSalaryPayEmployee
            // 
            this.radioButtonSalaryPayEmployee.AutoSize = true;
            this.radioButtonSalaryPayEmployee.Location = new System.Drawing.Point(6, 19);
            this.radioButtonSalaryPayEmployee.Name = "radioButtonSalaryPayEmployee";
            this.radioButtonSalaryPayEmployee.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSalaryPayEmployee.TabIndex = 1;
            this.radioButtonSalaryPayEmployee.TabStop = true;
            this.radioButtonSalaryPayEmployee.Text = "By salary";
            this.radioButtonSalaryPayEmployee.UseVisualStyleBackColor = true;
            this.radioButtonSalaryPayEmployee.CheckedChanged += new System.EventHandler(this.radioButtonSalaryPayEmployee_CheckedChanged);
            // 
            // radioButtonHourlyPayEmployee
            // 
            this.radioButtonHourlyPayEmployee.AutoSize = true;
            this.radioButtonHourlyPayEmployee.Location = new System.Drawing.Point(6, 42);
            this.radioButtonHourlyPayEmployee.Name = "radioButtonHourlyPayEmployee";
            this.radioButtonHourlyPayEmployee.Size = new System.Drawing.Size(61, 17);
            this.radioButtonHourlyPayEmployee.TabIndex = 2;
            this.radioButtonHourlyPayEmployee.TabStop = true;
            this.radioButtonHourlyPayEmployee.Text = "By hour";
            this.radioButtonHourlyPayEmployee.UseVisualStyleBackColor = true;
            this.radioButtonHourlyPayEmployee.CheckedChanged += new System.EventHandler(this.radioButtonHourlyPayEmployee_CheckedChanged);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(197, 160);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(68, 20);
            this.textBoxSalary.TabIndex = 6;
            this.textBoxSalary.Leave += new System.EventHandler(this.textBoxSalary_Leave);
            // 
            // textBoxDaysWorked
            // 
            this.textBoxDaysWorked.Location = new System.Drawing.Point(197, 186);
            this.textBoxDaysWorked.Name = "textBoxDaysWorked";
            this.textBoxDaysWorked.Size = new System.Drawing.Size(68, 20);
            this.textBoxDaysWorked.TabIndex = 7;
            this.textBoxDaysWorked.Leave += new System.EventHandler(this.textBoxDaysWorked_Leave);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(11, 167);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 13);
            this.labelSalary.TabIndex = 11;
            this.labelSalary.Text = "Monthly salary:";
            // 
            // labelDaysWorked
            // 
            this.labelDaysWorked.AutoSize = true;
            this.labelDaysWorked.Location = new System.Drawing.Point(11, 193);
            this.labelDaysWorked.Name = "labelDaysWorked";
            this.labelDaysWorked.Size = new System.Drawing.Size(122, 13);
            this.labelDaysWorked.TabIndex = 12;
            this.labelDaysWorked.Text = "Days worked per month:";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(11, 219);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(75, 13);
            this.labelRate.TabIndex = 13;
            this.labelRate.Text = "Rate of salary:";
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(197, 212);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(68, 20);
            this.textBoxRate.TabIndex = 8;
            this.textBoxRate.Leave += new System.EventHandler(this.textBoxRate_Leave);
            // 
            // textBoxHourCost
            // 
            this.textBoxHourCost.Location = new System.Drawing.Point(197, 238);
            this.textBoxHourCost.Name = "textBoxHourCost";
            this.textBoxHourCost.Size = new System.Drawing.Size(68, 20);
            this.textBoxHourCost.TabIndex = 9;
            this.textBoxHourCost.Leave += new System.EventHandler(this.textBoxHourCost_Leave);
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(197, 264);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(68, 20);
            this.textBoxHoursWorked.TabIndex = 10;
            this.textBoxHoursWorked.Leave += new System.EventHandler(this.textBoxHoursWorked_Leave);
            // 
            // labelHourCost
            // 
            this.labelHourCost.AutoSize = true;
            this.labelHourCost.Location = new System.Drawing.Point(11, 245);
            this.labelHourCost.Name = "labelHourCost";
            this.labelHourCost.Size = new System.Drawing.Size(56, 13);
            this.labelHourCost.TabIndex = 17;
            this.labelHourCost.Text = "Hour cost:";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(11, 271);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(125, 13);
            this.labelHoursWorked.TabIndex = 18;
            this.labelHoursWorked.Text = "Amount of hours worked:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(448, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "OK";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(529, 292);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxTypePayment
            // 
            this.groupBoxTypePayment.Controls.Add(this.radioButtonSalaryPayEmployee);
            this.groupBoxTypePayment.Controls.Add(this.radioButtonHourlyPayEmployee);
            this.groupBoxTypePayment.Location = new System.Drawing.Point(16, 10);
            this.groupBoxTypePayment.Name = "groupBoxTypePayment";
            this.groupBoxTypePayment.Size = new System.Drawing.Size(181, 63);
            this.groupBoxTypePayment.TabIndex = 22;
            this.groupBoxTypePayment.TabStop = false;
            this.groupBoxTypePayment.Text = "Choose type of payment:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // employeeControl1
            // 
            this.employeeControl1.Location = new System.Drawing.Point(349, 10);
            this.employeeControl1.Name = "employeeControl1";
            this.employeeControl1.ReadOnly = false;
            this.employeeControl1.Size = new System.Drawing.Size(255, 269);
            this.employeeControl1.TabIndex = 23;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 327);
            this.Controls.Add(this.employeeControl1);
            this.Controls.Add(this.groupBoxTypePayment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelHourCost);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxHourCost);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelDaysWorked);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxDaysWorked);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.groupBoxTypePayment.ResumeLayout(false);
            this.groupBoxTypePayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.RadioButton radioButtonSalaryPayEmployee;
        private System.Windows.Forms.RadioButton radioButtonHourlyPayEmployee;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxDaysWorked;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDaysWorked;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxHourCost;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.Label labelHourCost;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxTypePayment;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private EmployeeControl employeeControl1;
    }
}