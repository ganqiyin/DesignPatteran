using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html.Table
{
    public class TableLink : Factory.Link
    {
        public TableLink(string caption, string url) : base(caption, url) { }
        public override string MakeHtml()
        {
            return string.Format("<td><a href=\"{0}\">{1}</a></td>", Url, Caption);
        }
    }
}
