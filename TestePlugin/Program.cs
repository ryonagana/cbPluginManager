using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TestePlugin
{
    class Program
    {

        public static void Main(string[] args)
        {

            PluginLoader.PluginLoader Loader = new PluginLoader.PluginLoader(AppDomain.CurrentDomain.BaseDirectory + "plugins");
            Loader.InitPlugins();

        }
     
    }
}
