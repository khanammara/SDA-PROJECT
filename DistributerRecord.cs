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
    public partial class DistributerRecord : MetroFramework.Forms.MetroForm
    {
        public SqlDataAdapter da;
        public SqlDataReader dr;

        Connect dbconn = new Connect();
        DataTable dt = new DataTable();



        public DistributerRecord()
        {
            InitializeComponent();
        }
        
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            string query = "select  *  from [Distributer]";
            dt = dbconn.getData(query);

            metroGrid1.DataSource = dt;
        }

        private void DriverRecord_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
        
            DisplayData();
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            NewDistributer form = new NewDistributer();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            UpdateDistributer form = new UpdateDistributer();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Record form = new Record();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
