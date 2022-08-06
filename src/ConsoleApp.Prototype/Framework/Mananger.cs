using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Prototype.Framework
{
    public class Mananger
    {
        private Dictionary<string, object> _managers = new Dictionary<string, object>();

        public void Register(string name, Product product)
        {
            _managers.Add(name, product);
        }

        public Product Create(string protoName)
        {
            var p = (Product)_managers[protoName];
            return p.CreateClone();
        }
    }
}
