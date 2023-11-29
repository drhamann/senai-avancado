using Microsoft.Data.Sqlite;

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
        using ( 
            SqliteConnection sqlConnection 
            = new SqliteConnection(ConnectionString)
            )
        {
            sqlConnection.Open();
            using(SqliteCommand cmd = sqlConnection.CreateCommand())
            {
                cmd.CommandText = @"CREATE TABLE TB_PIZZA
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


    /*
             using (SqliteCommand command = new SqliteCommand() { Connection = connection })
             {
                 command.CommandText =
                     @"CREATE TABLE IF NOT EXISTS Pizza
                      (
                         Id INTEGER PRIMARY KEY AUTOINCREMENT,
                         Sabor TEXT,
                         Descricao TEXT,
                         TamanhoDePizza INTEGER
                         
                      )";
                 command.ExecuteNonQuery();
             }
         }*/

}
