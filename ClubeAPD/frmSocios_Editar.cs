using ClubeAPD.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubeAPD
{
    /// <summary>
    /// Formulario para a edicao de socios
    /// </summary>
    public partial class frmSocios_Editar : Form
    {
        int id_socio;
        bool editar = false;
        string fotografia = "";

        /// <summary>
        /// Construtor do formulario de ecicao
        /// </summary>
        /// <param name="id_socio">Por padrao o id é igual a -1 para editar ou passa o valor do id do novo socio</param>
        public frmSocios_Editar(int id_socio = -1)
        {
            InitializeComponent();

            //define as variaveis do formulario
            this.id_socio = id_socio;
            editar = id_socio == -1 ? false : true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fecha a janela
            this.Close();
        }

        private void frmSocios_Editar_Load(object sender, EventArgs e)
        {
            //caso id_socio seja diferente de -1, entao mostra os dados dos socio a partir do id passado
            if(editar)
            {
                ApresentaDadosSocio();
            }
        }

        /// <summary>
        /// apresenta os dados do socio
        /// </summary>
        private void ApresentaDadosSocio()
        {
            cl_gestorBD gestor = new cl_gestorBD();
            DataTable dados = gestor.EXE_READER("SELECT * FROM socios WHERE id_socio = " + id_socio);

            // Apresentacao dos dados nos campos do formulario
            DataRow linha = dados.Rows[0];
            text_nome.Text = linha["nome"].ToString();
            text_morada.Text = linha["morada"].ToString();

            string[] itens_codigo_postal = linha["codigo_postal"].ToString().Split('£');
            if(itens_codigo_postal.Length == 1)
            {
                 text_codigo_postal_2.Text = linha["codigo_postal"].ToString();
            }
            else
            {
                text_codigo_postal_1.Text = itens_codigo_postal[0];
                text_codigo_postal_2.Text = itens_codigo_postal[1];
            }

            int sexo = Convert.ToInt16(linha["sexo"]);

            if(sexo == 0)
            {
                radio_masculino.Checked = true;
            }
            else
            {
                radio_feminino.Checked = false;
            }

            dtp_Data.Value = Convert.ToDateTime(linha["data_nascimento"]);

            fotografia = linha["fotografia"].ToString();

            if(fotografia != "")
            {
                if (File.Exists(fotografia))
                {
                    pic_fotografia.BackgroundImage = Image.FromFile(fotografia);
                }
            }

        }

        /// <summary>
        /// Adiciona uma fotografia ao socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_fotografia_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa_abrir = new OpenFileDialog();
            caixa_abrir.Title = main.nomePrograma + " - Escolher fotografia";
            caixa_abrir.InitialDirectory = main.pastaFotografia;
            caixa_abrir.Filter = "Imagens JPEG (*.jpg)|*.jpg| Imagens do tipo png (*.png)|*.png";

            if (caixa_abrir.ShowDialog() == DialogResult.Cancel) return;

            // define a fotografia do socio
            fotografia = caixa_abrir.FileName;
            pic_fotografia.BackgroundImage = Image.FromFile(fotografia);
        }


        /// <summary>
        /// remove a fotografia do socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_remover_foto_Click(object sender, EventArgs e)
        {
            pic_fotografia.BackgroundImage = null;
            fotografia = null;


        }
        /// <summary>
        /// Grava ou altera os dados de um socio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            #region verificacoes

            if(text_nome.Text == "")
            {
                MessageBox.Show("Indique o nome do socio.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_nome.Focus();
                return;
            }

            #endregion

            cl_gestorBD gestor = new cl_gestorBD();

            //busca id disponivel
            if (!editar)
            {
                id_socio = gestor.BUSCAR_ID_DISPONIVEL("socios", "id_socio");
                //MessageBox.Show(id_socio.ToString());
            }

            //tratar codigo postal
            string codigo_postal = "";
            if(text_codigo_postal_1.Text != "" && text_codigo_postal_2.Text != "")
            {
                codigo_postal = text_codigo_postal_1.Text + "£" + text_codigo_postal_2.Text;
            }

            else
            {
                if(text_codigo_postal_1.Text != "")
                {
                    codigo_postal = text_codigo_postal_1.Text;
                }
                else
                {
                    codigo_postal = text_codigo_postal_2.Text;
                }
            }


            //tratar do valor sexo
            int sexo = 0;
            if(radio_feminino.Checked)
            {
                sexo = 1;
            }

            //parametros 

            List<cl_gestorBD.SQLparametros> parametros = new List<cl_gestorBD.SQLparametros>()
            {
                new cl_gestorBD.SQLparametros("@id_socio", id_socio),                         
                new cl_gestorBD.SQLparametros("@nome", text_nome.Text),                       
                new cl_gestorBD.SQLparametros("@morada", text_morada.Text),                   
                new cl_gestorBD.SQLparametros("@codigo_postal", codigo_postal),               
                new cl_gestorBD.SQLparametros("@sexo", sexo),                                 
                new cl_gestorBD.SQLparametros("@data_nascimento", dtp_Data.Value),            
                new cl_gestorBD.SQLparametros("@fotografia", fotografia),                     
                new cl_gestorBD.SQLparametros("@atualizacao", DateTime.Now)                   
                                                                                              
            };

            #region GRAVAR NOVO SOCIO
            if (!editar)
            {
                //verifica se ja existe um socio com o mesmo nome
                DataTable dados = gestor.EXE_READER("SELECT nome FROM socios WHERE nome = @nome", parametros);

                if(dados.Rows.Count != 0)
                {
                    MessageBox.Show("Foi encontrado um socio com o mesmo nome", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

                gestor.EXE_NON_READER("INSERT INTO socios VALUES("+
                                        "@id_socio," +
                                        "@nome," +
                                        "@morada," +
                                        "@codigo_postal," +
                                        "@sexo," +
                                        "@data_nascimento," +
                                        "@fotografia," +
                                        "@atualizacao)", parametros);

                #endregion
            }

            #region EDITAR SOCIO

            else {
                DataTable dados = gestor.EXE_READER("SELECT id_socio, nome FROM socios WHERE nome = @nome AND id_socio <> @id_socio", parametros);
                if(dados.Rows.Count != 0)
                {
                    MessageBox.Show("ERRO: Ja existe um socio com esse nome");
                    return;
                }
            }

            gestor.EXE_NON_READER("UPDATE socios SET " +
                                  "nome = @nome, " +
                                  "morada = @morada, " +
                                  "codigo_postal = @codigo_postal, " +
                                  "sexo = @sexo, " +
                                  "data_nascimento = @data_nascimento, " +
                                  "atualizacao = @atualizacao WHERE id_socio = @id_socio", parametros);



           #endregion
            
            
            
            MessageBox.Show("Dados gravados com sucesso", main.nomePrograma,MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1_Click(cmd_cancelar, EventArgs.Empty);
        }

        private void cmd_novo_Click(object sender, EventArgs e)
        {
            //prepara novo registro

            editar = false;
            id_socio = -1;
            pic_fotografia.BackgroundImage = null;
            fotografia = "";

            foreach(Control c in this.Controls)
            {
                c.Text = "";
            }

            radio_masculino.Checked = true;

            dtp_Data.Value = DateTime.Now;
        }
    }
}