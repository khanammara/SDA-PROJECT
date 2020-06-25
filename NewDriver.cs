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
    public partial class NewDriver : MetroFramework.Forms.MetroForm
    {

        public static string driver = null, license = null, contact = null, salary = null, driverid = null;

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DriverRecord form = new DriverRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        public NewDriver()
        {
            InitializeComponent();
        }

        private void NewRoutes_Load(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
           driver = metroTextBox4.Text;
            license= metroTextBox1.Text;
            contact = metroTextBox5.Text;
            salary = metroTextBox7.Text;
            driverid = metroTextBox3.Text;


            TMSQuerry qp = new TMSQuerry();

            qp.AddDriver(driver, license, contact, salary, driverid);
            
            ClearData();
        }

        private void ClearData()
        {
            metroTextBox4.Clear();
            metroTextBox1.Clear();
            metroTextBox5.Clear();
            metroTextBox7.Clear();
            metroTextBox3.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DriverRecord form = new DriverRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}
