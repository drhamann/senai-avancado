using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
//Suponha que você esteja desenvolvendo um sistema de gerenciamento de funcionários, e você deseja calcular o valor do inss com base no salário de cada funcionário.Crie um programa que utilize um delegate para calcular o inss para diferentes tipos de faixa.
//As alíquotas inss são de 7,5% para aqueles que ganham até R$ 1.320,00; de 9% para quem ganha entre R$ 1.320,01 até R$ 2.571,29; de 12% para os que ganham entre R$ 2.571,30 até R$ 3.856,94; e de 14% para quem ganha de R$ 3.856,95 até R$ 7.507,29.
//01 - Crie uma implementação usando um método para o delegate
//02 - Resolve com  o uso do lambda
// Considere a seguinte assinatura para o delegate:


    public class CalculoInss
    {
        public delegate double CalcularInss(double salario);

        public void Executar()
        {
            Console.WriteLine("Entre com o seu salario :");
            var salario = Convert.ToDouble(Console.ReadLine());
            CalcularInss calcularInss ; 
            //if (salario > 0 && salario < 1320) 
            {
                calcularInss = CalcularFaixa1;
            }

            Console.WriteLine(calcularInss(salario));
        }

        public static double CalcularFaixa1(double salario)
        {
            //7,5
            return 0.0;
        }
    }
}
