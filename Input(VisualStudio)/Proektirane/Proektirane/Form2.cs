using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proektirane
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
                                 //Вътре в самите кавички на долния ред на Form1 и Form2 се поставя вашият Connection string
                                 //В App.config се прави същото
        SqlConnection conn = new SqlConnection(@"Data Source=DANI;Initial Catalog=Proektirane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Close();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Close();
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Close();
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Close();
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Close();
            conn.Close();
        }
    }
}
