﻿using Microsoft.Data.Sqlite;

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
                cmd.CommandText = @"CREATE TABLE IF NOT EXISTS  TB_PIZZA
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

}
