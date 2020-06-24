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
    public partial class UpdateMaintenance : MetroFramework.Forms.MetroForm
    {
        public UpdateMaintenance()
        {
            InitializeComponent();
        }

        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public string constring = "Data Source=DESKTOP-3PLMV60;Initial Catalog=TMS;Integrated Security=True";
        public static string m_id = null, status = null;

        private void DisplayData()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select  *  from Maintenance", conn);
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            conn.Close();
        }
        private void UpdateMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            m_id = metroTextBox3.Text;
            status = metroComboBox1.Text;

            TMSQuerry qp = new TMSQuerry();

            qp.UpdateMaintenanceRecord(m_id, status);
            DisplayData();
            ClearData();
        }

        private void ClearData()
        {
            metroTextBox3.Clear();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox3.Text = metroGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
            metroComboBox1.Text = metroGrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Record form = new Record();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            DisplayData();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Record form = new Record();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
