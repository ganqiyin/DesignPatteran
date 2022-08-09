using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Factory
{
    public abstract class Page
    {
        protected List<Item> Items = new();
        protected readonly string Title;
        protected readonly string Author;

        public Page(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Add(Item item)
        {
            this.Items.Add(item);
        }

        public void OutPut()
        {
            var filename = string.Format("{0}.html", Title);
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
            using (var fs = File.Create(filepath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(MakeHtml());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        public abstract string MakeHtml();
    }
}
