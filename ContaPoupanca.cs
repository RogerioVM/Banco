using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine(Saldo);
            }

            Console.WriteLine("Valor acima do saldo");
        }

        public override void Depositar(double valor)
        {
            Console.WriteLine($"Seu saldo é : {Saldo}");
            if (valor > 0)
            {
                Console.WriteLine($"Depósitando: {valor}");
                double bonus = 0.5;
                Console.WriteLine($"Bonificação de depósito: {bonus}");
                Saldo += (valor + bonus);

                Console.WriteLine($"Seu saldo atualizado : {Saldo}");
            }

        }

        public override void Transfere(double valor, Conta destino)
        {
            if (Saldo > valor && valor > 0)
            {
                Console.WriteLine($"Transferindo para outra conta poupança: {valor}");
                destino.Saldo += valor;
                Console.WriteLine($"Saldo atual : {Saldo}");
            }
        }
    }
}
