using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using ClubeAPD.classes;

namespace ClubeAPD
{
    /// <summary>
    /// Classe para criar banco de dados
    /// </summary>
    class cl_criar_bd
    {
        public cl_criar_bd()
        {
            #region criar bd
            SqlCeEngine motor = new SqlCeEngine(main.connStr);
            motor.CreateDatabase();
            #endregion

            SqlCeConnection ligacao = new SqlCeConnection(main.connStr);
            ligacao.Open();
            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligacao;

            #region criar tabela socio


            comando.CommandText =
                "CREATE TABLE socios(" +
                "id_socio               INT NOT NULL PRIMARY KEY," +
                "nome                   NVARCHAR(50)," +
                "morada                 NVARCHAR(100)," +
                "codigo_postal          NVARCHAR(50)," +
                "sexo                   BIT," +
                "data_nascimento        DATETIME," +
                "fotografia             NVARCHAR(250)," +
                "atualizacao            DATETIME)";

            comando.ExecuteNonQuery(); //executa opercao sem retornar valores

            #endregion


            #region criar tabela cota

            comando.CommandText =
                "CREATE TABLE cotas(" +
                "id_cota                INT NOT NULL PRIMARY KEY," +
                "id_socio               INT," +
                "data_pagamento         DATETIME," +
                "quantia                INT," +
                "atualizacao            DATETIME," +
                "FOREIGN KEY(id_socio) REFERENCES socios(id_socio) ON DELETE CASCADE)";

            comando.ExecuteNonQuery(); //executa opercao sem retornar valores

            #endregion

            ligacao.Close();
            ligacao.Dispose();
            comando.Dispose();
        }
    }
}
