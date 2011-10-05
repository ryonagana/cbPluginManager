using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace TestePlugin
{
    [Export(typeof(IPlugin))]
    public class PluginMain : IPlugin
    {

        public PluginMain()
        {
            this.Author = "nicholas";
            this.Path = AppDomain.CurrentDomain.BaseDirectory;
            this.Name = "Plugin de Exemplo";

        }

        public void Init()
        {
            Console.WriteLine("Plugin {0} Iniciado Com Sucesso", this.Name);
        }

        public void Destroy()
        {
            Console.WriteLine("Plugin {0} Destruido Com Sucesso");
        }

        public string Path
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
