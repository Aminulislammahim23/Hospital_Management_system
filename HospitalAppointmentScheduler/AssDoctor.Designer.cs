namespace HospitalAppointmentScheduler
{
    partial class AssDoctor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbChooseDept = new System.Windows.Forms.ComboBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblChooseDept = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hasDBDataSet = new HospitalAppointmentScheduler.hasDBDataSet();
            this.assignListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignListTableAdapter = new HospitalAppointmentScheduler.hasDBDataSetTableAdapters.AssignListTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new HospitalAppointmentScheduler.hasDBDataSetTableAdapters.DoctorsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmbDoctor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtPID);
            this.panel1.Controls.Add(this.cmbChooseDept);
            this.panel1.Controls.Add(this.btnAssign);
            this.panel1.Controls.Add(this.txtDoctorName);
            this.panel1.Controls.Add(this.txtPatientName);
            this.panel1.Controls.Add(this.lblPatientName);
            this.panel1.Controls.Add(this.lblDoctorName);
            this.panel1.Controls.Add(this.lblChooseDept);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 643);
            this.panel1.TabIndex = 0;
            // 
            // cmbChooseDept
            // 
            this.cmbChooseDept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.assignListBindingSource, "FullName", true));
            this.cmbChooseDept.FormattingEnabled = true;
            this.cmbChooseDept.Items.AddRange(new object[] {
            "Cardiology",
            "Neurology",
            "Orthopedics",
            "Pediatrics",
            "Gynecology & Obstetrics",
            "Dermatology",
            "ENT",
            "General Surgery",
            "Internal Medicine",
            "Urology",
            "Nephrology",
            "Gastroenterology",
            "Psychiatry",
            "Oncology",
            "Radiology",
            "Anesthesiology",
            "Endocrinology",
            "Pulmonology",
            "Hematology",
            "Emergency Medicine"});
            this.cmbChooseDept.Location = new System.Drawing.Point(138, 293);
            this.cmbChooseDept.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChooseDept.Name = "cmbChooseDept";
            this.cmbChooseDept.Size = new System.Drawing.Size(131, 21);
            this.cmbChooseDept.TabIndex = 108;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(96, 370);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(72, 31);
            this.btnAssign.TabIndex = 107;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(138, 253);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(131, 19);
            this.txtDoctorName.TabIndex = 105;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(138, 215);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(131, 19);
            this.txtPatientName.TabIndex = 106;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(19, 216);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(102, 16);
            this.lblPatientName.TabIndex = 104;
            this.lblPatientName.Text = "Patient Name";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(19, 253);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(102, 16);
            this.lblDoctorName.TabIndex = 103;
            this.lblDoctorName.Text = "Doctor Name";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChooseDept
            // 
            this.lblChooseDept.AutoSize = true;
            this.lblChooseDept.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDept.Location = new System.Drawing.Point(19, 295);
            this.lblChooseDept.Name = "lblChooseDept";
            this.lblChooseDept.Size = new System.Drawing.Size(99, 16);
            this.lblChooseDept.TabIndex = 102;
            this.lblChooseDept.Text = "Choose Dept";
            this.lblChooseDept.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(288, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 643);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.aPPTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(716, 643);
            this.dataGridView1.TabIndex = 0;
            // 
            // hasDBDataSet
            // 
            this.hasDBDataSet.DataSetName = "hasDBDataSet";
            this.hasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignListBindingSource
            // 
            this.assignListBindingSource.DataMember = "AssignList";
            this.assignListBindingSource.DataSource = this.hasDBDataSet;
            // 
            // assignListTableAdapter
            // 
            this.assignListTableAdapter.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Department";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.Width = 150;
            // 
            // aPPTimeDataGridViewTextBoxColumn
            // 
            this.aPPTimeDataGridViewTextBoxColumn.DataPropertyName = "APPTime";
            this.aPPTimeDataGridViewTextBoxColumn.HeaderText = "Appointment Time";
            this.aPPTimeDataGridViewTextBoxColumn.Name = "aPPTimeDataGridViewTextBoxColumn";
            // 
            // TxtPID
            // 
            this.TxtPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPID.Location = new System.Drawing.Point(138, 176);
            this.TxtPID.Name = "TxtPID";
            this.TxtPID.Size = new System.Drawing.Size(131, 19);
            this.TxtPID.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Patient ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(138, 420);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(131, 21);
            this.cmbDoctor.TabIndex = 111;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 335);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.hasDBDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // AssDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AssDoctor";
            this.Size = new System.Drawing.Size(1004, 643);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hasDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbChooseDept;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblChooseDept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hasDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource assignListBindingSource;
        private hasDBDataSet hasDBDataSet;
        private hasDBDataSetTableAdapters.AssignListTableAdapter assignListTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPID;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private hasDBDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
    }
}
