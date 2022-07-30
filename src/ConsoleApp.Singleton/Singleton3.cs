using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Singleton
{
    /// <summary>
    /// 完全延迟加载实现:
    /// 是实现Singleton2实现的包装。它确保了instance只会在Instance的get方法里面调用，且只会在第一次调用前初始化。它是实现四的确保延迟加载的版本。
    /// </summary>
    public sealed class Singleton3
    {
        private Singleton3()
        {
        }

        public static Singleton3 Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly Singleton3 instance = new();
        }
    }
}
