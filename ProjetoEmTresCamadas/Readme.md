# Aula sobre n-layers

## Apresentado conceito, e criado projeto exemplo de camadas usando o contexto de uma pizzaria

- .net 8
- Sqlite

## Aula 3 

Vamos continuar com nossa pizzaria. Agora vamos adicionar novas funcionalidades:
1. Adicionar cliente.
2. Adicionar pizza.
3. Adicionar pedido.
4. Obter todos os clientes.
5. Obter todas as pizzas.
6. Obter todos os pedidos.

Camada de Apresentação
1. Adicionar pizzas.
2. Adicionar clientes.
3. Fazer pedidos, associando clientes e pizzas.
4. Exibir informações sobre clientes, pizzas e pedidos.

Camada regra de negócio	

Entidades 
	1. `Pizza`:	   - Propriedades: `Id`, `Nome`, `Descricao`, `Preco`.
	2. `Cliente`:  - Propriedades: `Id`, `Nome`.
	3. `Pedido`:  - Propriedades: `Id`, `ClienteId`, `PizzasIds` (lista de IDs de pizzas associadas).

Serviços
	1. `PedidoService`:
	   - Fazer pedidos associando clientes e pizzas.
	   - Adicionar clientes.
	   - Adicionar pizzas.
	   - Obter todos os clientes.
	   - Obter todas as pizzas.
	   - Exibir informações sobre clientes, pizzas e pedidos.

Camada Acesso a Dados (DAO)

1. 1. Tabela `Clientes`:   
	1. - Colunas: `Id` (chave primária), `Nome`.
2. Tabela `Pizzas`: 
	1. - Colunas: `Id` (chave primária), `Nome`, `Descricao`, `Preco`.
3. Tabela `Pedidos`:   
	1.	- Colunas: `Id` (chave primária), `ClienteId`, `PizzasIds` (lista de IDs de pizzas associadas).
