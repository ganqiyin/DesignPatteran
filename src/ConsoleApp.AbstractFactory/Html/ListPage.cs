using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html
{
    public class ListPage : Factory.Page
    {
        public ListPage(string title, string author)
            : base(title, author) { }

        public override string MakeHtml()
        {
            var sb = new StringBuilder("<html><head><title>")
                .Append(Title)
                .Append("</title></head>\n")
                .Append("<body>\n")
                .AppendFormat("<h1>{0}</h1>\n", Title)
                .Append("<ul>\n");
            foreach (var item in Items)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</ul>\n")
                .AppendFormat("<hr><address>{0}</address>", Author)
                .Append("</body></html>");
            return sb.ToString();
        }
    }
}
