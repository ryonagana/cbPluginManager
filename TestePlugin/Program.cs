using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TestePlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginLoader<IPlugin>.LoadSinglePlugin("PluginExample", "IPlugin");


            Console.WriteLine("Plugin Nome: {0}\n Plugin: Author: {1}\n Path:{2}", PluginLoader<IPlugin>.Plugin("PluginExample").Name, PluginLoader<IPlugin>.Plugin("PluginExample").Author, PluginLoader<IPlugin>.Plugin("PluginExample").Path);

            PluginLoader<IPlugin>.Plugin("PluginExample").Init();

            
 
            Console.ReadKey();
           
             
        }
    
    }
}
