using System;

namespace Banco
{
    class Program
    {
        enum Menu { AbrirConta = 1, Sacar, Depositar, Transferir, Finalizar}
        static void Main(string[] args)
        {
            bool escolheuSair = false;


            while (!escolheuSair)
            {
                Console.WriteLine("Escolha a opção desejada: \n");
                Console.WriteLine("1-Abrir Conta\n2-Sacar\n3-Depositar\n4-Transferir-\n5-Finalizar\n");
                
                Menu escolha = (Menu) int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case Menu.AbrirConta:
                        AbrirConta();
                        break;
                    case Menu.Sacar:
                        Sacar();
                        break;
                    case Menu.Depositar:
                        break;
                    case Menu.Transferir:
                        break;
                    case Menu.Finalizar:
                        escolheuSair = true;
                        break;
                }
                Console.Clear();
            }



            Conta contaCorrente = new ContaCorrente();


            //Console.WriteLine("=================");
            //// Isso é polimorfismo
            //TotalizadorDeConta totalizador = new TotalizadorDeConta();

            //totalizador.Soma(conta1);
            //totalizador.Soma(contaPoupanca);



        }

        public static void AbrirConta()
        {
            ContaPoupanca contaPoupanca = new ContaPoupanca();
            Cliente cliente = new Cliente();
            contaPoupanca.Titular = cliente;

            Console.WriteLine("Dados: \n");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            contaPoupanca.Titular.Nome = nome;

            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            contaPoupanca.Titular.CPF = cpf;

            Console.WriteLine("Endereco: ");
            string endereco = Console.ReadLine();
            contaPoupanca.Titular.Endereco = endereco;

            Console.WriteLine("Nome: " + contaPoupanca.Titular.Nome);
            Console.WriteLine("CPF: " + contaPoupanca.Titular.CPF);
            Console.WriteLine("Endereço: " + contaPoupanca.Titular.Endereco);
            Console.ReadLine();

        }
        public static void Sacar()
        {
            Conta contaPoupanca = new ContaCorrente();
            contaPoupanca.Sacar(20);
        }

    }


}
