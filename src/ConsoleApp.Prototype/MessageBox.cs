using ConsoleApp.Prototype.Framework;

namespace ConsoleApp.Prototype
{
    public class MessageBox : Product
    {
        private readonly char _decochar;

        public MessageBox(char decochar)
        {
            _decochar = decochar;
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
            for (var i = 0; i < length; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine();
            Console.WriteLine("{0} {1} {0}", _decochar, str);
            for (var i = 0; i < length; i++)
            {
                Console.Write(_decochar);
            }
            Console.WriteLine();
        }
    }
}
