using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Builder
{
    public abstract class Builder
    {
        /// <summary>
        /// 标题
        /// </summary>
        /// <param name="title"></param>
        public abstract void MakeTitle(string title);

        /// <summary>
        /// 内容
        /// </summary>
        /// <param name="content"></param>
        public abstract void MakeContent(string content);

        /// <summary>
        /// 条目
        /// </summary>
        /// <param name="items"></param>
        public abstract void MakeItems(string[] items);

        /// <summary>
        /// 完成
        /// </summary>
        public abstract void Close();
    }
}
