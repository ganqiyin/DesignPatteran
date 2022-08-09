using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.AbstractFactory.Factory
{
    public abstract class Factory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameSpace">命名空间</param>
        /// <param name="className">类名称
        /// 这个类是Factory 的子类  
        /// </param>
        /// <param name="parameters">构造函数的基本信息</param>
        /// <returns></returns>
        public static Factory Create(string nameSpace, string className, object[] parameters)
        {
            string fullName = nameSpace + "." + className;//命名空间.类型名
            //Assembly assembly = Assembly.LoadFile("程序集路径，不能是相对路径"); // 加载外部程序集（EXE 或 DLL）
            object ect = Assembly.GetExecutingAssembly().CreateInstance(fullName, true, BindingFlags.Default, null, parameters, null, null);//加载程序集，创建程序集里面的 命名空间.类型名 实例
            if (ect == null)
                return null;
            return (Factory)ect;
        }

        public abstract Link CreateLink(string caption, string url);

        public abstract Tray CreateTray(string caption);

        public abstract Page CreatePage(string title,string author);
    }
}
