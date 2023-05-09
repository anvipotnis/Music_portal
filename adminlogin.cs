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
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HR6D14JE\SQLEXPRESS;Initial Catalog=dbsbs;Integrated Security=True");
        

        private void button2_Click(object sender, EventArgs e)
        {
            musify frm = new musify();
            frm.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void getData()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                con.Close();
                con.Open();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String systempass1 = "musifyadmin", adminname, adminpass, systempass;
            adminname = textBox3.Text;
            adminpass = textBox2.Text;
            systempass = textBox1.Text;

            try
            {
                String query = "SELECT * from adminTable where adminname = '" + textBox3.Text + "' AND adminpass = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count>0)
                { 
                    adminname = textBox3.Text;
                    adminpass = textBox2.Text;
                    if (systempass.Equals(systempass1))
                    {
                        label5.Hide();
                        admin frm = new admin();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        label5.Show();
                    }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
