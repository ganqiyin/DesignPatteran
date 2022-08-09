using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.AbstractFactory.Factory;

namespace ConsoleApp.AbstractFactory.Html
{
    public class ListFactory : Factory.Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new ListLink(caption, url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new ListPage(title, author);
        }

        public override Tray CreateTray(string caption)
        {
            return new ListTray(caption);
        }
    }
}
