namespace WindowsFormsApp1
{
    partial class PersonList
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonList));
            this.gridViewPerson = new System.Windows.Forms.DataGridView();
            this.TCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uInt64ConverterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbBoxType = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.recordWriterFactoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uInt64ConverterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordWriterFactoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewPerson
            // 
            this.gridViewPerson.AllowUserToAddRows = false;
            this.gridViewPerson.AutoGenerateColumns = false;
            this.gridViewPerson.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCNo,
            this.name,
            this.surname,
            this.gender,
            this.birthdate});
            this.gridViewPerson.DataSource = this.uInt64ConverterBindingSource;
            this.gridViewPerson.Location = new System.Drawing.Point(31, 84);
            this.gridViewPerson.Name = "gridViewPerson";
            this.gridViewPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewPerson.Size = new System.Drawing.Size(544, 205);
            this.gridViewPerson.TabIndex = 0;
            this.gridViewPerson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TCNo
            // 
            this.TCNo.DataPropertyName = "TCNo";
            this.TCNo.HeaderText = "TC NO";
            this.TCNo.Name = "TCNo";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "SURNAME";
            this.surname.Name = "surname";
            this.surname.Width = 101;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "GENDER";
            this.gender.Name = "gender";
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "Birthday";
            this.birthdate.HeaderText = "BIRTH DATE";
            this.birthdate.Name = "birthdate";
            // 
            // uInt64ConverterBindingSource
            // 
            this.uInt64ConverterBindingSource.DataSource = typeof(CsvHelper.TypeConversion.UInt64Converter);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(598, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(181, 50);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(598, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(598, 236);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // cmbBoxType
            // 
            this.cmbBoxType.FormattingEnabled = true;
            this.cmbBoxType.Location = new System.Drawing.Point(153, 310);
            this.cmbBoxType.Name = "cmbBoxType";
            this.cmbBoxType.Size = new System.Drawing.Size(116, 21);
            this.cmbBoxType.TabIndex = 6;
            this.cmbBoxType.SelectedIndexChanged += new System.EventHandler(this.cmbBoxType_SelectedIndexChanged);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(297, 310);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 21);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "EXPORT";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(442, 310);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(131, 21);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // recordWriterFactoryBindingSource
            // 
            this.recordWriterFactoryBindingSource.DataSource = typeof(CsvHelper.Expressions.RecordWriterFactory);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(WindowsFormsApp1.Person);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(WindowsFormsApp1.Person);
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataSource = typeof(WindowsFormsApp1.Person);
            // 
            // personBindingSource3
            // 
            this.personBindingSource3.DataSource = typeof(WindowsFormsApp1.Person);
            // 
            // PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 436);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cmbBoxType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gridViewPerson);
            this.Name = "PersonList";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.PersonList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uInt64ConverterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordWriterFactoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.DataGridView gridViewPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ComboBox cmbBoxType;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource personBindingSource1;
        private System.Windows.Forms.BindingSource recordWriterFactoryBindingSource;
        private System.Windows.Forms.BindingSource personBindingSource2;
        private System.Windows.Forms.BindingSource personBindingSource3;
        private System.Windows.Forms.BindingSource uInt64ConverterBindingSource;
    }
}

