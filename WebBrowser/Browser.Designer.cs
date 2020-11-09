namespace WebBrowser
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.txt_url = new System.Windows.Forms.TextBox();
            this.webrowser = new System.Windows.Forms.WebBrowser();
            this.panel_back = new System.Windows.Forms.Panel();
            this.panel_forward = new System.Windows.Forms.Panel();
            this.pane_refresh = new System.Windows.Forms.Panel();
            this.panel_home = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_url
            // 
            this.txt_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_url.Location = new System.Drawing.Point(116, 12);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(672, 20);
            this.txt_url.TabIndex = 0;
            this.txt_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // webrowser
            // 
            this.webrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webrowser.Location = new System.Drawing.Point(1, 38);
            this.webrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webrowser.Name = "webrowser";
            this.webrowser.Size = new System.Drawing.Size(798, 413);
            this.webrowser.TabIndex = 1;
            // 
            // panel_back
            // 
            this.panel_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_back.BackgroundImage")));
            this.panel_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_back.Location = new System.Drawing.Point(12, 12);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(20, 20);
            this.panel_back.TabIndex = 2;
            // 
            // panel_forward
            // 
            this.panel_forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_forward.BackgroundImage")));
            this.panel_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_forward.Location = new System.Drawing.Point(38, 12);
            this.panel_forward.Name = "panel_forward";
            this.panel_forward.Size = new System.Drawing.Size(20, 20);
            this.panel_forward.TabIndex = 3;
            // 
            // pane_refresh
            // 
            this.pane_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pane_refresh.BackgroundImage")));
            this.pane_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pane_refresh.Location = new System.Drawing.Point(64, 12);
            this.pane_refresh.Name = "pane_refresh";
            this.pane_refresh.Size = new System.Drawing.Size(20, 20);
            this.pane_refresh.TabIndex = 3;
            // 
            // panel_home
            // 
            this.panel_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_home.BackgroundImage")));
            this.panel_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_home.Location = new System.Drawing.Point(90, 12);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(20, 20);
            this.panel_home.TabIndex = 4;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.pane_refresh);
            this.Controls.Add(this.panel_forward);
            this.Controls.Add(this.panel_back);
            this.Controls.Add(this.webrowser);
            this.Controls.Add(this.txt_url);
            this.Name = "Browser";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.WebBrowser webrowser;
        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.Panel panel_forward;
        private System.Windows.Forms.Panel pane_refresh;
        private System.Windows.Forms.Panel panel_home;
    }
}

