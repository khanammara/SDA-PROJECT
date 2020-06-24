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
    public partial class UpdateDistributer : MetroFramework.Forms.MetroForm
    {

        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlDataReader dr;
        public string constring = "Data Source=DESKTOP-3PLMV60;Initial Catalog=TMS;Integrated Security=True";
        public static string distributer = null, contact = null, salary = null, distributerid = null;

        private void DisplayData()
        {
            conn = new SqlConnection(constring);
            conn.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select  *  from [Distributer]", conn);
            da.Fill(dt);
            metroGrid1.DataSource = dt;
            conn.Close();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            distributer = metroTextBox4.Text;
            contact = metroTextBox5.Text;
            salary = metroTextBox7.Text;
            distributerid = metroTextBox3.Text;



            TMSQuerry qp = new TMSQuerry();

            qp.UpdateDistributerRecord(distributer, contact, salary, distributerid);
            DisplayData();
            ClearData();
        }
        private void ClearData()
        {
            metroTextBox4.Clear();
           
            metroTextBox5.Clear();
            metroTextBox7.Clear();
            metroTextBox3.Clear();
        }

        private void metroGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            metroTextBox4.Text = metroGrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            metroTextBox5.Text = metroGrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            metroTextBox7.Text = metroGrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
            metroTextBox3.Text = metroGrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            distributerid = metroTextBox3.Text;

            TMSQuerry qp = new TMSQuerry();
            qp.DeleteDistributerRecord(distributerid);
            DisplayData();
            ClearData();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            DistributerRecord form = new DistributerRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        public UpdateDistributer()
        {
            InitializeComponent();
        }

        private void UpdateDistributer_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            DisplayData();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DistributerRecord form = new DistributerRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
