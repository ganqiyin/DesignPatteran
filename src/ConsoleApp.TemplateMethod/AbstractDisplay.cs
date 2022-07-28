using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TemplateMethod
{
    public abstract class AbstractDisplay
    {
        protected abstract void Open();

        protected abstract void Print();

        protected abstract void Close();
        
        public void Display()
        {
            this.Open();
            for(var i = 0; i < 10; i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
