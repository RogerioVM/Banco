using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta, ITributavel
    {
        public override void Sacar(double valor)
        {
            try 
            {
                if (valor > 0 && valor <= Saldo)
                {
                    Saldo -= (valor + 0.10);
                    Console.WriteLine(Saldo);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e);
                Console.WriteLine("Valor acima do saldo");
                
            }

        }

        public override void Depositar(double valor)
        {
            Console.WriteLine($"Seu saldo é : {Saldo}");
            double taxa = 0.5;

            if ((valor + taxa) > 0)
            {
                Console.WriteLine($"Depositando: {valor}");
                Console.WriteLine($"Taxa de depósito: {taxa}");
                Saldo += (valor - taxa);

                Console.WriteLine($"Seu saldo atualizado : {Saldo}");
            }

        }

        public override void Transfere(double valor, Conta destino)
        {
                double taxa = 0.20;
                double valorFinal = valor + taxa;

                if (Saldo > valorFinal &&  valor > 0)
                {
                    Console.WriteLine($"Transferindo: {valorFinal}");
                    Console.WriteLine($"Taxa de transferência: {taxa}"); 

                    Saldo -= (valor + taxa);
                    destino.Saldo += valor;

                    Console.WriteLine($"Saldo atual : {Saldo}");
                }
        }

        public double CalculaTributos()
        {
            double imposto = (Saldo * 5) / 100;
            double saldoFinal = Saldo + imposto;

            return saldoFinal; 
        }
    }
}
