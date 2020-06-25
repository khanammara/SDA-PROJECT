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
    public partial class PND : MetroFramework.Forms.MetroForm
    {

        public static string cname = null,  contact= null, cartype = null, from = null, to = null, date = null, fare = null;
        public PND()
        {
            InitializeComponent();
        }

        private void PND_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Reservation form = new Reservation();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {


            cname = metroTextBox4.Text;
            contact = metroTextBox1.Text;
            cartype = metroComboBox2.Text;
            from = metroTextBox2.Text;
            to = metroTextBox5.Text;
            date = metroDateTime1.Text;
            fare = metroTextBox6.Text;

            TMSQuerry qp = new TMSQuerry();

            qp.AddPNDReservation(cname, contact, cartype, from, to, date, fare);

            ClearData();
        }

        private void ClearData()
        {

            metroTextBox1.Clear(); ;
            metroTextBox4.Clear(); ;
            //metroComboBox2.Icon.Clear();
            metroTextBox2.Clear(); ;
            metroTextBox5.Clear(); ;
            //metroDateTime1.Clear();
            metroTextBox6.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reservation form = new Reservation();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
