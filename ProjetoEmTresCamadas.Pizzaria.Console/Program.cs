
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Serviços;

var pizzaService = new PizzaService();


Console.WriteLine("Bem vindo a nossa pizaria");
Console.WriteLine("Gostaria de uma pizza, S para sim e N para não?");
var resposta = "S";// Console.ReadLine();

if (resposta == "S")
{
    var pizza = new Pizza()
    {
        Descricao = "Pizza com calabresa e massa tradicional e molho de tomate.",
        Sabor = "Calabresa",
        TamanhoDePizza = TamanhoDePizza.Grande,
        Valor = 78
    };

    pizza = pizzaService.Adicionar(pizza);
    Console.WriteLine($"Sua pizza é {pizza}");

}


var pizzas = pizzaService.ObterTodos();

Console.WriteLine("Fim");

