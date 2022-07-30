using ConsoleApp.FactoryMethod.Framework;

namespace ConsoleApp.FactoryMethod.IdCard
{
    public class IDCard : Product
    {
        private readonly string _owner;

        public IDCard(string owner)
        {
            Console.WriteLine("制作【{0}】的ID卡", owner);
            _owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine("使用【{0}】的ID卡", this._owner);
        }

        public string GetOwner()
        {
            return _owner;
        }
    }
}
