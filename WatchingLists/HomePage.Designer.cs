namespace WatchingLists
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.butpanel = new System.Windows.Forms.Panel();
            this.exitb = new System.Windows.Forms.Button();
            this.animeb = new System.Windows.Forms.Button();
            this.seriesb = new System.Windows.Forms.Button();
            this.movieb = new System.Windows.Forms.Button();
            this.scpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.butpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // butpanel
            // 
            this.butpanel.BackColor = System.Drawing.Color.Transparent;
            this.butpanel.Controls.Add(this.button1);
            this.butpanel.Controls.Add(this.exitb);
            this.butpanel.Controls.Add(this.animeb);
            this.butpanel.Controls.Add(this.seriesb);
            this.butpanel.Controls.Add(this.movieb);
            this.butpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.butpanel.Location = new System.Drawing.Point(0, 0);
            this.butpanel.Name = "butpanel";
            this.butpanel.Size = new System.Drawing.Size(1370, 187);
            this.butpanel.TabIndex = 4;
            // 
            // exitb
            // 
            this.exitb.BackColor = System.Drawing.Color.Transparent;
            this.exitb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitb.Location = new System.Drawing.Point(1241, 0);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(105, 80);
            this.exitb.TabIndex = 7;
            this.exitb.UseVisualStyleBackColor = false;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // animeb
            // 
            this.animeb.BackColor = System.Drawing.Color.Transparent;
            this.animeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.animeb.Location = new System.Drawing.Point(611, 24);
            this.animeb.Name = "animeb";
            this.animeb.Size = new System.Drawing.Size(168, 151);
            this.animeb.TabIndex = 6;
            this.animeb.UseVisualStyleBackColor = false;
            this.animeb.Click += new System.EventHandler(this.animeb_Click);
            // 
            // seriesb
            // 
            this.seriesb.BackColor = System.Drawing.Color.Transparent;
            this.seriesb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seriesb.Location = new System.Drawing.Point(357, 24);
            this.seriesb.Name = "seriesb";
            this.seriesb.Size = new System.Drawing.Size(168, 151);
            this.seriesb.TabIndex = 5;
            this.seriesb.UseVisualStyleBackColor = false;
            this.seriesb.Click += new System.EventHandler(this.seriesb_Click);
            // 
            // movieb
            // 
            this.movieb.BackColor = System.Drawing.Color.Transparent;
            this.movieb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.movieb.Location = new System.Drawing.Point(113, 24);
            this.movieb.Name = "movieb";
            this.movieb.Size = new System.Drawing.Size(156, 151);
            this.movieb.TabIndex = 4;
            this.movieb.UseVisualStyleBackColor = false;
            this.movieb.Click += new System.EventHandler(this.movieb_Click_1);
            // 
            // scpanel
            // 
            this.scpanel.BackColor = System.Drawing.Color.Transparent;
            this.scpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scpanel.Location = new System.Drawing.Point(0, 187);
            this.scpanel.Name = "scpanel";
            this.scpanel.Size = new System.Drawing.Size(1370, 562);
            this.scpanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button1.Location = new System.Drawing.Point(1208, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "SUMMARY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.scpanel);
            this.Controls.Add(this.butpanel);
            this.DoubleBuffered = true;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.butpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel butpanel;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button animeb;
        private System.Windows.Forms.Button seriesb;
        private System.Windows.Forms.Button movieb;
        private System.Windows.Forms.Panel scpanel;
        private System.Windows.Forms.Button button1;
    }
}