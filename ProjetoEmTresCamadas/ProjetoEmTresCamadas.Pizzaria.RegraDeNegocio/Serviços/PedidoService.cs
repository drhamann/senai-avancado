using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Regras;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Serviços;
public class PedidoService :
    IPedidoService,
    IObter<Pedido>,
    IAdicionar<Pedido>
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

    public string ObterInformacoesPedidos()
    {
        throw new NotImplementedException();
    }

    public List<Pedido> ObterTodos()
    {
        throw new NotImplementedException();
    }
}
