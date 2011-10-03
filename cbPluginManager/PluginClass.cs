using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.Remoting;

namespace TestePlugin
{
    public class PluginClass
    {
        private cbPlugin.IPlugin PluginInstance;
        private ObjectHandle PluginObject = null;

        public string Author { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }


        public PluginClass(Type type, Assembly asm)
        {
           // PluginObject = Activator.CreateInstance(asm.FullName, type.FullName);
           // PluginInstance = (IPlugin) PluginObject.Unwrap();



            
        }


        public void Init()
        {
            PluginInstance.Init();
        }





        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
