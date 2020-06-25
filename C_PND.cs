﻿using System;
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
    public partial class C_PND : MetroFramework.Forms.MetroForm
    {
        public C_PND()
        {
            InitializeComponent();
        }
        
        public SqlDataAdapter da;
        public SqlDataReader dr;

        Connect dbconn = new Connect();
        DataTable dt = new DataTable();


        private void DisplayData()
        {
           

            DataTable dt = new DataTable();
            string query = "select * from C_PND";
            dt = dbconn.getData(query);

            metroGrid1.DataSource = dt;
            
        }
        private void C_PND_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
            DisplayData();
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            CustomerRecord form = new CustomerRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerRecord form = new CustomerRecord();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            form.Show();
        }
    }
}