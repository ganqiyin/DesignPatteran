using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Singleton
{
    /// <summary>
    /// 【推荐】
    /// .NET4或以上的版本支持Lazy<T>来实现延迟加载，它用最简洁的代码保证了单例的线程安全和延迟加载特性。
    /// </summary>
    public sealed class Singleton4
    {
        private static readonly Lazy<Singleton4> lazy = new Lazy<Singleton4>(() => new Singleton4());

        public static Singleton4 Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton4()
        {
        }
    }
}
