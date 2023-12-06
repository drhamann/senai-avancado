using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Aula05
{
    //  Hora do Café
    //Um gerente de uma cafeteria está realizando uma promoção e deseja oferecer um desconto para as bebidas de café.
    //O programa que você recebe recebe o valor do desconto como entrada e define um dicionário,
    //onde os nomes das bebidas de café são definidos como chaves, e seus preços são definidos como valores.

    //Escreva um programa para aplicar o desconto em todos os preços e exibir uma nova lista de preços no formato mostrado abaixo.

    //**Entrada de Exemplo:**`
    //10

    //**Saída de Exemplo:**
    //Americano: 45
    //Latte: 63
    //Flat White: 54
    //Espresso: 54
    //Cappuccino: 72
    //Mocha: 81
    public class HoraDoCafe
    {
        public void Executa()
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            //Resposta

            foreach (string c in coffee.Keys.ToArray())
            {
                coffee[c] = coffee[c] - (coffee[c] * discount) / 100;
                Console.WriteLine($"{c}: {coffee[c]}");
            }
        }
    }
}
