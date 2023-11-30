using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.RegraDeNegocio;

namespace ProjetoEmTresCamadas.Pizzaria.DAO;

public class PizzaDao
{
    private const string ConnectionString = "Data Source=Pizza.db";
    public PizzaDao()
    {
        CriarBancoDeDados();
    }

    public void CriarBancoDeDados()
    {
        using (var sqlConnection = new SqliteConnection(ConnectionString))
        {
            sqlConnection.Open();

            using(var cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS TB_PIZZA
                (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sabor VARCHAR(50) not null,
                    Descricao VARCHAR(100),
                    TAMANHODAPIZZA INTEGER
                )";
                cmd.ExecuteNonQuery();
            }
        }

    }

    public void CriarPizza(Pizza pizzaVo)
    {
        using (var sqlConnection = new SqliteConnection(ConnectionString))
        {
            sqlConnection.Open();

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = @"
                INSERT INTO TB_PIZZA (Sabor, Descricao, TAMANHODAPIZZA)
                VALUES (@Sabor, @Descricao, @TAMANHODAPIZZA)";
                
                command.Parameters.AddWithValue("@Sabor", pizzaVo.Sabor);
                command.Parameters.AddWithValue("@Descricao", pizzaVo.Descricao);
                command.Parameters.AddWithValue("@TAMANHODAPIZZA", (int)pizzaVo.TamanhoDePizza);

                command.ExecuteNonQuery();                
            }
        }
    }

    public List<Pizza> ObterPizzas()
    {
        List<Pizza> pizzas = new List<Pizza>();
        using (var sqlConnection = new SqliteConnection(ConnectionString))
        {
            sqlConnection.Open();
            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = @"SELECT * FROM TB_PIZZA";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pizza pizza = new Pizza
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Sabor = reader["Sabor"].ToString(),
                            Descricao = reader["Descricao"].ToString(),
                            TamanhoDePizza = (TamanhoDePizza)
                            Convert.ToInt32(reader["TAMANHODAPIZZA"])
                        };
                        pizzas.Add(pizza);
                    }
                }
            }
        }
        return pizzas;
    }
}
