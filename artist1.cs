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
    public partial class artist1 : Form
    {
        public artist1()
        {
            InitializeComponent();
        }

        private void artist1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            musify frm = new musify();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                artist2 frm = new artist2();
                frm.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                artist3 frm = new artist3();
                frm.Show();
                this.Hide();
            }
            else if (radioButton3.Checked)
            {
                artist4 frm = new artist4();
                frm.Show();
                this.Hide();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
