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
    /// Form para trabalhar com as cotas 
    /// </summary>
    public partial class frm_Cotas_Editar : Form
    {
        int id_cota = -1;
        bool editar = false;

        public frm_Cotas_Editar(int id_cota = -1)
        {
            InitializeComponent();
            this.id_cota = id_cota;
            editar = id_cota == -1 ? false : true;

        }

        /// <summary>
        /// criar uma nova cota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            editar = false;
            id_cota = -1;
            cmb_socio.Text = "";
            count_qtd.Value = 10;
            dateTimePicker1.Value = DateTime.Now;
          
        }

        private void frm_Cotas_Editar_Load(object sender, EventArgs e)
        {
            ConstroiComboSocios();
        }

        private void ConstroiComboSocios()
        {
            cl_gestorBD gestor = new cl_gestorBD();
            DataTable dados = gestor.EXE_READER("SELECT nome FROM socios ORDER BY nome ASC");

            cmb_socio.Items.Clear();
            cmb_socio.Items.Add("");

            foreach (DataRow linha in dados.Rows)
            {
                cmb_socio.Items.Add(linha["nome"].ToString());
            }
        }

        /// <summary>
        /// gravar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_socio.Text == "")
            {
                MessageBox.Show("Indique o socio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cl_gestorBD gestor = new cl_gestorBD();
            List<cl_gestorBD.SQLparametros> parametros;

            parametros = new List<cl_gestorBD.SQLparametros>()
            {
                new cl_gestorBD.SQLparametros("@nome", cmb_socio.Text)
            };

            if (!editar)
            {
                id_cota = gestor.BUSCAR_ID_DISPONIVEL("cotas", "id_cota");
            }


            int id_socio = gestor.EXE_COMANDO_SCALAR("SELECT id_socio FROM socios WHERE nome = @nome", parametros);


            parametros = new List<cl_gestorBD.SQLparametros>()
            {
                 new cl_gestorBD.SQLparametros("@id_cota", id_cota),
                 new cl_gestorBD.SQLparametros("@id_socio", id_socio),
                 new cl_gestorBD.SQLparametros("@data_pagamento", dateTimePicker1.Value),
                 new cl_gestorBD.SQLparametros("@quantia", count_qtd.Value),
                 //new cl_gestorBD.SQLparametros("@valor", count_qtd.Value),
                 new cl_gestorBD.SQLparametros("@atualizacao", DateTime.Now),

            };

            if (!editar)
            {
                gestor.EXE_NON_READER("INSERT INTO cotas VALUES( " +
                                        "@id_cota, " +
                                        "@id_socio, " +
                                        "@data_pagamento, " +
                                         "@quantia, " +
                                        // "@valor, " +
                                        "@atualizacao)", parametros);
            }

            else
            {
                gestor.EXE_NON_READER("UPDATE cotas SET " +
                                        "id_cota = @id_cota, " +
                                        "data_pagamento = @data_pagamento, " +
                                        "quantia = @quantia, " +
                                        //"valor = @valor, " +
                                        "atualizacao = @atualizacao " + 
                                        "WHERE id_cota = @id_cota", parametros);
            }

            MessageBox.Show("Dados Gravados com sucesso");
            button2_Click(button2, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
