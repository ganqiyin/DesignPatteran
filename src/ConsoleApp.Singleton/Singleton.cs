using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Singleton
{
    /// <summary>
    /// https://www.jianshu.com/p/3ae1bd656c1f
    /// </summary>
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _singleton = null;
        private static readonly object _singletonLock = new();

        /// <summary>
        /// 非线程安全
        /// </summary>
        public static Singleton SimpleInstance
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Singleton();
                return _singleton;
            }
        }

        /// <summary>
        /// 简单线程安全:
        /// 由于每次调用Instance都会使用到锁，而调用锁的开销较大，这个实现会有一定的性能损失。
        /// </summary>
        public static Singleton SimpleThreadInstance
        {
            get
            {
                lock (_singletonLock)
                {
                    if (_singleton == null)
                        _singleton = new Singleton();
                    return _singleton;
                }
            }
        }

        /// <summary>
        /// 双重验证的线程安全实现 【推荐】
        /// 缺点：无法在Java中工作。（具体原因可以见原文，这边没怎么理解）
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                if (_singleton == null)
                {
                    lock (_singletonLock)
                    {
                        if (_singleton == null)
                            _singleton = new Singleton();
                    }
                }
                return _singleton;
            }
        } 
    }
}
