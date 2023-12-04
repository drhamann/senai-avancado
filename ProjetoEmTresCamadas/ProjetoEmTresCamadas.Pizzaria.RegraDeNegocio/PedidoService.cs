using ProjetoEmTresCamadas.Pizzaria.DAO;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

/// <summary>
///  - Fazer pedidos associando clientes e pizzas.
///  - Adicionar clientes.
///  - Adicionar pizzas.
///  - Obter todos os clientes.
///  - Obter todas as pizzas.
///  - Exibir informações sobre clientes, pizzas e pedidos.
/// </summary>

public interface IPedidoService
{
    void FazerPedido(Cliente cliente, Pizza pizza);
    string ObterInformacoesGerais();
}

public interface IAdicionar<T>
{
    T Adicionar(T objeto);
}
public interface IObter<T>
{
    List<T> ObterTodos();
}

public class PizzaService :
    IAdicionar<Pizza>,
    IObter<Pizza>
{
    private PizzaDao PizzaDao { get; set; }

    public PizzaService(PizzaDao pizzaDao)
    {
        PizzaDao = pizzaDao;
    }

    public PizzaService()
    {
        PizzaDao = new PizzaDao();
    }

    public Pizza Adicionar(Pizza objeto)
    {

        PizzaVo pizzaVo = new PizzaVo()
        {
            Descricao = objeto.Descricao,
            Sabor = objeto.Sabor,
            TamanhoDePizza = Convert.ToInt32(objeto.TamanhoDePizza),
            Valor = objeto.Valor
        };
        objeto.Id = PizzaDao.CriarPizza(pizzaVo);
        return objeto;
    }

    public List<Pizza> ObterTodos()
    {
        List<Pizza> pizzas = new List<Pizza>();
        List<PizzaVo> pizzasBanco = PizzaDao.ObterPizzas();

        foreach (PizzaVo pizzaVo in pizzasBanco)
        {
            Pizza pizza = new Pizza()
            {
                Descricao = pizzaVo.Descricao,
                Sabor = pizzaVo.Sabor,
                TamanhoDePizza = (TamanhoDePizza)pizzaVo.TamanhoDePizza,
                Valor = pizzaVo.Valor,
                Id = pizzaVo.Id,
            };
            pizzas.Add(pizza);
        }
        return pizzas;
    }
}


public class PedidoService :
    IPedidoService,
    IObter<Pedido>,
    IObter<Cliente>,
    IAdicionar<Pedido>,
    IAdicionar<Cliente>
{
    public Pedido Adicionar(Pedido objeto)
    {
        throw new NotImplementedException();
    }

    public Cliente Adicionar(Cliente objeto)
    {
        throw new NotImplementedException();
    }

    public void FazerPedido(Cliente cliente, Pizza pizza)
    {
        throw new NotImplementedException();
    }

    public string ObterInformacoesGerais()
    {
        throw new NotImplementedException();
    }

    public List<Pedido> ObterTodos()
    {
        throw new NotImplementedException();
    }

    List<Cliente> IObter<Cliente>.ObterTodos()
    {
        throw new NotImplementedException();
    }
}
