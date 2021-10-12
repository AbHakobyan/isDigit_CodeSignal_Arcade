using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isDigit_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char v = '1';
            bool x = isDigit(v);
            Console.WriteLine(x);
        }

        static bool isDigit(char symbol)
        {
            int v = 0;
            bool x;
            return x = int.TryParse(symbol.ToString(),out v);
        }
    }
}
