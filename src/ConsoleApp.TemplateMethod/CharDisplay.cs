using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        private readonly char _input;
        public CharDisplay(char input)
        {
            _input = input;
        }


        protected override void Open()
        {
            Console.Write("<<");
        }

        protected override void Close()
        {
            Console.WriteLine(">>");
        }

        protected override void Print()
        {
            Console.Write(_input);
        }
    }
}
