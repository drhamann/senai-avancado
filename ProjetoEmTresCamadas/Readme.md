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

## Aula 4 e 5 

1. Adicionar cliente.
1.1 O cliente deve ter histórico de ações
2. Adicionar pizza.
2.1 Pizza deve ter dado de criação
3. Adicionar pedido.
3.1 O pedido deve ter horário de solicitação
3.2 O pedido deve ter horário de finalização da preparação
3.3 O pedido deve ter horário de saída para entrega
3.3 O pedido deve ter horário de finalização da entrega
4. Obter todos os clientes.
5. Obter todas as pizzas.
6. Obter todos os pedidos.
7. Gerar relatório em arquivo texto dos pedidos finalizados mostrando os dados de quem pediu, a pizza, horário que o pedido começou e horário de finalização da preparação, horário que saiu e finalizou a entrega. 
7.1 Deve permitir gerar o relatório escolhendo a data inicial e final 
7.2 Deve ter uma opção de escolher entre arquivo texto e json
