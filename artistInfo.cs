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
    public partial class artistInfo : UserControl
    {
        private static artistInfo _instance;
        public static artistInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new artistInfo();
                }
                return _instance;
            }


        }
        public artistInfo()
        {
            InitializeComponent();
        }

        private void artistInfo_Load(object sender, EventArgs e)
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
