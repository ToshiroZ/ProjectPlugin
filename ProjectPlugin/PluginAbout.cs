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
    public partial class PluginAbout : Form
    {
        public PluginAbout(PluginObject plugin)
        {
            InitializeComponent();
            this.name.Text += plugin.Name;
            this.description.Text += plugin.Description;
            this.creator.Text += plugin.Creator;
        }
        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
