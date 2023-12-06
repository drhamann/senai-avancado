using ProjetoEmTresCamadas.Pizzaria.DAO;
using ProjetoEmTresCamadas.Pizzaria.DAO.ValueObjects;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Regras;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Serviços;

public class PizzaService :
    IAdicionar<Pizza>,
    IObter<Pizza>
{
    private IPizzaDao PizzaDao { get; set; }

    public PizzaService(IPizzaDao pizzaDao)
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
        objeto.Id = PizzaDao.CriarRegistro(pizzaVo);
        return objeto;
    }

    public List<Pizza> ObterTodos()
    {
        List<Pizza> pizzas = new List<Pizza>();
        List<PizzaVo> pizzasBanco = PizzaDao.ObterRegistros();

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
