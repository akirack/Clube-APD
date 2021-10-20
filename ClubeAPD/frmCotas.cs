using ClubeAPD.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubeAPD
{
    /// <summary>
    /// form com as informaçoes sobre as cotas 
    /// </summary>
    public partial class frmCotas : Form
    {
        public frmCotas()
        {
            InitializeComponent();
        }

        private void cmd_apagar_tudo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ATENÇAO: deseja apagar todos os dados? ", "ATENÇAO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            { return; }

            cl_gestorBD gestor = new cl_gestorBD();
            gestor.EXE_NON_READER("DELETE FROM cotas");

            ConstroiGrelhaCotas();
        }

        private void cmd_nova_cota_Click(object sender, EventArgs e)
        {
            frm_Cotas_Editar f = new frm_Cotas_Editar();
            f.ShowDialog();
            ConstroiGrelhaCotas();
        }

        private void ConstroiGrelhaCotas()
        {
            cl_gestorBD gestor = new cl_gestorBD();
            DataTable dados = gestor.EXE_READER("SELECT * FROM cotas LEFT JOIN socios ON cotas.id_socio = socios.id_socio ORDER BY cotas.data_pagamento DESC");

            //define a ordem das coluanas
            dados.Columns["nome"].SetOrdinal(0);
            dados.Columns["quantia"].SetOrdinal(1);
            dados.Columns["data_pagamento"].SetOrdinal(2);

            grelha_cotas.DataSource = dados;

            //define aspecto do tabela
            cl_grelha grelha = new cl_grelha(grelha_cotas);
            grelha.DefineVisibilidade(new List<string>() { "nome", "quantia", "data_pagamento" });
            grelha.DefinirCabecalho(new List<string>() { "Nome", "Quantia", "Data de pagamento" });
            grelha.DefinirLarguraColunas(new List<int>() { 50, 20, 30});

            lb_registros.Text = "Registros: " + grelha_cotas.RowCount.ToString();
            cmd_apagar.Enabled = false;
            cmd_apagar_tudo.Enabled = grelha_cotas.RowCount == 0 ? false : true;

            //calcula a soma do valor de cotas
            int totalCotas = gestor.EXE_COMANDO_SCALAR("SELECT COUNT(quantia) FROM cotas");
            if(totalCotas < 0)
            {
                totalCotas = 0;
            }
            lb_saldo.Text = "Saldo: " + totalCotas.ToString();
        }

        private void frmCotas_Load(object sender, EventArgs e)
        {
            ConstroiGrelhaCotas();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grelha_cotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // selecionar a cota para editar os dados  

            if (e.RowIndex == -1)
            {
                return;
            }

            int id_cota = (int)grelha_cotas["id_cota", grelha_cotas.SelectedRows[0].Index].Value;

            //abrir o form para edicao

            frm_Cotas_Editar f = new frm_Cotas_Editar(id_cota);
            f.ShowDialog();

            ConstroiGrelhaCotas();

        }

        private void grelha_cotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativa o comando para eliminar a cota selecionada 

            if (e.RowIndex == -1)
            {
                return;
            }

            cmd_apagar.Enabled = true;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //apaga a cota selecionada 

            if(MessageBox.Show("Deseja apagar a cota selecionada? ", "ATENCAO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int id_cota = (int)grelha_cotas["id_cota", grelha_cotas.SelectedRows[0].Index].Value;

            cl_gestorBD gestor = new cl_gestorBD();
            gestor.EXE_NON_READER("DELETE FROM cotas WHERE id_cota = " + id_cota);

            ConstroiGrelhaCotas();
        }


    }
}
