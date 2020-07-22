using dnlib.DotNet;
using PluginSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Obfuscations
{
    public class Renaming : PluginObject
    {
        public override string Name
        {
            get { return "Renamer"; }
        }
        public override string Description 
        { 
            get { return "Renames methods and shit"; }
        } 
        public override string Creator
        {
            get { return "Toshiro"; }
        }

        public override void DoObfuscation(ref ModuleDefMD module)
        {
            foreach(var type in module.GetTypes())
            {
                if (type.Name.Contains("<PrivateImplementationDetails>")) continue;

                if (type.HasGenericParameters) continue;

                type.Name = randomstring(100);

                type.Namespace = randomstring(100);



                foreach (var field in type.Fields)
                {
                    field.Name = randomstring(100);
                }
                foreach (var method in type.Methods)
                {
                    if (method.HasGenericParameters) continue;


                    MethodObfuscation(method);

                    foreach (var param in method.ParamDefs)
                    {
                        param.Name = randomstring(100);
                    }
                }
            }
        }
        private void MethodObfuscation(MethodDef method)
        {

            if (method.IsConstructor || !method.HasBody) return;


            method.Name = randomstring(100);

        }
        string randomstring(int string_length)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bit_count = (string_length * 6);
                var byte_count = ((bit_count + 7) / 8); // rounded up
                var bytes = new byte[byte_count];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
