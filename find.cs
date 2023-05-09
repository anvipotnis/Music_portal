using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musify
{
    public partial class find : UserControl
    {
        private static find _instance;
        public static find Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new find();
                }
                return _instance;
            }


        }

        
        public find()
        {
            InitializeComponent();
        }

        private void find_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
