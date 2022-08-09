using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Builder
{
    public class HtmlBulder : Builder
    {

        private StringBuilder _sb = new StringBuilder();
          
        public override void MakeTitle(string title)
        {
            throw new NotImplementedException();
        }
        public override void MakeContent(string content)
        {
            throw new NotImplementedException();
        }

        public override void MakeItems(string[] items)
        {
            throw new NotImplementedException();
        }
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public string GetResult()
        {
            return _sb.ToString();
        }
    }
}
