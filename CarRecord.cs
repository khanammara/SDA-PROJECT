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
    public partial class CarRecord : MetroFramework.Forms.MetroForm
    {
        public CarRecord()
        {
            InitializeComponent();
        }

        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public string constring = "Data Source=DESKTOP-3PLMV60;Initial Catalog=TMS;Integrated Security=True";
        private void DisplayData()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select  *  from [CarType]", conn);
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            conn.Close();
        }

        private void CarRecord_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            NewCar form = new NewCar();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            DisplayData();
            conn.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            UpdateCar form = new UpdateCar();
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
