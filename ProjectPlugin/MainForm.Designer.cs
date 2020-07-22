namespace ProjectPlugin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pluginpanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.exit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Obfuscate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // pluginpanel
            // 
            this.pluginpanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pluginpanel.AutoScroll = true;
            this.pluginpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pluginpanel.BackgroundImage")));
            this.pluginpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pluginpanel.GradientBottomLeft = System.Drawing.Color.Black;
            this.pluginpanel.GradientBottomRight = System.Drawing.Color.Black;
            this.pluginpanel.GradientTopLeft = System.Drawing.Color.Black;
            this.pluginpanel.GradientTopRight = System.Drawing.Color.Black;
            this.pluginpanel.Location = new System.Drawing.Point(12, 46);
            this.pluginpanel.Name = "pluginpanel";
            this.pluginpanel.Quality = 10;
            this.pluginpanel.Size = new System.Drawing.Size(167, 295);
            this.pluginpanel.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit.Location = new System.Drawing.Point(464, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 17);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Obfuscations";
            // 
            // Obfuscate
            // 
            this.Obfuscate.ActiveBorderThickness = 1;
            this.Obfuscate.ActiveCornerRadius = 20;
            this.Obfuscate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Obfuscate.ActiveForecolor = System.Drawing.Color.White;
            this.Obfuscate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Obfuscate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Obfuscate.BackColor = System.Drawing.Color.Black;
            this.Obfuscate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Obfuscate.BackgroundImage")));
            this.Obfuscate.ButtonText = "Obfuscate";
            this.Obfuscate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Obfuscate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obfuscate.ForeColor = System.Drawing.Color.SeaGreen;
            this.Obfuscate.IdleBorderThickness = 1;
            this.Obfuscate.IdleCornerRadius = 20;
            this.Obfuscate.IdleFillColor = System.Drawing.Color.Black;
            this.Obfuscate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Obfuscate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Obfuscate.Location = new System.Drawing.Point(187, 298);
            this.Obfuscate.Margin = new System.Windows.Forms.Padding(5);
            this.Obfuscate.Name = "Obfuscate";
            this.Obfuscate.Size = new System.Drawing.Size(293, 43);
            this.Obfuscate.TabIndex = 3;
            this.Obfuscate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Obfuscate.Click += new System.EventHandler(this.Obfuscate_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(187, 46);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(293, 244);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(492, 353);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Obfuscate);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pluginpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pluginpanel;
        private Bunifu.Framework.UI.BunifuCustomLabel exit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Obfuscate;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}

