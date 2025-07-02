using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAppointmentScheduler
{
  
    public partial class RegPatient : UserControl
    { 
        private DataAccess Da {  get; set; }
        public RegPatient()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            PopulateGridView();
            AutoIdGenerate();
            this.dataGridView1.ClearSelection();
        }


        private void PopulateGridView(string sql = "select * from Patients")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }


        
                private void AutoIdGenerate()
                {
                    var sql = "SELECT PID FROM Patients ORDER BY PID DESC;";
                    var dt = this.Da.ExecuteQueryTable(sql);
                    var oldId = dt.Rows[0][0].ToString();
                    string[] temp = oldId.Split('-');
                    int n1 = Convert.ToInt32(temp[1]);
                    string newId = "P-" + (++n1).ToString("d3");
                    this.txtPID.Text = newId;
                }
        
        private void ClearAll()
        {
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtPhone.Clear();
            this.txtAddress.Clear();
            this.dtpDOB.Text = "";
            this.cmbBloodGroup.SelectedIndex = -1;
            this.cmbGender.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                DialogResult result = MessageBox.Show("Are you sure to delete this Item?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;


                var fsl = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                var query = "delete from Patients where PID = '" + fsl + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count > 0)
                    MessageBox.Show("Data remove successfully");
                else
                    MessageBox.Show("Data not remove please check!!!");

                this.ClearAll();
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        if (!this.IsValidToSave())
        {
            MessageBox.Show("Please fill all the information");
            return;
        }

        var sql = "select * from Patients where PID = '" + this.txtPID.Text + "';";
        var ds = this.Da.ExecuteQuery(sql);

        if (ds.Tables[0].Rows.Count == 1)
        {
            string query = "update Patients set " +
                           "Name = '" + this.txtName.Text + "', " +
                           "BloodG = '" + this.cmbBloodGroup.SelectedItem?.ToString() + "', " +
                           "Phone = '" + this.txtPhone.Text + "', " +
                           "Age = '" + this.txtAge.Text + "', " +
                           "Gender = '" + this.cmbGender.SelectedItem?.ToString() + "', " +
                           "Address = '" + this.txtAddress.Text + "', " +
                           "DOB = '" + this.dtpDOB.Value.ToString("yyyy-MM-dd") + "' " +
                           "where PID = '" + this.txtPID.Text + "';";

            var count = this.Da.ExecuteDMLQuery(query);

            if (count == 1)
                MessageBox.Show("Data Updated Successfully");
            else
                MessageBox.Show("Data not updated, please check!");
        }
        else
        {
            MessageBox.Show("No matching patient found to update.");
        }

        this.AutoIdGenerate();
        this.PopulateGridView();
    }
    catch (Exception exc)
    {
        MessageBox.Show("Error!! ...please check...\n" + exc.Message);
    }
}


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                var sql = "select * from Patients where PID = '" + this.txtPID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Patient with this ID already exists.");
                    return;
                }

                string query = "insert into Patients values('" + this.txtPID.Text + "','"
                               + this.txtName.Text + "','"
                               + this.cmbBloodGroup.SelectedItem?.ToString() + "','"
                               + this.txtPhone.Text + "','"
                               + this.txtAge.Text + "','"
                               + this.cmbGender.SelectedItem?.ToString() + "','"
                               + this.txtAddress.Text + "','"
                               + this.dtpDOB.Value.ToString("yyyy-MM-dd") + "')";

                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("Data Added Successfully");
                else
                    MessageBox.Show("Data not added please check!!!");

                this.AutoIdGenerate();
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtPID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txtAddress.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            this.dtpDOB.Value = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[7].Value);
            this.cmbGender.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.cmbBloodGroup.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txtAge.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtPID.Text) || String.IsNullOrEmpty(this.txtName.Text)
            || String.IsNullOrEmpty(this.cmbBloodGroup.Text) || String.IsNullOrEmpty(this.txtPhone.Text)
            || String.IsNullOrEmpty(this.txtAge.Text)  || String.IsNullOrEmpty(this.cmbGender.Text) 
            || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.dtpDOB.Text))
                return false;
            else
                return true;
        }
    }
}
