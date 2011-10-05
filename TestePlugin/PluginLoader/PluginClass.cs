using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace TestePlugin.PluginLoader
{
    class PluginClass
    {
        [ImportMany(typeof(IPlugin))]
        public List<IPlugin> PluginList { get; set; }
    }
}
