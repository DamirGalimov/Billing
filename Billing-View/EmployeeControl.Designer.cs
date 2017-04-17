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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hourlyPayEmployeeControl = new Billing_View.HourlyPayEmployeeControl();
            this.salaryPayEmployeeControl = new Billing_View.SalaryPayEmployeeControl();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // hourlyPayEmployeeControl
            // 
            this.hourlyPayEmployeeControl.Location = new System.Drawing.Point(3, 33);
            this.hourlyPayEmployeeControl.Name = "hourlyPayEmployeeControl";
            this.hourlyPayEmployeeControl.Size = new System.Drawing.Size(255, 141);
            this.hourlyPayEmployeeControl.TabIndex = 2;
            // 
            // salaryPayEmployeeControl
            // 
            this.salaryPayEmployeeControl.Location = new System.Drawing.Point(0, 33);
            this.salaryPayEmployeeControl.Name = "salaryPayEmployeeControl";
            this.salaryPayEmployeeControl.Size = new System.Drawing.Size(262, 166);
            this.salaryPayEmployeeControl.TabIndex = 3;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salaryPayEmployeeControl);
            this.Controls.Add(this.hourlyPayEmployeeControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(261, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label1;
        private HourlyPayEmployeeControl hourlyPayEmployeeControl;
        private SalaryPayEmployeeControl salaryPayEmployeeControl;
    }
}
