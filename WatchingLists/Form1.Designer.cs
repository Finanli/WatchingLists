namespace WatchingLists
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.unametxt = new System.Windows.Forms.TextBox();
            this.pswtxt = new System.Windows.Forms.TextBox();
            this.loginb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unametxt
            // 
            this.unametxt.Location = new System.Drawing.Point(632, 273);
            this.unametxt.Name = "unametxt";
            this.unametxt.Size = new System.Drawing.Size(194, 20);
            this.unametxt.TabIndex = 0;
            // 
            // pswtxt
            // 
            this.pswtxt.Location = new System.Drawing.Point(632, 355);
            this.pswtxt.Name = "pswtxt";
            this.pswtxt.PasswordChar = '*';
            this.pswtxt.Size = new System.Drawing.Size(194, 20);
            this.pswtxt.TabIndex = 1;
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.Color.Transparent;
            this.loginb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginb.Location = new System.Drawing.Point(835, 389);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(110, 96);
            this.loginb.TabIndex = 2;
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 724);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.pswtxt);
            this.Controls.Add(this.unametxt);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unametxt;
        private System.Windows.Forms.TextBox pswtxt;
        private System.Windows.Forms.Button loginb;
    }
}

