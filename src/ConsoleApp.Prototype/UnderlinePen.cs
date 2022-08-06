using ConsoleApp.Prototype.Framework;

namespace ConsoleApp.Prototype
{
    public class UnderlinePen : Product
    {
        private readonly char _ulchar;

        public UnderlinePen(char ulchar)
        {
            _ulchar = ulchar;
        }

        public override Product CreateClone()
        {
            Product product = null;
            try
            {
                product = (Product)base.Clone();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return product;
        }

        public override void Use(string str)
        {
            var length = str.Length * 2;
            Console.WriteLine("{0}{1}{0}", "\"", str);
            Console.WriteLine();
            for (var i = 0; i < length; i++)
            {
                Console.Write(_ulchar);
            }
            Console.WriteLine();
        }
    }
}
