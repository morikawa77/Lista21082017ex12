using System;

namespace Lista21082017ex12
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numeroConta;
            decimal saldo, debito, credito, saldoAtual, saldoAtualNeg;

            Console.WriteLine("Digite o número da conta: ");
            numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do saldo: ");
            saldo = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("Digite o valor do débito: ");
            debito = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("Digite o valor do crédito: ");
			credito = Convert.ToDecimal(Console.ReadLine());

            saldoAtual = (saldo - debito) + credito;


            if (saldoAtual < 0) {
			    Console.WriteLine("Saldo Negativo.");
                saldoAtualNeg = Math.Abs(saldoAtual);
                Console.WriteLine("O saldo atual da conta {1} é: - R$ {0:###,##0.00}", saldoAtualNeg, numeroConta);
            } else {
                Console.WriteLine("Saldo Positivo.");
                Console.WriteLine("O saldo atual da conta {1} é: R$ {0:###,##0.00}", saldoAtual, numeroConta);
            }

            Console.ReadKey();

        }
    }
}
