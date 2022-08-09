using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Builder
{
    public class HtmlBulder : Builder
    {

        private StringBuilder _sb = new StringBuilder();
        private string _fileName = "";

        public override void MakeTitle(string title)
        {
            _fileName = String.Format("{0}.html", title);
            _sb.Append("<html>")
                .Append("<head>")
                .Append("<title>")
                .Append(title)
                .Append("</title>")
                .Append("</head>");
            _sb.Append("<body>")
                 .AppendFormat("<h1>{0}</h1>", title);
        }

        public override void MakeContent(string content)
        {
            _sb.AppendFormat("<p>{0}</p>", content);
        }

        public override void MakeItems(string[] items)
        {
            _sb.Append("<ul>");
            foreach (string item in items)
            {
                _sb.AppendFormat("<li>{0}</li>", item);
            }
            _sb.Append("</ul>");
        }
        public override void Close()
        {
            _sb.Append("</body>").Append("</html>");
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var filepath = Path.Combine(dir, _fileName);
            using (var fs = File.Create(filepath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(_sb.ToString());
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }

        public string GetResult()
        {
            return _fileName;
        }
    }
}
