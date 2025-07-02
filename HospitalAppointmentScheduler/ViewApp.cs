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
    public partial class ViewApp : UserControl
    {
        DataAccess Da {  get; set; }
        public ViewApp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGidView();
        }

        public void PopulateGidView(string sql = "select * from AssignList;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from AssignList where FullName like '" + this.txtAutoSearch.Text + "%' or Name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGidView(sql);
        }
    }
}
