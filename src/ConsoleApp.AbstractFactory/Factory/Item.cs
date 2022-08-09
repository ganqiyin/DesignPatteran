using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Factory
{
    public abstract class Item
    {
        /// <summary>
        /// 标题
        /// </summary>
        protected string Caption;

        public Item(string caption)
        {
            Caption = caption;
        }

        public abstract string MakeHtml();
    }
}
