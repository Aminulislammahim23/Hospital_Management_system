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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 10;
            StartingProgress.Value = startpoint;
            if (StartingProgress.Value == 100)
            {
                StartingProgress.Value = 0;
                timer1.Stop();
                StuffModule sModule = new StuffModule();
                this.Hide();
                sModule.Show();
            }
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
