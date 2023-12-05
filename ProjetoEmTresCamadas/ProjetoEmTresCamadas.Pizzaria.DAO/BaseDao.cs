using Microsoft.Data.Sqlite;
using ProjetoEmTresCamadas.Pizzaria.DAO.Regras;

namespace ProjetoEmTresCamadas.Pizzaria.DAO;

public abstract class BaseDao<T> : IDao<T>
{
    protected const string CONNECTION_STRING = "Data Source=Pizza.db";
    public string TabelaQuery { get; set; }
    public string SelectQuery { get; set; }
    public string InsertQuery { get; set; }

    protected BaseDao(string tabelaQuery, string selectQuery, string insertQuery)
    {
        TabelaQuery = tabelaQuery;
        SelectQuery = selectQuery;
        InsertQuery = insertQuery;
        CriarBancoDeDados();
    }

    public void CriarBancoDeDados()
    {
        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
        {
            sqlConnection.Open();

            using (var cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = TabelaQuery;
                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<T> ObterRegistros()
    {
        List<T> registros = new List<T>();

        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
        {
            sqlConnection.Open();

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = SelectQuery;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T registro = CriarInstancia(reader);
                        registros.Add(registro);
                    }
                }
            }
        }

        return registros;
    }
    public int CriarRegistro(T objetoVo)
    {
        using (var sqlConnection = new SqliteConnection(CONNECTION_STRING))
        {
            sqlConnection.Open();

            using (var command = sqlConnection.CreateCommand())
            {
                command.CommandText = InsertQuery;

                // Assume que as propriedades do objetoVo correspondem aos parâmetros do comando SQL
                foreach (var propriedade in typeof(T).GetProperties())
                {
                    command.Parameters.AddWithValue($"@{propriedade.Name}", propriedade.GetValue(objetoVo) ?? DBNull.Value);
                }

                return command.ExecuteNonQuery();
            }
        }
    }

    protected abstract T CriarInstancia(SqliteDataReader sqliteDataReader);

}
