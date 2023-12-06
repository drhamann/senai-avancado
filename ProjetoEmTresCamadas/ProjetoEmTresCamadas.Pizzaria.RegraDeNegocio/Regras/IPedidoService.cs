using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Entidades;

namespace ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio.Regras;

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
    string ObterInformacoesPedidos();
}
