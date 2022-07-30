using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Singleton
{
    public sealed class Singleton2
    {
        //在Singleton第一次被调用时会执行instance的初始化
        private static readonly Singleton2 _instance = new();

        //Explicit static consturctor to tell C# compiler 
        //not to mark type as beforefieldinit
        static Singleton2()
        {
        }

        private Singleton2()
        {
        }

        /// <summary>
        /// 不用锁的线程安全实现 :
        /// 这里使用了一个static，readonly的Singleton实例，它会在Singleton第一次被调用的时候新建一个instance，这里新建时候的线程安全保障是由.NET直接控制的，我们可以认为它是一个原子操作，并且在一个AppDomaing中它只会被创建一次。
        /// </summary>
        public static Singleton2 Instance
        {
            /*
             缺点：
            1. instance被创建的时机不明，任何对Singleton的调用都会提前创建instance
            2. static构造函数的循环调用。如有A，B两个类，A的静态构造函数中调用了B，而B的静态构造函数中又调用了A，这两个就会形成一个循环调用，严重的会导致程序崩溃。
            3. 我们需要手动添加Singleton的静态构造函数来确保Singleton类型不会被自动加上beforefieldinit这个Attribute，以此来确保instance会在第一次调用Singleton时才被创建。
            4. readonly的属性无法在运行时改变，如果我们需要在程序运行时dispose这个instance再重新创建一个新的instance，这种实现方法就无法满足。
             */
            get
            {
                return _instance;
            }
        }
    }
}
