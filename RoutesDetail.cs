using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class RoutesDetail : MetroFramework.Forms.MetroForm
    {
        public RoutesDetail()
        {
            InitializeComponent();
        }
       
          public SqlDataAdapter da;
        public SqlDataReader dr;

        Connect dbconn = new Connect();
        DataTable dt = new DataTable();

        //Display Data in DataGridView  
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            string query = "select BusID, DriverID, TransportRunID, StartTime, StopTime from [VehicleDriver]";
            dt = dbconn.getData(query);

            metroGrid2.DataSource = dt;

        }
        private void RoutesDetail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {

            DisplayData();
      
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DistributerDashboard form = new DistributerDashboard();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DistributerDashboard form = new DistributerDashboard();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
