using ClubeAPD.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ClubeAPD
{
    /// <summary>
    /// Formulario de controle dos socios
    /// </summary>
    public partial class frmSocios : Form
    {

        int id_socio;

        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            //controi o DataGridView
            constroiGrelhaSocio();
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //Fecha a janela
            this.Close();
        }

        /// <summary>
        /// Metodo para construção do DataGridView
        /// </summary>
        public void constroiGrelhaSocio()
        {
            cl_gestorBD gestor = new cl_gestorBD();
            DataTable dados = gestor.EXE_READER("SELECT * FROM socios ORDER BY nome ASC");

            //Organizar informaçoes em dados
            dados.Columns.Add("foto", typeof(Image));
            dados.Columns.Add("strSexo", typeof(string));

            dados.Columns["foto"].SetOrdinal(0);
            dados.Columns["nome"].SetOrdinal(1);
            dados.Columns["strSexo"].SetOrdinal(2);
            dados.Columns["morada"].SetOrdinal(3);
            dados.Columns["codigo_postal"].SetOrdinal(4);
            dados.Columns["data_nascimento"].SetOrdinal(5);

            foreach (DataRow linha in dados.Rows)
            {

                // trata o codigo postal
                string codigo_postal = linha["codigo_postal"].ToString().Replace("£"," - ");
                linha["codigo_postal"] = codigo_postal;

                //trata a data de nascimento
                DateTime dataNascimento = Convert.ToDateTime(linha["data_nascimento"]);
                string data = dataNascimento.Day.ToString("00") +
                              "-" + dataNascimento.Month.ToString("00") +
                              "-" + dataNascimento.Year.ToString();

                linha["data_nascimento"] = data;

                //trata do sexo
                int sexo = Convert.ToInt16(linha["sexo"]);
                if(sexo == 0)
                {
                    linha["strSexo"] = "Masculino";

                }
                else
                {
                    linha["strSexo"] = "Feminino";
                }

                //trata fotografia 
                string ficheiro = linha["fotografia"].ToString();
                Image img = new Bitmap(100, 100);

                if(ficheiro != "")
                {
                    if (File.Exists(ficheiro))
                    {
                        img = Image.FromFile(ficheiro);
                    }
                }

                linha["foto"] = img;
            }

            grelha_cotas.DataSource = dados;

            cl_grelha grelha = new cl_grelha(grelha_cotas);
            grelha.DefineVisibilidade(new List<string>() {"foto","nome", "strSexo", "morada", "codigo_postal", "data_nascimento"});
            grelha.DefinirCabecalho(new List<string>() {"fotografia", "Nome", "Sexo", "Morada",  "Codigo postal", "Data de nascimento" });
            grelha.DefinirLarguraColunas(new List<int>() { 10, 20, 10, 30, 20, 10});
            grelha.DefinirAlinahmentos(new List<string>() {"centro", "esquerda", "centro", "esquerda", "esquerda", "centro"  });

            lb_socios_na_base.Text = "Registros: " + grelha_cotas.RowCount.ToString();
            cmd_apagar.Enabled = false;
            cmd_apagar_tudo.Enabled = grelha_cotas.RowCount == 0 ? false:true;
        }

        private void cmd_novo_socio_Click(object sender, EventArgs e)
        {
            frmSocios_Editar f = new frmSocios_Editar();
            f.ShowDialog();

            //reconstrucao da grelha socio
            constroiGrelhaSocio();
        }

        private void grelha_socio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }

            id_socio = (int)grelha_cotas["id_socio", e.RowIndex].Value;
            cmd_apagar.Enabled = true;
        }

        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja eliminar o socio selecionado", "Eliminar socio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            cl_gestorBD gestor = new cl_gestorBD();
            gestor.EXE_NON_READER("DELETE FROM socios WHERE id_socio = " + id_socio);

            constroiGrelhaSocio();
        }

        private void cmd_apagar_tudo_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja eliminar todos os socios", "Eliminar todos os socios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            cl_gestorBD gestor = new cl_gestorBD();
            gestor.EXE_NON_READER("DELETE FROM socios");

            constroiGrelhaSocio();
        }

        private void grelha_cotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            id_socio = (int)grelha_cotas["id_socio", e.RowIndex].Value;

            frmSocios_Editar f = new frmSocios_Editar(id_socio);
            f.ShowDialog();

            constroiGrelhaSocio();
        }
    }
}
