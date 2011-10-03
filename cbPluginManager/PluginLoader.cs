using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;


namespace cbPluginManager
{
    public class PluginLoader
    {

        public static List<PluginClass> PluginList = new List<PluginClass>();

        public static void LoadSinglePlugin(string path, string interfacename)
        {

            try
            {

                Assembly asm = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory +  path);

                foreach (var t in asm.GetTypes())
                {
                    if (t.GetInterface(interfacename) != null)
                    {

                        PluginList.Add(new PluginClass(t, asm));
                        
                        
                    }

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
