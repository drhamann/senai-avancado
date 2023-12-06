using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Regras;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Serviços;

public class ClienteService : IObter<Cliente>, IAdicionar<Cliente>
{
    public Cliente Adicionar(Cliente objeto)
    {
        throw new NotImplementedException();
    }

    public List<Cliente> ObterTodos()
    {
        throw new NotImplementedException();
    }
}
