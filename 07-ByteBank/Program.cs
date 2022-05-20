using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            
            
            
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

        }
    }
}