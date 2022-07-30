using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.FactoryMethod.Framework;

namespace ConsoleApp.FactoryMethod.IdCard
{
    public class IDCardFactory : Factory
    {
        public List<IDCard> _idCards = new();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _idCards.Add((IDCard)product);
        }

        public List<IDCard> GetOwners()
        {
            return _idCards;
        }
    }
}
