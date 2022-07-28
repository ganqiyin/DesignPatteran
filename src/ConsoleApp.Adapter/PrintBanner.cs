using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Adapter
{
    /// <summary>
    /// 继承模式的适配器
    /// </summary>
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string txt)
            : base(txt)
        {

        }

        public void PrintStrong()
        {
            ShowWithAster();
        }

        public void PrintWeak()
        {
            ShowWithParen();
        }
    }
}
