// See https://aka.ms/new-console-template for more information
using ProjetoEmTresCamadas.Pizzaria.DAO;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

PizzaDao pizzaDao = new PizzaDao();


Console.WriteLine("Bem vindo a nossa pizaria");
Console.WriteLine("Gostaria de uma pizza, S para sim e N para não?");
var resposta = Console.ReadLine();

if(resposta == "S")
{
    var pizza = new Pizza();
    Console.WriteLine("Qual o sabor de pizza, calabresa 'C' , frango 'F' ?");
    var sabor = Console.ReadLine();
    Console.WriteLine($"O sabor escolhido foi {pizza.DefinirSabor(sabor)}");
    Console.WriteLine("Qual o tamanho da pizza, pequeno 'P', medio 'M', grande 'G'?");
    var tamanho = Console.ReadLine();
    Console.WriteLine($"O tamanho escolhido foi {pizza.DefinirTamanho(tamanho)}");

    Console.WriteLine($"Sua pizza é {pizza}");

}


Console.WriteLine("Fim");

