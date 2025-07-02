namespace HospitalAppointmentScheduler
{
    partial class ViewApp
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.hasDBDataSet = new HospitalAppointmentScheduler.hasDBDataSet();
            this.assignListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignListTableAdapter = new HospitalAppointmentScheduler.hasDBDataSetTableAdapters.AssignListTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 643);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 517);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.specialtyDataGridViewTextBoxColumn,
            this.aPPTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 517);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.txtAutoSearch);
            this.panel2.Controls.Add(this.lblPatientName);
            this.panel2.Controls.Add(this.lblDoctorName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 126);
            this.panel2.TabIndex = 0;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoSearch.Location = new System.Drawing.Point(88, 92);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(229, 20);
            this.txtAutoSearch.TabIndex = 81;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(30, 92);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(55, 16);
            this.lblPatientName.TabIndex = 79;
            this.lblPatientName.Text = "Search";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(86, 78);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(150, 11);
            this.lblDoctorName.TabIndex = 78;
            this.lblDoctorName.Text = "Search by Patient/Doctor Name";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pIDDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Doctor Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 220;
            // 
            // specialtyDataGridViewTextBoxColumn
            // 
            this.specialtyDataGridViewTextBoxColumn.DataPropertyName = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.HeaderText = "Specialty";
            this.specialtyDataGridViewTextBoxColumn.Name = "specialtyDataGridViewTextBoxColumn";
            this.specialtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialtyDataGridViewTextBoxColumn.Width = 200;
            // 
            // aPPTimeDataGridViewTextBoxColumn
            // 
            this.aPPTimeDataGridViewTextBoxColumn.DataPropertyName = "APPTime";
            this.aPPTimeDataGridViewTextBoxColumn.HeaderText = "APPTime";
            this.aPPTimeDataGridViewTextBoxColumn.Name = "aPPTimeDataGridViewTextBoxColumn";
            this.aPPTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPPTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // ViewApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ViewApp";
            this.Size = new System.Drawing.Size(1004, 643);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource assignListBindingSource;
        private hasDBDataSet hasDBDataSet;
        private hasDBDataSetTableAdapters.AssignListTableAdapter assignListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPPTimeDataGridViewTextBoxColumn;
    }
}
