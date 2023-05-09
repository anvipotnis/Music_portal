using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musify
{
    public partial class musify : Form
    {
        public musify()
        {
            InitializeComponent();
        }

        private void musify_Load(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                    usrlogin frm = new usrlogin();
                    frm.Show();
            this.Hide();
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
        
                    adminlogin frm = new adminlogin();
                     frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            artistlogin frm = new artistlogin();
            frm.Show();
            this.Hide();
        }
    }
}
