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
            this.hourlyPayEmployeeControl = new Billing_View.HourlyPayEmployeeControl();
            this.salaryPayEmployeeControl = new Billing_View.SalaryPayEmployeeControl();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // hourlyPayEmployeeControl
            // 
            this.hourlyPayEmployeeControl.Location = new System.Drawing.Point(3, 46);
            this.hourlyPayEmployeeControl.Name = "hourlyPayEmployeeControl";
            this.hourlyPayEmployeeControl.Size = new System.Drawing.Size(255, 141);
            this.hourlyPayEmployeeControl.TabIndex = 0;
            // 
            // salaryPayEmployeeControl
            // 
            this.salaryPayEmployeeControl.Location = new System.Drawing.Point(0, 46);
            this.salaryPayEmployeeControl.Name = "salaryPayEmployeeControl";
            this.salaryPayEmployeeControl.Size = new System.Drawing.Size(262, 166);
            this.salaryPayEmployeeControl.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "By hour",
            "By salary"});
            this.comboBox.Location = new System.Drawing.Point(14, 19);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // EmployeeControl
            // 
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.salaryPayEmployeeControl);
            this.Controls.Add(this.hourlyPayEmployeeControl);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(243, 214);
            this.ResumeLayout(false);

        }

        #endregion

        private HourlyPayEmployeeControl hourlyPayEmployeeControl;
        private SalaryPayEmployeeControl salaryPayEmployeeControl;
        private System.Windows.Forms.ComboBox comboBox;
    }
}
