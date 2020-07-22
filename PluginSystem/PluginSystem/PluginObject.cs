using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PluginSystem
{
    public abstract class PluginObject
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string Creator { get; }
        public bool Enabled { get; set; }
        public abstract void DoObfuscation(ref ModuleDefMD module);
        /// <summary>
        /// Outputs the object to the log window
        /// </summary>
        /// <param name="data"></param>
        public void Output(object data)
        {
            
        }
    }
}
