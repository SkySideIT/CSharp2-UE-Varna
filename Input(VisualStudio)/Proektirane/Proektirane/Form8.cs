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

namespace Proektirane
{
    public partial class Form8 : MetroFramework.Forms.MetroForm
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void gridbind()
        {
            string connString = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Prodajbi.Date AS 'Дата', Slujiteli.Ime AS 'Име на служителя', Klienti.Ime AS 'Имe на клиента' FROM Prodajbi INNER JOIN Slujiteli ON Prodajbi.Sluj_ID = Slujiteli.Sluj_ID INNER JOIN Klienti ON Prodajbi.Klient_ID = Klienti.Klient_ID", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            gridbind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
