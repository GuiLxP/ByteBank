using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno Jhonson";
            Console.WriteLine("Saldo inicial do Bruno: " + contaDoBruno.saldo);

            Console.WriteLine("Valor depositado: 500");
            contaDoBruno.Depositar(500);
            Console.WriteLine("Saldo total: " + contaDoBruno.saldo);

            Console.WriteLine("-------------------------------------------------------------");

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela Fagundes";

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta da Gabriela: " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(2200, contaDaGabriela);
            Console.WriteLine("Transferência realizada: " + resultadoTransferencia);

            Console.WriteLine("Saldo da conta do Bruno: " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da conta da Gabriela: " + contaDaGabriela.saldo);

            
        }
    }
}
