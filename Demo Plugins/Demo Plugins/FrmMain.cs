using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Plugins
{
    public partial class FrmMain : Form
    {
        PluginImplementer PluginImplement;
        ToolStripItem TS;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (var files in Directory.GetFiles("Plugins","*dll"))
            {
                var MyAssembly = Assembly.LoadFrom(files);
                foreach(var type in MyAssembly.GetTypes())
                {
                    if (type.GetInterfaces().Contains(typeof(PluginImplementer)) ) {
                        PluginImplement = Activator.CreateInstance(type) as PluginImplementer;
                        string Name = PluginImplement.PluginName();
                        TS = menuStrip1.Items.Add(Name);
                        PluginImplement.Menu_Adder(TS);
                    }
                }

            }
        }
    }
}
