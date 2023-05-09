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
    public partial class usr : Form
    {
        public usr()
        {
            InitializeComponent();
        }

        private void usr_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(playlist.Instance))
            {
                ContentPanel.Controls.Add(playlist.Instance);
                playlist.Instance.Dock = DockStyle.Fill;
                playlist.Instance.BringToFront();
            }
            else
            {
                playlist.Instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(rate.Instance))
            {
                ContentPanel.Controls.Add(rate.Instance);
                rate.Instance.Dock = DockStyle.Fill;
                rate.Instance.BringToFront();
            }
            else
            {
                rate.Instance.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isSlidingPanelExpanded;
        const int maxSliderWidth = 220;
        const int minSliderWidth = 110;

        private void SlidingPanel_ToggleButton_Click(object sender, EventArgs e)
        {
            isSlidingPanelExpanded = !isSlidingPanelExpanded; // toggle the variable
            SlidingPanel_Timer.Enabled = true;
        }

        private void SlidingPanel_Timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= minSliderWidth)
                {
                    isSlidingPanelExpanded = true;
                    SlidingPanel_Timer.Stop();
                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= maxSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidingPanel_Timer.Stop();
                    this.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(artistInfo.Instance))
            {
                ContentPanel.Controls.Add(artistInfo.Instance);
                artistInfo.Instance.Dock = DockStyle.Fill;
                artistInfo.Instance.BringToFront();
            }
            else
            {
                artistInfo.Instance.BringToFront();
            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FindTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(find.Instance))
            {
                ContentPanel.Controls.Add(find.Instance);
                find.Instance.Dock = DockStyle.Fill;
                find.Instance.BringToFront();
            }
            else
            {
                find.Instance.BringToFront();
            }
        }

        private void LogOutTabButton_Click(object sender, EventArgs e)
        {
            musify frm = new musify();
            frm.Show();
            this.Hide();
        }
    }
}
