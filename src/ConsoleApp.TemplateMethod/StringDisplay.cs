using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        private readonly string _input;
        private readonly int _with;
        public StringDisplay(string input)
        {
            _input = input;
            this._with = input.Length;
        }


        protected override void Open()
        {
            PrintLine();
        }

        protected override void Close()
        {
            PrintLine();
        }

        protected override void Print()
        {
            Console.WriteLine(_input);
        }

        private void PrintLine()
        {
            Console.Write("+");
            for(var i = 0; i < _with; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
