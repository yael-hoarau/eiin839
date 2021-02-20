using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("< HTML >< BODY > Hello " + args[0] + " et " + args[2] + " </ BODY ></ HTML > ");
            else
                Console.WriteLine("Executable <string param1, string param2>");
        }
    }
}
