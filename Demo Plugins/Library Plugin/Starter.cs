using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace Library_Plugin
{
    public class Starter : PluginImplementer
    {
       

        public void Menu_Adder(ToolStripItem TS)
        {
            TS.Click += TS_Click;
        }

        public string PluginName()
        {
            return "MyPlugin";
        }

        private void TS_Click(object sender, EventArgs e)
        {
            Library_Dashboard MyForm = new Library_Dashboard();
            Form mdiContainer = Application.OpenForms.OfType<Form>().FirstOrDefault(form => form.IsMdiContainer);
            MyForm.MdiParent = mdiContainer;
            MyForm.Show();
        }

        

        
    }
}
