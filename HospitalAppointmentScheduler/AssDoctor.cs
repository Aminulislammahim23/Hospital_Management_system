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
    public partial class AssDoctor : UserControl
    {
        private DataAccess Da {  get; set; }
        public AssDoctor()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from AssignList")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                var sql = "select * from AssignList where PID = '" + this.TxtPID.Text + "'";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Patient with this ID already exists.");
                    return;
                }

                string query = "INSERT INTO AssignList VALUES('"
                + this.TxtPID.Text + "','"
                + this.txtDoctorName.Text + "','"
                + this.txtPatientName.Text + "','"
                + this.cmbChooseDept.SelectedItem.ToString() + "','"
                + this.dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "')";



                var count = this.Da.ExecuteDMLQuery(query);

                if (count == 1)
                    MessageBox.Show("Data Added Successfully");
                else
                    MessageBox.Show("Data not added please check!!!");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtPatientName.Text) || String.IsNullOrEmpty(this.txtDoctorName.Text)
            || String.IsNullOrEmpty(this.cmbChooseDept.Text))
                return false;
            else
                return true;
        }
    }
}
