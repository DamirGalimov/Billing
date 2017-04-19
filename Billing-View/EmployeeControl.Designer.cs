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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hourlyPayEmployeeControl1 = new Billing_View.HourlyPayEmployeeControl();
            this.salaryPayEmployeeControl1 = new Billing_View.SalaryPayEmployeeControl();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // hourlyPayEmployeeControl1
            // 
            this.hourlyPayEmployeeControl1.Location = new System.Drawing.Point(13, 48);
            this.hourlyPayEmployeeControl1.Name = "hourlyPayEmployeeControl1";
            this.hourlyPayEmployeeControl1.Size = new System.Drawing.Size(255, 141);
            this.hourlyPayEmployeeControl1.TabIndex = 1;
            // 
            // salaryPayEmployeeControl1
            // 
            this.salaryPayEmployeeControl1.Location = new System.Drawing.Point(9, 48);
            this.salaryPayEmployeeControl1.Name = "salaryPayEmployeeControl1";
            this.salaryPayEmployeeControl1.Size = new System.Drawing.Size(262, 166);
            this.salaryPayEmployeeControl1.TabIndex = 2;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salaryPayEmployeeControl1);
            this.Controls.Add(this.hourlyPayEmployeeControl1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(271, 261);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private HourlyPayEmployeeControl hourlyPayEmployeeControl1;
        private SalaryPayEmployeeControl salaryPayEmployeeControl1;
    }
}
