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
    public partial class rate : UserControl
    {
        private static rate _instance;
        public static rate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new rate();
                }
                return _instance;
            }


        }
        public rate()
        {
            InitializeComponent();
        }

        private void rate_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rated!");
        }
    }
}
