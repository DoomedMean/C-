using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal static class Static_Class // static class don't allow to create instance
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
