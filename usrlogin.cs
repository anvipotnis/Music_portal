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
    public partial class usrlogin : Form
    {
        public usrlogin()
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
            register frm = new register();
            frm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HR6D14JE\SQLEXPRESS;Initial Catalog=dbsbs;Integrated Security=True");

        private void getData()
        {
                con.Open();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            String userusername, userpass;
            userusername = textBox2.Text;
            userpass = textBox1.Text;

            try
            {
                String query = "SELECT * from userTable where userusername = '" + textBox2.Text + "' AND userpass = '" + textBox1.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    userusername = textBox2.Text;
                    userpass = textBox1.Text;
                    
                        usr form = new usr();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
