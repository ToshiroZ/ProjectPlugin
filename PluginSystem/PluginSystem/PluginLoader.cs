using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PluginSystem
{
    public class PluginLoader
    {
        public readonly static PluginLoader Instance = new PluginLoader();
        public List<PluginObject> Plugins = new List<PluginObject>();
        public void LoadPlugins()
        {
            string path = Directory.GetCurrentDirectory();
            foreach (var file in Directory.GetFiles(path, "*.dll"))
            {
                if (file.Contains("dnlib") || file.Contains("Bunifu")) continue;
                Assembly ass = Assembly.LoadFile(file);
                try
                {
                    foreach (var type in ass.GetTypes())
                    {
                        if (type.IsAbstract && !type.IsInterface) continue;

                        else
                        {
                            if (typeof(PluginObject).IsAssignableFrom(type) && type.GetConstructor(Type.EmptyTypes) != null)
                            {
                                var pobject = (PluginObject)Activator.CreateInstance(type);
                                Plugins.Add(pobject);
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }
    }
}
