using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Adapter
{
    public class Banner
    {
        private string _txt;

        public Banner(string txt)
        {
            _txt = txt;
        }   

        public void ShowWithParen()
        {
            Console.WriteLine("(" + _txt + ")");
        }
         
        public void ShowWithAster()
        {
            Console.WriteLine("*" + _txt + "*");
        }
    }
}
