using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Prototype.Framework
{
    public abstract class Product : ICloneable
    {
        public abstract void Use(string str);

        public abstract Product CreateClone();

        public object Clone()
        {
            /*
             MemberwiseClone方法创建的新对象，然后将当前对象的非静态字段复制到新的对象创建的浅表副本。
             如果字段是值类型，则执行字段的按位复制。 如果字段是引用类型，引用将复制，但被引用的对象不;
             因此，原始对象和其克隆引用同一对象。
             例如，考虑对象称为 X 引用对象 A 和 B，反过来，引用对象 c。
             X 的浅表副本创建新的对象 X2 也引用对象 A 和 b。与此相反，
             X 的深层副本创建新对象 X2 引用 A2 和 B2，
             是的一个副本的新对象并 B.B2，
             反过来，引用新对象 C2，这是 C 的副本。该示例说明浅和深层复制操作之间的差异。

             有很多方法可以实现深层复制操作，如果浅表复制操作由MemberwiseClone方法并不满足你的需求。
             这些要求包括：

             调用类构造函数要复制可以使用来自第一个对象的属性值创建第二个对象的对象。
             这假定，对象的值完全由其类构造函数中定义。

             调用MemberwiseClone方法创建一个对象，
             对象的浅表副本并将其值是与原始对象的任何属性或其值是引用类型的字段相同的新对象。
             DeepCopy方法在示例中演示了此方法。

             序列化对象是较深复制，，然后将序列化的数据还原到另一个对象变量。

             使用具有递归反射来执行深层复制操作。
             */
            return this.MemberwiseClone();
        }

        public object DeepClone()
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, this);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as Product;
            }
        }
    }
}
