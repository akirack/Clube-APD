using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClubeAPD.classes
{
    /// <summary>
    /// classe statica onde sao guardados dados globais
    /// <summary>
    public static class main
    {
        //dados aplicação
        public static string nomePrograma = "ClubeAPD";
        public static string versaoPrograma = "V1.0.0";
        public static int versaoInterna = 1;
        

        // pastas 
        public static string pastaDados;
        public static string pastaFotografia;

        // pastas 
        public static string nomeBD = "dados.sdf";
        public static string passBD = "1234";
        public static string connStr;


        // Pontode inicio do programa
        public static void IniciarPrograma()
        {
            #region definicao da pasta de dados

            pastaDados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + nomePrograma + @"\";

            if (!Directory.Exists(pastaDados))
            {
                Directory.CreateDirectory(pastaDados);
            }

            #endregion

            #region definicao da pasta fotografia

            pastaFotografia =  pastaDados + @"fotografias\";

            if (!Directory.Exists(pastaFotografia))
            {
                Directory.CreateDirectory(pastaFotografia);
            }

            #endregion

            #region definicao base de dados

            /// <summary>
            /// Define a string de conexao
            /// <summary>
            connStr = "Data Source = " + pastaDados + nomeBD + "; Password = " + passBD;

            if (!File.Exists(pastaDados + nomeBD))
            {
                cl_criar_bd criar = new cl_criar_bd();
            }

            #endregion

        }

    }
}
