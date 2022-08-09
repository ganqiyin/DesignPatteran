using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html.List
{
    public class ListTray : Factory.Tray
    {
        public ListTray(string caption) : base(caption) { }

        public override string MakeHtml()
        {
            var sb = new StringBuilder("<li>\n")
                 .AppendFormat("{0}\n", Caption)
                 .Append("<ul>\n");
            foreach (var item in Items)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</ul>\n</li>\n");
            return sb.ToString();
        }
    }
}
