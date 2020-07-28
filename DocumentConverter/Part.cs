using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public abstract class Part
    {
        public abstract void Open();
        public abstract void Close();
        public abstract void Convert(IConverter converter);
    }
}
