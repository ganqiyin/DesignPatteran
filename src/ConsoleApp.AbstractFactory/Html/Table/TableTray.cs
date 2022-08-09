using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html.Table
{
    public class TableTray : Factory.Tray
    {
        public TableTray(string caption) : base(caption) { }

        public override string MakeHtml()
        {
            var sb = new StringBuilder("<td>\n")
                .Append("<table width=\"100%\" border=\"1\"><tr>")
                .AppendFormat("<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{0}\">", Items.Count)
                 .AppendFormat("<b>{0}</b>", Caption)
                 .Append("</td></tr>\n")
                 .Append("<tr>\n");
            foreach (var item in Items)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</tr></table>")
                .Append("</td>");
            return sb.ToString();
        }
    }
}
