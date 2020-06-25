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
    public partial class RoutesRecord : MetroFramework.Forms.MetroForm
    {

        public SqlDataAdapter da;
        public SqlDataReader dr;

        Connect dbconn = new Connect();
        DataTable dt = new DataTable();
        public static string fare = null, stop = null;

        private void DisplayData()


        {
         
            DataTable dt = new DataTable();
        string query = "select StopID, RoutesID, StopNames, StopFare  from [BusStop]";
        dt = dbconn.getData(query);

        metroGrid1.DataSource = dt;

        }

    private void ClearData()
        {
            metroTextBox2.Clear();
            metroTextBox3.Clear();

        }

        public RoutesRecord()
        {
            InitializeComponent();
        }

        private void RoutesRecord_Load(object sender, EventArgs e)
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
            fare = metroTextBox2.Text;
            stop = metroTextBox3.Text;

            TMSQuerry qp = new TMSQuerry();
            qp.UpdateRoutesRecord(fare, stop);
            DisplayData();
            ClearData();
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox3.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroTextBox2.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            Record form = new Record();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
