using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginInterface;

namespace PluginInterface
{
    public interface PluginImplementer
    {
        string PluginName();
       
        void Menu_Adder(ToolStripItem TS);
       
    }
}
