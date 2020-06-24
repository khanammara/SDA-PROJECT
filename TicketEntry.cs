using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace TMS
{
    public partial class TicketEntry : MetroFramework.Forms.MetroForm
    {
        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public DataTable dt;

        public static string distributer = null, transport = null, from = null, to = null, shift = null, stop = null, date = null;

        private void metroTile3_Click(object sender, EventArgs e)
        {
            

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
           


        }

        public TicketEntry()
        {
            InitializeComponent();
        }

        private void TicketEntry_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            distributer = metroTextBox5.Text.ToString();
            transport = metroTextBox4.Text.ToString();
            from = metroComboBox2.Text.ToString();
            to = metroComboBox1.Text.ToString();
            stop = metroTextBox6.Text.ToString();
            date = metroDateTime1.Value.ToShortDateString();

            TMSQuerry qp = new TMSQuerry();

            qp.ReserveTicket(distributer, transport, from, to, stop, date);
            metroTextBox5.Text = "";
            metroTextBox4.Text = "";
            metroComboBox2.Text = "";
            metroComboBox1.Text = "";
            metroTextBox6.Text = "";
            metroDateTime1.Text = "";
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
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
