using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.FactoryMethod.Framework
{
    public abstract class Factory
    {
        /// <summary>
        /// 创建并注册商品
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public Product Create(string owner)
        {
            var product = CreateProduct(owner);
            RegisterProduct(product);
            return product;
        }

        /// <summary>
        /// 创建商品
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        protected abstract Product CreateProduct(string owner);
        
        /// <summary>
        /// 注册商品
        /// </summary>
        /// <param name="product"></param>
        protected abstract void RegisterProduct(Product product);
    }
}
