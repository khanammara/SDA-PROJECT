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

    public partial class DriverRecord : MetroFramework.Forms.MetroForm
    {

        public SqlDataAdapter da;
        public SqlDataReader dr;

        Connect dbconn = new Connect();
        DataTable dt = new DataTable();

        public DriverRecord()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {

            DataTable dt = new DataTable();
            string query = "select  *  from [Driver]";
            dt = dbconn.getData(query);

            metroGrid1.DataSource = dt;
        }




        private void DistributerRecord_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            NewDriver form = new NewDriver();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            DisplayData();
            
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            UpdateDriver form = new UpdateDriver();
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

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
