using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace TestePlugin.PluginLoader
{
    class PluginLoader
    {

        AggregateCatalog PluginCatalog = new AggregateCatalog();
        CompositionContainer Container = null;
        PluginClass pluginClass = new PluginClass();

        public PluginLoader(string path)
        {

            try
            {
                PluginCatalog.Catalogs.Add(new DirectoryCatalog(path));
                Container = new CompositionContainer(PluginCatalog);
                Container.ComposeParts(pluginClass);


            }
            catch (AggregateException AEException)
            {

                Console.WriteLine("Error: {0}", AEException.Message);
            }

        }

        public void InitPlugins()
        {

            foreach (IPlugin p in pluginClass.PluginList)
            {

                p.Init();
            }

        }


    }
}
