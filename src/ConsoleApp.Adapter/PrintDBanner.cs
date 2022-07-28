using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Adapter
{
    /// <summary>
    /// 委托模式的适配器
    /// </summary>
    public class PrintDBanner : IPrint
    {
        private Banner _banner;
        public PrintDBanner(string txt)
        {
            _banner = new Banner(txt);
        }

        public void PrintStrong()
        {
            _banner.ShowWithAster();
        }

        public void PrintWeak()
        {
            _banner.ShowWithParen();
        }
    }
}
