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
    public partial class StuffModule : Form
    {
        public StuffModule()
        {
            InitializeComponent();
        }


        private void AddUserControl(UserControl userControl)
        {
            Pnldefult.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Pnldefult.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDoctorAvailability_Click(object sender, EventArgs e)
        {
            AddUserControl(new DoctorAvl());
        }

        private void btnRegisterPatients_Click(object sender, EventArgs e)
        {
            AddUserControl(new RegPatient());
        }

        private void btnScheduleAppointments_Click(object sender, EventArgs e)
        {
            AddUserControl(new ScheduleApp());
        }
        private void btnAssignDoctor_Click(object sender, EventArgs e)
        {
            AddUserControl(new AssDoctor());
        }

        private void btnViewAppointment_Click(object sender, EventArgs e)
        {
            AddUserControl(new ViewApp());
        }

        private void StuffModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
