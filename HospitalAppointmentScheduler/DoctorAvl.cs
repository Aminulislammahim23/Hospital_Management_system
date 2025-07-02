using System;
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
    public partial class DoctorAvl : UserControl
    {
        DataAccess Da {  get; set; }
        public DoctorAvl()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGidView();
        }

        public void PopulateGidView(string sql = "select * from Doctors;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                string query = null;
                var sql = "select * from Doctors where DoctorID = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                                    query = @"UPDATE Doctors
                                    SET AvailableTime = '" + this.dtpDate.Text + @"', 
                                    AvailabilityStatus = '" + this.cmbAvailability.SelectedItem + @"' 
                                    WHERE DoctorID = '" + this.txtID.Text + "';";


                    var count = this.Da.ExecuteDMLQuery(query);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    
                }

                this.PopulateGidView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error has occured:\n" + exc.Message);
            }
        }
        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.cmbChooseDoctor.Text) || String.IsNullOrEmpty(this.dtpDate.Text)
            || String.IsNullOrEmpty(this.cmbAvailability.Text))
                return false;
            else
                return true;
        }

        private void ClearAll()
        {
            this.txtID.Clear();
            this.cmbChooseDoctor.SelectedIndex = -1; 
            this.cmbAvailability.SelectedIndex = -1;
            this.dtpDate.Value = DateTime.Now; 
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.cmbChooseDoctor.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.cmbAvailability.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            this.dtpDate.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
