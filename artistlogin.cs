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



namespace musify
{
    public partial class artistlogin : Form
    {
        public artistlogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musify frm = new musify();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerart frm = new registerart();
            frm.Show();
            this.Hide();
        }

        private void artistlogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HR6D14JE\SQLEXPRESS;Initial Catalog=dbsbs;Integrated Security=True");

        private void getData()
        {
            con.Open();

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String artusername, artpass;
            artusername = textBox1.Text;
            artpass = textBox2.Text;

            try
            {
                String query = "SELECT * from artistTable where artusername = '" + textBox1.Text + "' AND artpass = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    artusername = textBox1.Text;
                    artpass = textBox2.Text;

                    artist1 form = new artist1();
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid details!");
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}

