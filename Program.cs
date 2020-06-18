using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numeroUm, numeroDois, maiorNumero;

            Console.Write("Digite o primeiro número..: ");
            numeroUm = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número...: ");
            numeroDois = Convert.ToDecimal(Console.ReadLine());            

            if (numeroUm < numeroDois){
                maiorNumero = numeroDois;
            }else{
                maiorNumero = numeroUm;
            }

            Console.WriteLine($"O maior número é {maiorNumero}");
        }
    }
}
