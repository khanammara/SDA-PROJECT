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
    public partial class DistributerDashboard : MetroFramework.Forms.MetroForm
    {
        public SqlCommand cm;
        public SqlConnection conn;
        public SqlDataAdapter da;
        public DataTable dt;
        public DistributerDashboard()
        {
            InitializeComponent();
        }

        private void DistributerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TicketEntry form = new TicketEntry();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            RoutesDetail form = new RoutesDetail();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
        
        private void metroTile3_Click(object sender, EventArgs e)
        {
            TicketRecord form = new TicketRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
