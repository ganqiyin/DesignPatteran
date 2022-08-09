using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Factory
{
    public abstract class Tray : Item
    {
        protected List<Item> Items = new();

        public Tray(string caption)
            : base(caption)
        {
        }

        public void Add(Item item)
        {
            this.Items.Add(item);
        }
    }
}
