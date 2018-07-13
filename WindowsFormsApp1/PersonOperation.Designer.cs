namespace WindowsFormsApp1
{
    partial class PersonOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonOperation));
            this.txtTC = new System.Windows.Forms.TextBox();
            this.P_TC = new System.Windows.Forms.Label();
            this.P_Name = new System.Windows.Forms.Label();
            this.P_Surname = new System.Windows.Forms.Label();
            this.P_Gender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbBoxGender = new System.Windows.Forms.ComboBox();
            this.P_BirthDate = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(159, 47);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(170, 20);
            this.txtTC.TabIndex = 0;
            // 
            // P_TC
            // 
            this.P_TC.AutoSize = true;
            this.P_TC.Location = new System.Drawing.Point(34, 47);
            this.P_TC.Name = "P_TC";
            this.P_TC.Size = new System.Drawing.Size(27, 13);
            this.P_TC.TabIndex = 1;
            this.P_TC.Text = "T.C.";
            // 
            // P_Name
            // 
            this.P_Name.AutoSize = true;
            this.P_Name.Location = new System.Drawing.Point(37, 108);
            this.P_Name.Name = "P_Name";
            this.P_Name.Size = new System.Drawing.Size(35, 13);
            this.P_Name.TabIndex = 2;
            this.P_Name.Text = "Name";
            // 
            // P_Surname
            // 
            this.P_Surname.AutoSize = true;
            this.P_Surname.Location = new System.Drawing.Point(37, 172);
            this.P_Surname.Name = "P_Surname";
            this.P_Surname.Size = new System.Drawing.Size(49, 13);
            this.P_Surname.TabIndex = 3;
            this.P_Surname.Text = "Surname";
            // 
            // P_Gender
            // 
            this.P_Gender.AutoSize = true;
            this.P_Gender.Location = new System.Drawing.Point(37, 234);
            this.P_Gender.Name = "P_Gender";
            this.P_Gender.Size = new System.Drawing.Size(42, 13);
            this.P_Gender.TabIndex = 4;
            this.P_Gender.Text = "Gender";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(159, 172);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(170, 20);
            this.txtSurname.TabIndex = 6;
            // 
            // cmbBoxGender
            // 
            this.cmbBoxGender.FormattingEnabled = true;
            this.cmbBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbBoxGender.Location = new System.Drawing.Point(159, 234);
            this.cmbBoxGender.Name = "cmbBoxGender";
            this.cmbBoxGender.Size = new System.Drawing.Size(170, 21);
            this.cmbBoxGender.TabIndex = 7;
            // 
            // P_BirthDate
            // 
            this.P_BirthDate.AutoSize = true;
            this.P_BirthDate.Location = new System.Drawing.Point(40, 307);
            this.P_BirthDate.Name = "P_BirthDate";
            this.P_BirthDate.Size = new System.Drawing.Size(54, 13);
            this.P_BirthDate.TabIndex = 8;
            this.P_BirthDate.Text = "Birth Date";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOK.Location = new System.Drawing.Point(43, 468);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 42);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Location = new System.Drawing.Point(198, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(129, 307);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDatePicker.TabIndex = 14;
            // 
            // PersonOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(381, 569);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.P_BirthDate);
            this.Controls.Add(this.cmbBoxGender);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.P_Gender);
            this.Controls.Add(this.P_Surname);
            this.Controls.Add(this.P_Name);
            this.Controls.Add(this.P_TC);
            this.Controls.Add(this.txtTC);
            this.Name = "PersonOperation";
            this.Text = "Person Operation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label P_TC;
        private System.Windows.Forms.Label P_Name;
        private System.Windows.Forms.Label P_Surname;
        private System.Windows.Forms.Label P_Gender;
        private System.Windows.Forms.Label P_BirthDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtTC;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.ComboBox cmbBoxGender;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
    }
}