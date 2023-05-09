namespace musify
{
    partial class usr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.FindTabButton = new System.Windows.Forms.Button();
            this.LogOutTabButton = new System.Windows.Forms.Button();
            this.RateTabButton = new System.Windows.Forms.Button();
            this.PlaylistTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.ArtistTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.Controls.Add(this.FindTabButton);
            this.SlidingPanel.Controls.Add(this.LogOutTabButton);
            this.SlidingPanel.Controls.Add(this.RateTabButton);
            this.SlidingPanel.Controls.Add(this.PlaylistTabButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Controls.Add(this.ArtistTabButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(220, 598);
            this.SlidingPanel.TabIndex = 0;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FindTabButton
            // 
            this.FindTabButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FindTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindTabButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindTabButton.ForeColor = System.Drawing.SystemColors.Info;
            this.FindTabButton.Location = new System.Drawing.Point(0, 111);
            this.FindTabButton.Name = "FindTabButton";
            this.FindTabButton.Size = new System.Drawing.Size(220, 100);
            this.FindTabButton.TabIndex = 1;
            this.FindTabButton.Text = "Find";
            this.FindTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindTabButton.UseVisualStyleBackColor = false;
            this.FindTabButton.Click += new System.EventHandler(this.FindTabButton_Click);
            // 
            // LogOutTabButton
            // 
            this.LogOutTabButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LogOutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutTabButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutTabButton.ForeColor = System.Drawing.SystemColors.Info;
            this.LogOutTabButton.Location = new System.Drawing.Point(0, 498);
            this.LogOutTabButton.Name = "LogOutTabButton";
            this.LogOutTabButton.Size = new System.Drawing.Size(220, 100);
            this.LogOutTabButton.TabIndex = 1;
            this.LogOutTabButton.Text = "Log out";
            this.LogOutTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutTabButton.UseVisualStyleBackColor = false;
            this.LogOutTabButton.Click += new System.EventHandler(this.LogOutTabButton_Click);
            // 
            // RateTabButton
            // 
            this.RateTabButton.BackColor = System.Drawing.Color.SteelBlue;
            this.RateTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RateTabButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RateTabButton.ForeColor = System.Drawing.SystemColors.Info;
            this.RateTabButton.Location = new System.Drawing.Point(0, 402);
            this.RateTabButton.Name = "RateTabButton";
            this.RateTabButton.Size = new System.Drawing.Size(220, 100);
            this.RateTabButton.TabIndex = 4;
            this.RateTabButton.Text = "Rate";
            this.RateTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RateTabButton.UseVisualStyleBackColor = false;
            this.RateTabButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // PlaylistTabButton
            // 
            this.PlaylistTabButton.BackColor = System.Drawing.Color.SteelBlue;
            this.PlaylistTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlaylistTabButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistTabButton.ForeColor = System.Drawing.SystemColors.Info;
            this.PlaylistTabButton.Location = new System.Drawing.Point(0, 209);
            this.PlaylistTabButton.Name = "PlaylistTabButton";
            this.PlaylistTabButton.Size = new System.Drawing.Size(220, 100);
            this.PlaylistTabButton.TabIndex = 2;
            this.PlaylistTabButton.Text = "Playlist";
            this.PlaylistTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlaylistTabButton.UseVisualStyleBackColor = false;
            this.PlaylistTabButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlidingPanel_ToggleButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(220, 116);
            this.SlidingPanel_ToggleButton.TabIndex = 3;
            this.SlidingPanel_ToggleButton.Text = "<<";
            this.SlidingPanel_ToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // ArtistTabButton
            // 
            this.ArtistTabButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ArtistTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArtistTabButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistTabButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ArtistTabButton.Location = new System.Drawing.Point(0, 307);
            this.ArtistTabButton.Name = "ArtistTabButton";
            this.ArtistTabButton.Size = new System.Drawing.Size(220, 100);
            this.ArtistTabButton.TabIndex = 0;
            this.ArtistTabButton.Text = "Artist Info";
            this.ArtistTabButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArtistTabButton.UseVisualStyleBackColor = false;
            this.ArtistTabButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(215, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(747, 598);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // usr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 598);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usr";
            this.Text = "usr";
            this.Load += new System.EventHandler(this.usr_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button LogOutTabButton;
        private System.Windows.Forms.Button ArtistTabButton;
        private System.Windows.Forms.Button PlaylistTabButton;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Button RateTabButton;
        private System.Windows.Forms.Button FindTabButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Panel ContentPanel;
    }
}