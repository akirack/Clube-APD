using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubeAPD.classes
{
    /// <summary>
    /// Controla a forma como os dados sao apresentados
    /// </summary>
    class cl_grelha
    {
        DataGridView grelha = null;

        public cl_grelha(DataGridView grelha)
        {
            this.grelha = grelha;
        }

        public void DefineVisibilidade(List<string> listaColunasVisiveis)
        {
            foreach(DataGridViewColumn coluna in grelha.Columns)
            {
                if (listaColunasVisiveis.Contains(coluna.Name))
                {
                    coluna.Visible = true;
                }
                else
                {
                    coluna.Visible = false;
                }
            }
        }

        public void DefinirCabecalho(List<string> listaCabecalhos)
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in grelha.Columns)
            {
                if (coluna.Visible)
                {
                    coluna.HeaderText = listaCabecalhos[index];
                    index++;
                }
            }
        }

        public void DefinirLarguraColunas(List<int> listaLarguras)
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in grelha.Columns)
            {
                if (coluna.Visible)
                {
                    int novaLargura = Percentagem(listaLarguras[index]);
                    coluna.Width = novaLargura;
                    index++;
                }
            }
        }

        public void DefinirAlinahmentos(List<string> ListaAlinhamentos)
        {
            int index = 0;
            foreach (DataGridViewColumn coluna in grelha.Columns)
            {
                if (coluna.Visible)
                {
                    
                    if (ListaAlinhamentos[index] == "esquerda") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    
                    if (ListaAlinhamentos[index] == "centro") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    
                    if (ListaAlinhamentos[index] == "direita") coluna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    index++;
                }
            }
        }

        private int Percentagem(int percentagemColuna)
        {
            return (percentagemColuna * (grelha.Width - 20))/100;
        }
    }
}
