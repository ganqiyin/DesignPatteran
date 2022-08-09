using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html.Table
{
    public class TablePage : Factory.Page
    {
        public TablePage(string title, string author)
            : base(title, author) { }

        public override string MakeHtml()
        {
            var sb = new StringBuilder("<html><head><title>")
                .Append(Title)
                .Append("</title></head>\n")
                .Append("<body>\n")
                .AppendFormat("<h1>{0}</h1>\n", Title)
                .Append("<table width=\"80%\" border=\"3\">\n");
            foreach (var item in Items)
            {
                sb.AppendFormat("<tr>{0}</tr>",item.MakeHtml());
            }
            sb.Append("</table>\n")
                .AppendFormat("<hr><address>{0}</address>", Author)
                .Append("</body></html>");
            return sb.ToString();
        }
    }
}
