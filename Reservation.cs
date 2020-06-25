using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS
{
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            PND form = new PND();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            RAC form = new RAC();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            ManagerDashboard form = new ManagerDashboard();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManagerDashboard form = new ManagerDashboard();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
