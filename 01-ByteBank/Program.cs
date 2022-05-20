using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // ContaCorrente contaDaGabriela = new ContaCorrente();
            // 
            // contaDaGabriela.titular = "Gabriela";
            // contaDaGabriela.agencia = 863;
            // contaDaGabriela.numero = 863452;
            // contaDaGabriela.saldo = 100;
            // 
            // Console.WriteLine("Titular da Conta: " + contaDaGabriela.titular);
            // Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            // Console.WriteLine("Número: " + contaDaGabriela.numero);
            // Console.WriteLine("Saldo em conta: " + contaDaGabriela.saldo);
            // 
            // contaDaGabriela.saldo += 200;
            // 
            // 
            // Console.ReadLine();

            Console.WriteLine("Primeira Conta Corrente...");
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.saldo = 200;
            Console.WriteLine("Saldo inicial: " + primeiraContaCorrente.saldo);
            
            primeiraContaCorrente.saldo += 100;
            Console.WriteLine("Adição de saldo, saldo resultante: " + primeiraContaCorrente.saldo);


            Console.WriteLine();
            Console.WriteLine("Segunda Conta Corrente...");
            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;
            Console.WriteLine("Saldo inicial: " + segundaContaCorrente.saldo);


            Console.ReadLine();
        }
    }
}