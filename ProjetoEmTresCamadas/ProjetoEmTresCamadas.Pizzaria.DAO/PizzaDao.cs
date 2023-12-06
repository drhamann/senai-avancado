using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.DAO.Regras;
using ProjetoEmTresCamadas.Pizzaria.DAO.ValueObjects;

namespace ProjetoEmTresCamadas.Pizzaria.DAO;

public interface IPizzaDao: IDao<PizzaVo>
{

}
public class PizzaDao :  BaseDao<PizzaVo>, IPizzaDao
{
    private const string TABELA_PIZZA_NOME = "TB_PIZZA";

    private const string TABELA_PIZZA = @$"CREATE TABLE IF NOT EXISTS {TABELA_PIZZA_NOME}
                (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Sabor VARCHAR(50) not null,
                    Descricao VARCHAR(100),
                    TamanhoDePizza INTEGER,
                    Valor REAL
                )";

    private const string INSERIR_PIZZA = @$"
                INSERT INTO {TABELA_PIZZA_NOME} (Sabor, Descricao, TamanhoDePizza, Valor)
                VALUES (@Sabor, @Descricao, @TamanhoDePizza, @Valor)";

    private const string SELECT_PIZZA = @$"SELECT * FROM {TABELA_PIZZA_NOME}";

    public PizzaDao() : base(TABELA_PIZZA, SELECT_PIZZA, INSERIR_PIZZA, TABELA_PIZZA_NOME) { }

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
