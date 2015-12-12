namespace HRM
{
    partial class AddPerson
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Name_lb = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cvButton = new System.Windows.Forms.Button();
            this.photoBrowse = new System.Windows.Forms.Button();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.l2 = new System.Windows.Forms.Label();
            this.l8 = new System.Windows.Forms.Label();
            this.l7 = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.Sex = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.Certificate = new System.Windows.Forms.TextBox();
            this.IDCod = new System.Windows.Forms.TextBox();
            this.LiveLoc = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.WorkPhone = new System.Windows.Forms.TextBox();
            this.tabPrivate = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridLanguage = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridFamily = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Invalidity = new System.Windows.Forms.TextBox();
            this.Military = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.tabWork = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridEducation = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridWork = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.tabPrivate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamily)).BeginInit();
            this.tabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEducation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWork)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(103, 16);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(252, 16);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(100, 20);
            this.MiddleName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(394, 16);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 2;
            // 
            // Name_lb
            // 
            this.Name_lb.AutoSize = true;
            this.Name_lb.Location = new System.Drawing.Point(27, 19);
            this.Name_lb.Name = "Name_lb";
            this.Name_lb.Size = new System.Drawing.Size(34, 13);
            this.Name_lb.TabIndex = 3;
            this.Name_lb.Text = "П.І.Б.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabPrivate);
            this.tabControl1.Controls.Add(this.tabWork);
            this.tabControl1.Location = new System.Drawing.Point(16, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 384);
            this.tabControl1.TabIndex = 4;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.dateTimePicker1);
            this.tabGeneral.Controls.Add(this.cvButton);
            this.tabGeneral.Controls.Add(this.photoBrowse);
            this.tabGeneral.Controls.Add(this.photoBox);
            this.tabGeneral.Controls.Add(this.l2);
            this.tabGeneral.Controls.Add(this.l8);
            this.tabGeneral.Controls.Add(this.l7);
            this.tabGeneral.Controls.Add(this.l6);
            this.tabGeneral.Controls.Add(this.l5);
            this.tabGeneral.Controls.Add(this.l4);
            this.tabGeneral.Controls.Add(this.l3);
            this.tabGeneral.Controls.Add(this.l1);
            this.tabGeneral.Controls.Add(this.Sex);
            this.tabGeneral.Controls.Add(this.Location);
            this.tabGeneral.Controls.Add(this.Certificate);
            this.tabGeneral.Controls.Add(this.IDCod);
            this.tabGeneral.Controls.Add(this.LiveLoc);
            this.tabGeneral.Controls.Add(this.Phone);
            this.tabGeneral.Controls.Add(this.WorkPhone);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(602, 358);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Загальні";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // cvButton
            // 
            this.cvButton.Location = new System.Drawing.Point(455, 267);
            this.cvButton.Name = "cvButton";
            this.cvButton.Size = new System.Drawing.Size(128, 23);
            this.cvButton.TabIndex = 23;
            this.cvButton.Text = "Резюме";
            this.cvButton.UseVisualStyleBackColor = true;
            // 
            // photoBrowse
            // 
            this.photoBrowse.Location = new System.Drawing.Point(455, 201);
            this.photoBrowse.Name = "photoBrowse";
            this.photoBrowse.Size = new System.Drawing.Size(128, 23);
            this.photoBrowse.TabIndex = 22;
            this.photoBrowse.Text = "Змінити фото";
            this.photoBrowse.UseVisualStyleBackColor = true;
            // 
            // photoBox
            // 
            this.photoBox.Location = new System.Drawing.Point(455, 51);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(128, 144);
            this.photoBox.TabIndex = 21;
            this.photoBox.TabStop = false;
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(262, 58);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(39, 13);
            this.l2.TabIndex = 20;
            this.l2.Text = "Стать:";
            // 
            // l8
            // 
            this.l8.AutoSize = true;
            this.l8.Location = new System.Drawing.Point(3, 314);
            this.l8.Name = "l8";
            this.l8.Size = new System.Drawing.Size(112, 13);
            this.l8.TabIndex = 19;
            this.l8.Text = "Службовий телефон:";
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Location = new System.Drawing.Point(3, 270);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(55, 13);
            this.l7.TabIndex = 18;
            this.l7.Text = "Телефон:";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Location = new System.Drawing.Point(5, 236);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(112, 13);
            this.l6.TabIndex = 17;
            this.l6.Text = "Адреса проживання:";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(5, 182);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(117, 13);
            this.l5.TabIndex = 16;
            this.l5.Text = "Ідентифікаційний код:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(5, 141);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(73, 13);
            this.l4.TabIndex = 15;
            this.l4.Text = "Посвідчення:";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(5, 100);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(104, 13);
            this.l3.TabIndex = 14;
            this.l3.Text = "Місце народження:";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(5, 58);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(101, 13);
            this.l1.TabIndex = 13;
            this.l1.Text = "Дата народження:";
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(307, 51);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(100, 20);
            this.Sex.TabIndex = 12;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(129, 93);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(278, 20);
            this.Location.TabIndex = 6;
            // 
            // Certificate
            // 
            this.Certificate.Location = new System.Drawing.Point(129, 134);
            this.Certificate.Name = "Certificate";
            this.Certificate.Size = new System.Drawing.Size(278, 20);
            this.Certificate.TabIndex = 7;
            // 
            // IDCod
            // 
            this.IDCod.Location = new System.Drawing.Point(129, 175);
            this.IDCod.Name = "IDCod";
            this.IDCod.Size = new System.Drawing.Size(278, 20);
            this.IDCod.TabIndex = 8;
            // 
            // LiveLoc
            // 
            this.LiveLoc.Location = new System.Drawing.Point(132, 229);
            this.LiveLoc.Name = "LiveLoc";
            this.LiveLoc.Size = new System.Drawing.Size(275, 20);
            this.LiveLoc.TabIndex = 9;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(132, 267);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(275, 20);
            this.Phone.TabIndex = 10;
            // 
            // WorkPhone
            // 
            this.WorkPhone.Location = new System.Drawing.Point(132, 307);
            this.WorkPhone.Name = "WorkPhone";
            this.WorkPhone.Size = new System.Drawing.Size(275, 20);
            this.WorkPhone.TabIndex = 11;
            // 
            // tabPrivate
            // 
            this.tabPrivate.Controls.Add(this.label5);
            this.tabPrivate.Controls.Add(this.dataGridLanguage);
            this.tabPrivate.Controls.Add(this.label4);
            this.tabPrivate.Controls.Add(this.dataGridFamily);
            this.tabPrivate.Controls.Add(this.label3);
            this.tabPrivate.Controls.Add(this.label2);
            this.tabPrivate.Controls.Add(this.label1);
            this.tabPrivate.Controls.Add(this.Invalidity);
            this.tabPrivate.Controls.Add(this.Military);
            this.tabPrivate.Controls.Add(this.Nationality);
            this.tabPrivate.Location = new System.Drawing.Point(4, 22);
            this.tabPrivate.Name = "tabPrivate";
            this.tabPrivate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrivate.Size = new System.Drawing.Size(602, 358);
            this.tabPrivate.TabIndex = 1;
            this.tabPrivate.Text = "Персональні дані";
            this.tabPrivate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дані про знання мов:";
            // 
            // dataGridLanguage
            // 
            this.dataGridLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLanguage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataGridLanguage.Location = new System.Drawing.Point(141, 240);
            this.dataGridLanguage.Name = "dataGridLanguage";
            this.dataGridLanguage.Size = new System.Drawing.Size(345, 100);
            this.dataGridLanguage.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Мова";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Рівень зання";
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дані про сім\'ю:";
            // 
            // dataGridFamily
            // 
            this.dataGridFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridFamily.Location = new System.Drawing.Point(141, 114);
            this.dataGridFamily.Name = "dataGridFamily";
            this.dataGridFamily.Size = new System.Drawing.Size(345, 107);
            this.dataGridFamily.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Родич";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Ім\'я";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Дата народження";
            this.Column3.Name = "Column3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Інвалідність:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Військовий облік:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Громадянство:";
            // 
            // Invalidity
            // 
            this.Invalidity.Location = new System.Drawing.Point(141, 78);
            this.Invalidity.Name = "Invalidity";
            this.Invalidity.Size = new System.Drawing.Size(345, 20);
            this.Invalidity.TabIndex = 2;
            // 
            // Military
            // 
            this.Military.Location = new System.Drawing.Point(141, 46);
            this.Military.Name = "Military";
            this.Military.Size = new System.Drawing.Size(345, 20);
            this.Military.TabIndex = 1;
            // 
            // Nationality
            // 
            this.Nationality.Location = new System.Drawing.Point(141, 16);
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(345, 20);
            this.Nationality.TabIndex = 0;
            // 
            // tabWork
            // 
            this.tabWork.Controls.Add(this.label7);
            this.tabWork.Controls.Add(this.label6);
            this.tabWork.Controls.Add(this.dataGridEducation);
            this.tabWork.Controls.Add(this.dataGridWork);
            this.tabWork.Location = new System.Drawing.Point(4, 22);
            this.tabWork.Name = "tabWork";
            this.tabWork.Size = new System.Drawing.Size(602, 358);
            this.tabWork.TabIndex = 2;
            this.tabWork.Text = "Кваліфікація";
            this.tabWork.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Трудова діяльність";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Освіта";
            // 
            // dataGridEducation
            // 
            this.dataGridEducation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEducation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridEducation.Location = new System.Drawing.Point(26, 27);
            this.dataGridEducation.Name = "dataGridEducation";
            this.dataGridEducation.Size = new System.Drawing.Size(547, 130);
            this.dataGridEducation.TabIndex = 10;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Вид";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ВУЗ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Спеціальність";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Диплом";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Рік завершення";
            this.Column10.Name = "Column10";
            // 
            // dataGridWork
            // 
            this.dataGridWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dataGridWork.Location = new System.Drawing.Point(26, 183);
            this.dataGridWork.Name = "dataGridWork";
            this.dataGridWork.Size = new System.Drawing.Size(547, 150);
            this.dataGridWork.TabIndex = 0;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Місце роботи";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Початок роботи";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Завершення роботи";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Посада";
            this.Column14.Name = "Column14";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(275, 445);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(392, 445);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(102, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Відмінити";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 480);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Name_lb);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Name = "AddPerson";
            this.Text = "Додавання фізичної особи";
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.tabPrivate.ResumeLayout(false);
            this.tabPrivate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFamily)).EndInit();
            this.tabWork.ResumeLayout(false);
            this.tabWork.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEducation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label Name_lb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l8;
        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label l6;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox Certificate;
        private System.Windows.Forms.TextBox IDCod;
        private System.Windows.Forms.TextBox LiveLoc;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox WorkPhone;
        private System.Windows.Forms.TabPage tabPrivate;
        private System.Windows.Forms.TabPage tabWork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridFamily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Invalidity;
        private System.Windows.Forms.TextBox Military;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dataGridEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridView dataGridWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button photoBrowse;
        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cvButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}