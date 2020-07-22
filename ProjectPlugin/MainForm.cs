using Bunifu.Framework.UI;
using dnlib.DotNet;
using PluginSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPlugin
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Control, PluginObject> PluginToggles = new Dictionary<Control, PluginObject>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Toggle_Click(object sender, EventArgs e)
        {
            if(PluginToggles.TryGetValue((Control)sender, out PluginObject plugin))
            {
                plugin.Enabled = !plugin.Enabled;

                var toggle = (BunifuFlatButton)sender;
                toggle.colbackground = plugin.Enabled ? Color.FromArgb(0, 40, 0) : Color.Transparent;
            }
        }

        private void Toggle_DoubleClick(object sender, EventArgs e)
        {
            if (PluginToggles.TryGetValue((Control)sender, out PluginObject plugin))
            {
                plugin.Enabled = !plugin.Enabled;

                var toggle = (BunifuFlatButton)sender;
                toggle.colbackground = plugin.Enabled ? Color.FromArgb(0, 40, 0) : Color.Transparent;

                var result = new PluginAbout(plugin).ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PluginLoader.Instance.LoadPlugins();
            foreach (var plugin in PluginLoader.Instance.Plugins)
            {
                var toggle = new BunifuFlatButton();
                toggle.Dock = DockStyle.Top;
                toggle.MaximumSize = new Size(169, 40);
                toggle.colbackground = Color.Black;
                toggle.Click += Toggle_Click;
                toggle.DoubleClick += Toggle_DoubleClick;
                toggle.Text = plugin.Name;
                toggle.Iconimage = null;
                toggle.TextAlign = ContentAlignment.MiddleCenter;
                pluginpanel.Controls.Add(toggle);
                PluginToggles.Add(toggle, plugin);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Obfuscate_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.ShowDialog();
                var moduledef = ModuleDefMD.Load(ofd.FileName);
                foreach(var plugin in PluginToggles.Values)
                {
                    plugin.DoObfuscation(ref moduledef);
                }
                ofd.CheckFileExists = false;
                ofd.ShowDialog();
                moduledef.Write(ofd.FileName);
            }
            MessageBox.Show("Done");
        }
    }
}
