
namespace ClubeAPD
{
    partial class frmCotas
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
            this.cmd_apagar_tudo = new System.Windows.Forms.Button();
            this.cmd_nova_cota = new System.Windows.Forms.Button();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.lb_socios_na_base = new System.Windows.Forms.Label();
            this.grelha_cotas = new System.Windows.Forms.DataGridView();
            this.lb_registros = new System.Windows.Forms.Label();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lb_saldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_apagar_tudo
            // 
            this.cmd_apagar_tudo.Location = new System.Drawing.Point(402, 466);
            this.cmd_apagar_tudo.Name = "cmd_apagar_tudo";
            this.cmd_apagar_tudo.Size = new System.Drawing.Size(135, 41);
            this.cmd_apagar_tudo.TabIndex = 13;
            this.cmd_apagar_tudo.Text = "Apagar todos ";
            this.cmd_apagar_tudo.UseVisualStyleBackColor = true;
            this.cmd_apagar_tudo.Click += new System.EventHandler(this.cmd_apagar_tudo_Click);
            // 
            // cmd_nova_cota
            // 
            this.cmd_nova_cota.Location = new System.Drawing.Point(658, 466);
            this.cmd_nova_cota.Name = "cmd_nova_cota";
            this.cmd_nova_cota.Size = new System.Drawing.Size(89, 41);
            this.cmd_nova_cota.TabIndex = 12;
            this.cmd_nova_cota.Text = "Nova cota";
            this.cmd_nova_cota.UseVisualStyleBackColor = true;
            this.cmd_nova_cota.Click += new System.EventHandler(this.cmd_nova_cota_Click);
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(554, 466);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(89, 41);
            this.cmd_apagar.TabIndex = 11;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // lb_socios_na_base
            // 
            this.lb_socios_na_base.AutoSize = true;
            this.lb_socios_na_base.Location = new System.Drawing.Point(12, 17);
            this.lb_socios_na_base.Name = "lb_socios_na_base";
            this.lb_socios_na_base.Size = new System.Drawing.Size(199, 15);
            this.lb_socios_na_base.TabIndex = 10;
            this.lb_socios_na_base.Text = "Socios registrados na base de dados:";
            // 
            // grelha_cotas
            // 
            this.grelha_cotas.AllowUserToAddRows = false;
            this.grelha_cotas.AllowUserToDeleteRows = false;
            this.grelha_cotas.AllowUserToResizeRows = false;
            this.grelha_cotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha_cotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grelha_cotas.Location = new System.Drawing.Point(12, 46);
            this.grelha_cotas.Name = "grelha_cotas";
            this.grelha_cotas.RowHeadersVisible = false;
            this.grelha_cotas.RowTemplate.Height = 25;
            this.grelha_cotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_cotas.Size = new System.Drawing.Size(842, 401);
            this.grelha_cotas.TabIndex = 9;
            this.grelha_cotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cotas_CellClick);
            this.grelha_cotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_cotas_CellContentClick);
            // 
            // lb_registros
            // 
            this.lb_registros.AutoSize = true;
            this.lb_registros.Location = new System.Drawing.Point(12, 466);
            this.lb_registros.Name = "lb_registros";
            this.lb_registros.Size = new System.Drawing.Size(65, 15);
            this.lb_registros.TabIndex = 8;
            this.lb_registros.Text = "Resistros: 0";
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(765, 466);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(89, 41);
            this.cmd_fechar.TabIndex = 7;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // lb_saldo
            // 
            this.lb_saldo.AutoSize = true;
            this.lb_saldo.Location = new System.Drawing.Point(12, 492);
            this.lb_saldo.Name = "lb_saldo";
            this.lb_saldo.Size = new System.Drawing.Size(51, 15);
            this.lb_saldo.TabIndex = 14;
            this.lb_saldo.Text = "Saldo:  0";
            this.lb_saldo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmCotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 534);
            this.Controls.Add(this.lb_saldo);
            this.Controls.Add(this.cmd_apagar_tudo);
            this.Controls.Add(this.cmd_nova_cota);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.lb_socios_na_base);
            this.Controls.Add(this.grelha_cotas);
            this.Controls.Add(this.lb_registros);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCotas";
            this.Text = "frmCotas";
            this.Load += new System.EventHandler(this.frmCotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_cotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_apagar_tudo;
        private System.Windows.Forms.Button cmd_nova_cota;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Label lb_socios_na_base;
        private System.Windows.Forms.DataGridView grelha_cotas;
        private System.Windows.Forms.Label lb_registros;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label lb_saldo;
    }
}