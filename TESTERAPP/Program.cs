using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telper.Utilities.Objects;

namespace TESTERAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            PunctuatedNumeral n = new PunctuatedNumeral('.', new int[4] { 0, 0, 0, 1 });

            Console.WriteLine(n.ToString());
            Console.ReadKey();
        }
    }
}
