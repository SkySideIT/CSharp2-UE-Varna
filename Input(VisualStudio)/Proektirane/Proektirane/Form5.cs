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
    public partial class Form5 : MetroFramework.Forms.MetroForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void gridbind()
        {
            string connString = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Ime AS 'Име', Familia AS 'Фамилия', Adres AS 'Адрес', Phone AS 'Телефон' FROM Dostavchik", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
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
