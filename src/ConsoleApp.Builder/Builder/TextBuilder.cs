using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder _sb = new StringBuilder();

        public override void MakeTitle(string title)
        {
            _sb.Append("=============================\n");
            _sb.AppendFormat("[{0}]\n", title);
            _sb.AppendLine();
        }

        public override void MakeContent(string content)
        {
            _sb.AppendFormat("* {0}\n", content);
            _sb.AppendLine();
        }

        public override void MakeItems(string[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                _sb.AppendFormat("** {0}\n", items[i]);
            }
            _sb.AppendLine();
        }

        public override void Close()
        {
            _sb.Append("=============================\n");
        }

        public string GetResult()
        {
            return _sb.ToString();
        }

    }
}
