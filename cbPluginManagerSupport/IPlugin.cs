using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestePlugin
{
    public interface IPlugin
    {
        void Init();
        void Destroy();
        string Path { get; set; }
        string Author { get; set; }
        string Name { get; set; }

    }


}
