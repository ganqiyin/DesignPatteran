using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Html.List
{
    public class ListLink : Factory.Link
    {
        public ListLink(string caption, string url) : base(caption, url) { }
        public override string MakeHtml()
        {
            return string.Format("<li><a href=\"{0}\">{1}</a></li>", Url, Caption);
        }
    }
}
