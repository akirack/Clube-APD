using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace ClubeAPD.classes
{

    /// <summary>
    /// Classe para gerir banco de dados
    /// </summary>
    public class cl_gestorBD
    {

        /// <summary>
        /// Classe que permite a criacao de listas de parametros
        /// </summary>
        public class SQLparametros 
        { 
            public string parametro { get; set; }
            public object valor { get; set; }
            

            public SQLparametros(string param, object value)
            {
                parametro = param;
                valor = value;
            }
        }

        SqlCeConnection ligacao = null;
        SqlCeDataAdapter adaptador = null;
        SqlCeCommand comando = null;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public cl_gestorBD()
        {
            ligacao = new SqlCeConnection(main.connStr) ;
        }

        /// <summary>
        /// Executa uma query que retorna uma datatable
        /// </summary>
        public DataTable EXE_READER(string query)
        {
            adaptador = new SqlCeDataAdapter(query, ligacao);
            DataTable dados = new DataTable();

            try
            {
                adaptador.Fill(dados); //prenche o datatable
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }

            return dados;
        }

        /// <summary>
        /// Executa uma query que retorna uma datatable
        /// </summary>
        public DataTable EXE_READER(string query, List<SQLparametros> parametros)
        {
            adaptador = new SqlCeDataAdapter(query, ligacao);
            DataTable dados = new DataTable();

            adaptador.SelectCommand.Parameters.Clear();

            foreach(SQLparametros parametro in parametros)
            {
                adaptador.SelectCommand.Parameters.Add(new SqlCeParameter(parametro.parametro, parametro.valor));
            }

            try
            {
                adaptador.Fill(dados); //prenche o datatable
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO: " + ex.Message);
            }

            return dados;
        }

        /// <summary>
        /// Executa uma query que inseri, altera ou elimina dados em uma tabela
        /// </summary>
        public void EXE_NON_READER(string query, List<SQLparametros> parametros)
        {

            comando = new SqlCeCommand(query);
            comando.Parameters.Clear();

            foreach(SQLparametros parametro in parametros)
            {
                comando.Parameters.Add(new SqlCeParameter(parametro.parametro, parametro.valor));
            }

            ligacao.Open();

            comando.Connection = ligacao;


            comando.ExecuteNonQuery();

            ligacao.Close();

            //ligacao.Dispose();
        }

        public int EXE_COMANDO_SCALAR(string query)
        {
            int valor = -1;

            adaptador = new SqlCeDataAdapter(query, ligacao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            //verificar se existe dados da querry
            if (dados.Rows.Count != 0)
            {
                if (!DBNull.Value.Equals(dados.Rows[0][0]))
                    valor = Convert.ToInt32(dados.Rows[0][0]);
            }

            return valor;
        }

        public int EXE_COMANDO_SCALAR(string query, List<SQLparametros> parametros)
        {
            int valor = -1;

            adaptador = new SqlCeDataAdapter(query, ligacao);
            DataTable dados = new DataTable();

            //add parametros

            adaptador.SelectCommand.Parameters.Clear();
            foreach (SQLparametros parametro in parametros)
            {
                adaptador.SelectCommand.Parameters.Add(new SqlCeParameter(parametro.parametro, parametro.valor));
            }
            
            adaptador.Fill(dados);

            //verificar se existe dados da querry
            if (dados.Rows.Count != 0)
            {
                if (!DBNull.Value.Equals(dados.Rows[0][0]))
                    valor = Convert.ToInt32(dados.Rows[0][0]);
            }

            return valor;
        }

        public void EXE_NON_READER(string query)
        {

            ligacao.Open();
            comando = new SqlCeCommand();
            comando.Connection = ligacao;
            comando.CommandText = query;
            comando.ExecuteNonQuery();
            ligacao.Close();
            ligacao.Dispose();
        }

        public int BUSCAR_ID_DISPONIVEL(string tabela, string campoID)
        {
            int id_temp = -1;

            id_temp = EXE_COMANDO_SCALAR("SELECT MAX(" + campoID + ") AS MaxID FROM " + tabela) + 1;

            return id_temp;
        }
    }
}
