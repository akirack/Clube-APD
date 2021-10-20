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
    /// Menu inicial
    /// </summary>

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lb_numSocio.Text = "Numero de socios atuais: " + NumeroSocio().ToString();
            
        }


        /// <summary>
        /// Retorna o numero de socios
        /// </summary>
        private int NumeroSocio()
        {
            cl_gestorBD gestor = new cl_gestorBD();
            DataTable dados = gestor.EXE_READER("SELECT COUNT(id_socio) AS NumSocios From socios"); // Cria um comando Select e recuperar o numero de id´s em uma nova coluna chamada NumSocios

            return Convert.ToInt16(dados.Rows[0]["NumSocios"]);
        }

        private void cmd_Sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //Fecha a aplicacao
            Application.Exit();
        }

        private void cmd_Socios_Click(object sender, EventArgs e)
        {
            frmSocios f = new frmSocios();
            f.ShowDialog();
        }

        private void cmd_cotas_Click(object sender, EventArgs e)
        {
            frmCotas f = new frmCotas();
            f.ShowDialog();
        }
    }
}
