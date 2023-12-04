using Microsoft.Data.Sqlite;

namespace ProjetoEmTresCamadas.Pizzaria.DAO;

public class PizzaVo : EntidadeBaseVo
{
    public string Sabor { get; set; }
    public int TamanhoDePizza { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
}

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
                    TAMANHODAPIZZA INTEGER,
                    VALOR REAL
                )";
                cmd.ExecuteNonQuery();
            }
        }

    }

    public int CriarPizza(PizzaVo pizzaVo)
    {
        using (var sqlConnection = new SqliteConnection(ConnectionString))
        {
            sqlConnection.Open();

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = @"
                INSERT INTO TB_PIZZA (Sabor, Descricao, TAMANHODAPIZZA, VALOR)
                VALUES (@Sabor, @Descricao, @TAMANHODAPIZZA, @VALOR)";
                
                command.Parameters.AddWithValue("@Sabor", pizzaVo.Sabor);
                command.Parameters.AddWithValue("@Descricao", pizzaVo.Descricao);
                command.Parameters.AddWithValue("@TAMANHODAPIZZA", (int)pizzaVo.TamanhoDePizza);
                command.Parameters.AddWithValue("@VALOR", pizzaVo.Valor);

                return command.ExecuteNonQuery();                
            }
        }
    }

    public List<PizzaVo> ObterPizzas()
    {
        List<PizzaVo> pizzas = new List<PizzaVo>();
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
                        PizzaVo pizza = new PizzaVo
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Sabor = reader["Sabor"].ToString(),
                            Descricao = reader["Descricao"].ToString(),
                            TamanhoDePizza = Convert.ToInt32(reader["TAMANHODAPIZZA"]),
                            Valor = Convert.ToDouble(reader["VALOR"])
                        };
                        pizzas.Add(pizza);
                    }
                }
            }
        }
        return pizzas;
    }
}
