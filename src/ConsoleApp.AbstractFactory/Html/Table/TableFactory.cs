using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.AbstractFactory.Factory;

namespace ConsoleApp.AbstractFactory.Html.Table
{
    public class TableFactory : Factory.Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new TableLink(caption, url);
        }

        public override Page CreatePage(string title, string author)
        {
            return new TablePage(title, author);
        }

        public override Tray CreateTray(string caption)
        {
            return new TableTray(caption);
        }
    }
}
