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
    public partial class playlist : UserControl
    {
        private static playlist _instance;
        public static playlist Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new playlist();
                }
                return _instance;
            }


        }
        public playlist()
        {
            InitializeComponent();
        }

        private void playlist_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Playlist created!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Song added!");
        }
    }
}
