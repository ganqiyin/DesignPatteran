using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Builder
{
    public class Director
    {
        private Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.MakeTitle("Greeting");
            _builder.MakeContent("从上午到下午");
            _builder.MakeItems(new string[] { "早上好", "下午好" });
            _builder.MakeContent("晚上");
            _builder.MakeItems(new string[] { "晚上好", "晚安","再见" });
            _builder.Close();
        }
    }
}
