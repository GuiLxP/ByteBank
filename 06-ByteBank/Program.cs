using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "102.366.879-30";
            cliente.Profissao = "Desenvolvedor";


            conta.Saldo = -10;
            conta.Titular = cliente;


            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo); */

            ContaCorrente GuilhermeP = new ContaCorrente();
            Cliente Guilherme = new Cliente();

            ContaCorrente MatheusA = new ContaCorrente();
            Cliente Matheus = new Cliente();

            ContaCorrente NatanaelV = new ContaCorrente();
            Cliente Natan = new Cliente();

            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            
            Guilherme.Nome = "Guilherme Matheus Rodrigues Pantoja";
            Guilherme.Cpf = "754.156.987-22";
            Guilherme.Profissao = "Estágiario de Desenvolvimento.";

            GuilhermeP.Agencia = 012363;
            GuilhermeP.Numero = 6984;
            GuilhermeP.Saldo = 2941.42;
            
            Console.WriteLine("Conta: " + Guilherme.Nome);
            Console.WriteLine("CPF: " + Guilherme.Cpf);
            Console.WriteLine("Profissão: " + Guilherme.Profissao);
            Console.WriteLine();
            // Console.WriteLine("Titular: " + GuilhermeP.Titular);
            Console.WriteLine("Saldo Atual: " + GuilhermeP.Saldo);
            
            Console.WriteLine();
            GuilhermeP.Depositar(10000);
            
            Console.WriteLine("Deposito realizado com sucesso!");
            Console.WriteLine("Saldo Atualizado: " + GuilhermeP.Saldo);
            
           
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Matheus.Nome = "Matheus Felipe do Amaral";
            Matheus.Cpf = "423.897.104-50";
            Matheus.Profissao = "Suporte do Suporte de Help desk";

            MatheusA.Agencia = 012363;
            MatheusA.Numero = 6985;
            MatheusA.Saldo = 6200.00;
            
            Console.WriteLine("Conta: " + Matheus.Nome);
            Console.WriteLine("CPF: " + Matheus.Cpf);
            Console.WriteLine("Profissão: " + Matheus.Profissao);
            Console.WriteLine();
            Console.WriteLine("Saldo Atual: " + MatheusA.Saldo);

            Console.WriteLine();
            MatheusA.Depositar(15000);

            Console.WriteLine("Deposito realizado com sucesso!");
            Console.WriteLine("Saldo Atualizado: " + MatheusA.Saldo);

            
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Natan.Nome = "Natanael Vieira";
            Natan.Cpf = "111.324.555-30";
            Natan.Profissao = "Desenvolvedor Progress 4GL";

            NatanaelV.Agencia = 012363;
            NatanaelV.Numero = 6986;
            NatanaelV.Saldo = 14000.00;
            
            Console.WriteLine("Conta: " + Natan.Nome);
            Console.WriteLine("CPF: " + Natan.Cpf);
            Console.WriteLine("Profissão: " + Natan.Profissao);
            Console.WriteLine();
            //Console.WriteLine("Titular: " + Natan.Titular);
            Console.WriteLine("Saldo Atual: " + NatanaelV.Saldo);

            Console.WriteLine();
            NatanaelV.Depositar(25000);
            Console.WriteLine("Deposito realizado com sucesso!");
            Console.WriteLine("Saldo Atualizado: " + NatanaelV.Saldo);


            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Transferir da conta do Natan para a conta do Guilherme.");

            NatanaelV.Transferir(10000.85, GuilhermeP);
            Console.WriteLine("Transferência realizada com sucesso.");

            Console.WriteLine("Saldo atual do Guilherme: " + GuilhermeP.Saldo);



            Console.ReadLine();
        }
    }
}
