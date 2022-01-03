using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Conta
    {
        public Conta()
        {
            Saldo = 0;
            Conta.totalConta++;
            Numero = Conta.totalConta;
        }

        private static int totalConta = 0;
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Cliente Titular { get; set; }


        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);
        public abstract void Transfere(double valor, Conta destino);
        public static int ProximoNumero()
        {
            return totalConta + 1;
        }

    }
}
