namespace HRM
{
    partial class EditEmployeeForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.probationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.postTypeBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.salaryTypeBox = new System.Windows.Forms.ComboBox();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.postBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personBox = new System.Windows.Forms.ComboBox();
            this.fireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.hireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ContractIDBox = new System.Windows.Forms.TextBox();
            this.ContractTypeBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(548, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Відміна";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Посада";
            // 
            // probationDatePicker
            // 
            this.probationDatePicker.Location = new System.Drawing.Point(142, 100);
            this.probationDatePicker.Name = "probationDatePicker";
            this.probationDatePicker.Size = new System.Drawing.Size(144, 20);
            this.probationDatePicker.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Випробувальний термін";
            // 
            // postTypeBox
            // 
            this.postTypeBox.FormattingEnabled = true;
            this.postTypeBox.Location = new System.Drawing.Point(81, 72);
            this.postTypeBox.Name = "postTypeBox";
            this.postTypeBox.Size = new System.Drawing.Size(205, 21);
            this.postTypeBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Тип окладу";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Розмір";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(412, 219);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(130, 23);
            this.addEmployeeButton.TabIndex = 20;
            this.addEmployeeButton.Text = "Змінити дані";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.salaryTypeBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.salaryBox);
            this.groupBox3.Location = new System.Drawing.Point(15, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 70);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оплата праці";
            // 
            // salaryTypeBox
            // 
            this.salaryTypeBox.FormattingEnabled = true;
            this.salaryTypeBox.Location = new System.Drawing.Point(103, 11);
            this.salaryTypeBox.Name = "salaryTypeBox";
            this.salaryTypeBox.Size = new System.Drawing.Size(206, 21);
            this.salaryTypeBox.TabIndex = 3;
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(103, 38);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(100, 20);
            this.salaryBox.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Відділення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.probationDatePicker);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.postTypeBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.departmentBox);
            this.groupBox2.Controls.Add(this.postBox);
            this.groupBox2.Location = new System.Drawing.Point(337, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 133);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Місце роботи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Тип посади";
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(81, 19);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(205, 21);
            this.departmentBox.TabIndex = 3;
            // 
            // postBox
            // 
            this.postBox.FormattingEnabled = true;
            this.postBox.Location = new System.Drawing.Point(81, 46);
            this.postBox.Name = "postBox";
            this.postBox.Size = new System.Drawing.Size(205, 21);
            this.postBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Особа:";
            // 
            // personBox
            // 
            this.personBox.Enabled = false;
            this.personBox.FormattingEnabled = true;
            this.personBox.Location = new System.Drawing.Point(94, 17);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(236, 21);
            this.personBox.TabIndex = 15;
            // 
            // fireDatePicker
            // 
            this.fireDatePicker.Location = new System.Drawing.Point(106, 104);
            this.fireDatePicker.Name = "fireDatePicker";
            this.fireDatePicker.Size = new System.Drawing.Size(148, 20);
            this.fireDatePicker.TabIndex = 8;
            // 
            // hireDatePicker
            // 
            this.hireDatePicker.Location = new System.Drawing.Point(106, 76);
            this.hireDatePicker.Name = "hireDatePicker";
            this.hireDatePicker.Size = new System.Drawing.Size(148, 20);
            this.hireDatePicker.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата закінчення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дата створення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Номер договору";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип договору";
            // 
            // ContractIDBox
            // 
            this.ContractIDBox.Location = new System.Drawing.Point(106, 49);
            this.ContractIDBox.Name = "ContractIDBox";
            this.ContractIDBox.ReadOnly = true;
            this.ContractIDBox.Size = new System.Drawing.Size(203, 20);
            this.ContractIDBox.TabIndex = 2;
            // 
            // ContractTypeBox
            // 
            this.ContractTypeBox.FormattingEnabled = true;
            this.ContractTypeBox.Items.AddRange(new object[] {
            "Короткостроковий"});
            this.ContractTypeBox.Location = new System.Drawing.Point(106, 23);
            this.ContractTypeBox.Name = "ContractTypeBox";
            this.ContractTypeBox.Size = new System.Drawing.Size(203, 21);
            this.ContractTypeBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fireDatePicker);
            this.groupBox1.Controls.Add(this.hireDatePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ContractIDBox);
            this.groupBox1.Controls.Add(this.ContractTypeBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Договір";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 418);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker probationDatePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox postTypeBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox salaryTypeBox;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.ComboBox postBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox personBox;
        private System.Windows.Forms.DateTimePicker fireDatePicker;
        private System.Windows.Forms.DateTimePicker hireDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContractIDBox;
        private System.Windows.Forms.ComboBox ContractTypeBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}