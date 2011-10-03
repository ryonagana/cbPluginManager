using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting;

namespace TestePlugin
{
    public class PluginLoader<T>
    {
       


        //public static List<IPlugin> PluginList = new List<IPlugin>();

        private static Dictionary<string, T> PluginList = new Dictionary<string, T>();

        public static  T Plugin(string name)
        {
            return PluginList[name];
        }


        public static void LoadSinglePlugin(string path, string interfacename)
        {

            try
            {

                Assembly asm = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory +   path + ".dll");
                

                foreach (var t in asm.GetTypes())
                {
                    if (t.GetInterface(interfacename) != null)
                    {

                        if (t.IsClass && t.IsPublic)
                        {

                            T plugin = (T)Activator.CreateInstance(t);
                            string name = Path.GetFileNameWithoutExtension(path);
                            PluginList.Add(name, plugin);

                        }
                        
                        
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
