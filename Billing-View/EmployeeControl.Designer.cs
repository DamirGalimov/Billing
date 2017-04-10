namespace Billing_View
{
    partial class EmployeeControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelWages = new System.Windows.Forms.Label();
            this.labelHourCost = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.labelDaysWorked = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxDaysWorked = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxHourCost = new System.Windows.Forms.TextBox();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.textBoxWages = new System.Windows.Forms.TextBox();
            this.errorProviderC = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderC)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "By salary",
            "By hour"});
            this.comboBox.Location = new System.Drawing.Point(133, 6);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose type of payment:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 62);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(3, 88);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age:";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(3, 166);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(75, 13);
            this.labelRate.TabIndex = 5;
            this.labelRate.Text = "Rate of salary:";
            // 
            // labelWages
            // 
            this.labelWages.AutoSize = true;
            this.labelWages.Location = new System.Drawing.Point(3, 244);
            this.labelWages.Name = "labelWages";
            this.labelWages.Size = new System.Drawing.Size(44, 13);
            this.labelWages.TabIndex = 6;
            this.labelWages.Text = "Wages:";
            // 
            // labelHourCost
            // 
            this.labelHourCost.AutoSize = true;
            this.labelHourCost.Location = new System.Drawing.Point(3, 192);
            this.labelHourCost.Name = "labelHourCost";
            this.labelHourCost.Size = new System.Drawing.Size(56, 13);
            this.labelHourCost.TabIndex = 7;
            this.labelHourCost.Text = "Hour cost:";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Location = new System.Drawing.Point(3, 218);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(125, 13);
            this.labelHoursWorked.TabIndex = 8;
            this.labelHoursWorked.Text = "Amount of hours worked:";
            // 
            // labelDaysWorked
            // 
            this.labelDaysWorked.AutoSize = true;
            this.labelDaysWorked.Location = new System.Drawing.Point(3, 140);
            this.labelDaysWorked.Name = "labelDaysWorked";
            this.labelDaysWorked.Size = new System.Drawing.Size(72, 13);
            this.labelDaysWorked.TabIndex = 9;
            this.labelDaysWorked.Text = "Days worked:";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(3, 114);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(77, 13);
            this.labelSalary.TabIndex = 10;
            this.labelSalary.Text = "Monthly salary:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(133, 59);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 12;
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(133, 85);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 13;
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(133, 163);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxRate.TabIndex = 14;
            this.textBoxRate.Leave += new System.EventHandler(this.textBoxRate_Leave);
            // 
            // textBoxDaysWorked
            // 
            this.textBoxDaysWorked.Location = new System.Drawing.Point(133, 137);
            this.textBoxDaysWorked.Name = "textBoxDaysWorked";
            this.textBoxDaysWorked.Size = new System.Drawing.Size(100, 20);
            this.textBoxDaysWorked.TabIndex = 15;
            this.textBoxDaysWorked.Leave += new System.EventHandler(this.textBoxDaysWorked_Leave);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(133, 111);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalary.TabIndex = 16;
            this.textBoxSalary.Leave += new System.EventHandler(this.textBoxSalary_Leave);
            // 
            // textBoxHourCost
            // 
            this.textBoxHourCost.Location = new System.Drawing.Point(133, 189);
            this.textBoxHourCost.Name = "textBoxHourCost";
            this.textBoxHourCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxHourCost.TabIndex = 17;
            this.textBoxHourCost.Leave += new System.EventHandler(this.textBoxHourCost_Leave);
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(133, 215);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoursWorked.TabIndex = 18;
            this.textBoxHoursWorked.Leave += new System.EventHandler(this.textBoxHoursWorked_Leave);
            // 
            // textBoxWages
            // 
            this.textBoxWages.Location = new System.Drawing.Point(134, 241);
            this.textBoxWages.Name = "textBoxWages";
            this.textBoxWages.ReadOnly = true;
            this.textBoxWages.Size = new System.Drawing.Size(100, 20);
            this.textBoxWages.TabIndex = 19;
            // 
            // errorProviderC
            // 
            this.errorProviderC.ContainerControl = this;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxWages);
            this.Controls.Add(this.textBoxHoursWorked);
            this.Controls.Add(this.textBoxHourCost);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxDaysWorked);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelDaysWorked);
            this.Controls.Add(this.labelHoursWorked);
            this.Controls.Add(this.labelHourCost);
            this.Controls.Add(this.labelWages);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(263, 269);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelWages;
        private System.Windows.Forms.Label labelHourCost;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Label labelDaysWorked;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxDaysWorked;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxHourCost;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.TextBox textBoxWages;
        private System.Windows.Forms.ErrorProvider errorProviderC;
    }
}
