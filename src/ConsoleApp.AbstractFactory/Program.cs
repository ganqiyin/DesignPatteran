using System;

namespace ConsoleApp.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = Factory.Factory.Create("ConsoleApp.AbstractFactory.Html.List", "ListFactory", null);
            var people = factory.CreateLink("人民日报", "http://www.people.com.cn");
            var gmw = factory.CreateLink("光明日报", "http://www.gmw.cn");

            var us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com");
            var jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp");
            var excite = factory.CreateLink("Excite", "http://www.excite.com");
            var google = factory.CreateLink("Google", "http://www.google.com");

            var traynews = factory.CreateTray("日报");
            traynews.Add(people);
            traynews.Add(gmw);

            var trayYahoo = factory.CreateTray("Yahoo");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            var traySearch = factory.CreateTray("搜索引擎");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            var page = factory.CreatePage("页面链接", "ganqy");
            page.Add(traynews);
            page.Add(traySearch);
            page.OutPut();


             factory = Factory.Factory.Create("ConsoleApp.AbstractFactory.Html.Table", "TableFactory", null);
             people = factory.CreateLink("人民日报", "http://www.people.com.cn");
             gmw = factory.CreateLink("光明日报", "http://www.gmw.cn");

             us_yahoo = factory.CreateLink("Yahoo!", "http://www.yahoo.com");
             jp_yahoo = factory.CreateLink("Yahoo!Japan", "http://www.yahoo.co.jp");
             excite = factory.CreateLink("Excite", "http://www.excite.com");
             google = factory.CreateLink("Google", "http://www.google.com");

            traynews = factory.CreateTray("日报");
            traynews.Add(people);
            traynews.Add(gmw);

             trayYahoo = factory.CreateTray("Yahoo");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

             traySearch = factory.CreateTray("搜索引擎");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            page = factory.CreatePage("页面链接2", "ganqy");
            page.Add(traynews);
            page.Add(traySearch);
            page.OutPut();
            Console.ReadLine();
        }
    }
}
