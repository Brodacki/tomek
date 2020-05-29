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
using System.Configuration;

namespace Odlot
{
    public partial class Form1 : Form
    {

        public SqlConnection cmd;
        public SqlConnectionStringBuilder scb;
        public SqlCommand com;
        
        public Form1()
        {
            InitializeComponent();

         +++
           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue=="Warszawa"){



            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(@"EXEC IlePasażerów '" + comboBox1.SelectedValue.ToString() + "'", cmd);
            label1.Text = com.ExecuteScalar().ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemLotowDataSet3.Widok3' table. You can move, or remove it, as needed.
            this.widok3TableAdapter.Fill(this.systemLotowDataSet3.Widok3);
            // TODO: This line of code loads data into the 'systemLotowDataSet2.Widok1' table. You can move, or remove it, as needed.
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com = new SqlCommand(@"EXEC JakieSamoloty '" + comboBox1.SelectedValue.ToString() + "'", cmd);
            label1.Text = com.ExecuteScalar().ToString();

        }
    }
}
