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

namespace Proektirane
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
                                //Вътре в самите кавички на долния ред на Form1 и Form2 се поставя вашият Connection string
                                //В App.config се прави същото
        SqlConnection conn = new SqlConnection(@"Data Source=DANI;Initial Catalog=Proektirane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String query = "SELECT * FROM \"User\" WHERE username = '"+textBox1.Text+"' AND password = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid login!");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
