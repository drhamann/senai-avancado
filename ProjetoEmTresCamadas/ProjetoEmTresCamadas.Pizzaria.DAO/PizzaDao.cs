using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.DAO.ValueObjects;

namespace ProjetoEmTresCamadas.Pizzaria.DAO;

public class PizzaDao : BaseDao<PizzaVo>
{
    private const string TABELA_PIZZA = @"CREATE TABLE IF NOT EXISTS TB_PIZZA
                (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sabor VARCHAR(50) not null,
                    Descricao VARCHAR(100),
                    TAMANHODAPIZZA INTEGER,
                    VALOR REAL
                )";
    private const string INSERIR_PIZZA = @"
                INSERT INTO TB_PIZZA (Sabor, Descricao, TAMANHODAPIZZA, VALOR)
                VALUES (@Sabor, @Descricao, @TAMANHODAPIZZA, @VALOR)";

    private const string SELECT_PIZZA = @"SELECT * FROM TB_PIZZA";

    public PizzaDao() : base(TABELA_PIZZA, SELECT_PIZZA, INSERIR_PIZZA)
    {
    }

    protected override PizzaVo CriarInstancia(SqliteDataReader sqliteDataReader)
    {
        return new PizzaVo
        {
            Id = Convert.ToInt32(sqliteDataReader["Id"]),
            Sabor = sqliteDataReader["Sabor"].ToString(),
            Descricao = sqliteDataReader["Descricao"].ToString(),
            TamanhoDePizza = Convert.ToInt32(sqliteDataReader["TAMANHODAPIZZA"]),
            Valor = Convert.ToDouble(sqliteDataReader["VALOR"])
        };
    }
}
