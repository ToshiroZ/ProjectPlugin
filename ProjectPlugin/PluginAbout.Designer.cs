namespace ProjectPlugin
{
    partial class PluginAbout
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
            this.ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.description = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.creator = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ok.BorderRadius = 0;
            this.ok.ButtonText = "OK";
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.DisabledColor = System.Drawing.Color.Gray;
            this.ok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ok.Iconcolor = System.Drawing.Color.Transparent;
            this.ok.Iconimage = null;
            this.ok.Iconimage_right = null;
            this.ok.Iconimage_right_Selected = null;
            this.ok.Iconimage_Selected = null;
            this.ok.IconMarginLeft = 0;
            this.ok.IconMarginRight = 0;
            this.ok.IconRightVisible = true;
            this.ok.IconRightZoom = 0D;
            this.ok.IconVisible = true;
            this.ok.IconZoom = 90D;
            this.ok.IsTab = false;
            this.ok.Location = new System.Drawing.Point(0, 209);
            this.ok.Name = "ok";
            this.ok.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ok.OnHoverTextColor = System.Drawing.Color.White;
            this.ok.selected = false;
            this.ok.Size = new System.Drawing.Size(384, 35);
            this.ok.TabIndex = 0;
            this.ok.Text = "OK";
            this.ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok.Textcolor = System.Drawing.Color.White;
            this.ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.description.Location = new System.Drawing.Point(12, 73);
            this.description.MaximumSize = new System.Drawing.Size(671, 105);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(81, 17);
            this.description.TabIndex = 1;
            this.description.Text = "Description: ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.name.Location = new System.Drawing.Point(12, 39);
            this.name.MaximumSize = new System.Drawing.Size(671, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 17);
            this.name.TabIndex = 2;
            this.name.Text = "Name: ";
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creator.Location = new System.Drawing.Point(12, 183);
            this.creator.MaximumSize = new System.Drawing.Size(671, 0);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(59, 17);
            this.creator.TabIndex = 3;
            this.creator.Text = "Creator: ";
            // 
            // PluginAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.name);
            this.Controls.Add(this.description);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(384, 244);
            this.Name = "PluginAbout";
            this.Text = "PluginAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton ok;
        private Bunifu.Framework.UI.BunifuCustomLabel description;
        private Bunifu.Framework.UI.BunifuCustomLabel name;
        private Bunifu.Framework.UI.BunifuCustomLabel creator;
    }
}