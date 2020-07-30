using System;
using System.Collections.Generic;
using System.Text;

namespace Icecream
{
    class VanillaIceCream : IIcecream
    {
        public string Taste()
        {
            Console.WriteLine("Vanilla Added");
            throw new NotImplementedException();
        }

    }
}
