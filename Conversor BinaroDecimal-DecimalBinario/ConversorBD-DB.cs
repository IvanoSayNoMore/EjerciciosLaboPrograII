using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
namespace Conversor_BinaroDecimal_DecimalBinario
{
    public class ConversorBD_DB
    {
        static void Main(string[] args)
        {
            NumeroBinario nB = (NumeroBinario)"100";
            NumeroDecimal nD = (NumeroDecimal)101;

            Console.WriteLine($"Numero Binario {nB.Numero} - Numero Decimal {nD.Numero}");

            Console.WriteLine($"La suma {nB + nD} ");
        
        }


    }
}
