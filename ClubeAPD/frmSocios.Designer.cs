
namespace ClubeAPD
{
    partial class frmSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lb_registros = new System.Windows.Forms.Label();
            this.grelha_cotas = new System.Windows.Forms.DataGridView();
            this.lb_socios_na_base = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_novo_socio = new System.Windows.Forms.Button();
            this.cmd_apagar_tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(765, 481);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(89, 41);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // lb_registros
            // 
            this.lb_registros.AutoSize = true;
            this.lb_registros.Location = new System.Drawing.Point(12, 481);
            this.lb_registros.Name = "lb_registros";
            this.lb_registros.Size = new System.Drawing.Size(65, 15);
            this.lb_registros.TabIndex = 1;
            this.lb_registros.Text = "Resistros: 0";
            // 
            // grelha_cotas
            // 
            this.grelha_cotas.AllowUserToAddRows = false;
            this.grelha_cotas.AllowUserToDeleteRows = false;
            this.grelha_cotas.AllowUserToResizeRows = false;
            this.grelha_cotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha_cotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grelha_cotas.Location = new System.Drawing.Point(12, 61);
            this.grelha_cotas.Name = "grelha_cotas";
            this.grelha_cotas.RowHeadersVisible = false;
            this.grelha_cotas.RowTemplate.Height = 25;
            this.grelha_cotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_cotas.Size = new System.Drawing.Size(842, 401);
            this.grelha_cotas.TabIndex = 2;
            this.grelha_cotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_socio_CellClick);
            this.grelha_cotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cotas_CellContentClick);
            // 
            // lb_socios_na_base
            // 
            this.lb_socios_na_base.AutoSize = true;
            this.lb_socios_na_base.Location = new System.Drawing.Point(12, 32);
            this.lb_socios_na_base.Name = "lb_socios_na_base";
            this.lb_socios_na_base.Size = new System.Drawing.Size(199, 15);
            this.lb_socios_na_base.TabIndex = 3;
            this.lb_socios_na_base.Text = "Socios registrados na base de dados:";
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(554, 481);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(89, 41);
            this.cmd_apagar.TabIndex = 4;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_novo_socio
            // 
            this.cmd_novo_socio.Location = new System.Drawing.Point(658, 481);
            this.cmd_novo_socio.Name = "cmd_novo_socio";
            this.cmd_novo_socio.Size = new System.Drawing.Size(89, 41);
            this.cmd_novo_socio.TabIndex = 5;
            this.cmd_novo_socio.Text = "Novo Socio...";
            this.cmd_novo_socio.UseVisualStyleBackColor = true;
            this.cmd_novo_socio.Click += new System.EventHandler(this.cmd_novo_socio_Click);
            // 
            // cmd_apagar_tudo
            // 
            this.cmd_apagar_tudo.Location = new System.Drawing.Point(398, 481);
            this.cmd_apagar_tudo.Name = "cmd_apagar_tudo";
            this.cmd_apagar_tudo.Size = new System.Drawing.Size(135, 41);
            this.cmd_apagar_tudo.TabIndex = 6;
            this.cmd_apagar_tudo.Text = "Apagar tudo";
            this.cmd_apagar_tudo.UseVisualStyleBackColor = true;
            this.cmd_apagar_tudo.Click += new System.EventHandler(this.cmd_apagar_tudo_Click);
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.cmd_apagar_tudo);
            this.Controls.Add(this.cmd_novo_socio);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.lb_socios_na_base);
            this.Controls.Add(this.grelha_cotas);
            this.Controls.Add(this.lb_registros);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label lb_registros;
        private System.Windows.Forms.DataGridView grelha_cotas;
        private System.Windows.Forms.Label lb_socios_na_base;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_novo_socio;
        private System.Windows.Forms.Button cmd_apagar_tudo;
    }
}