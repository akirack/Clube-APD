
namespace ClubeAPD
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_Sair = new System.Windows.Forms.Button();
            this.lb_numSocio = new System.Windows.Forms.Label();
            this.cmd_Socios = new System.Windows.Forms.Button();
            this.cmd_cotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Sair
            // 
            this.cmd_Sair.Location = new System.Drawing.Point(696, 394);
            this.cmd_Sair.Name = "cmd_Sair";
            this.cmd_Sair.Size = new System.Drawing.Size(92, 44);
            this.cmd_Sair.TabIndex = 0;
            this.cmd_Sair.Text = "Sair";
            this.cmd_Sair.UseVisualStyleBackColor = true;
            this.cmd_Sair.Click += new System.EventHandler(this.cmd_Sair_Click);
            // 
            // lb_numSocio
            // 
            this.lb_numSocio.AutoSize = true;
            this.lb_numSocio.Location = new System.Drawing.Point(13, 422);
            this.lb_numSocio.Name = "lb_numSocio";
            this.lb_numSocio.Size = new System.Drawing.Size(149, 15);
            this.lb_numSocio.TabIndex = 1;
            this.lb_numSocio.Text = "Numero de socios atuais: 0";
            // 
            // cmd_Socios
            // 
            this.cmd_Socios.Location = new System.Drawing.Point(696, 294);
            this.cmd_Socios.Name = "cmd_Socios";
            this.cmd_Socios.Size = new System.Drawing.Size(92, 44);
            this.cmd_Socios.TabIndex = 2;
            this.cmd_Socios.Text = "Socios...";
            this.cmd_Socios.UseVisualStyleBackColor = true;
            this.cmd_Socios.Click += new System.EventHandler(this.cmd_Socios_Click);
            // 
            // cmd_cotas
            // 
            this.cmd_cotas.Location = new System.Drawing.Point(696, 344);
            this.cmd_cotas.Name = "cmd_cotas";
            this.cmd_cotas.Size = new System.Drawing.Size(92, 44);
            this.cmd_cotas.TabIndex = 3;
            this.cmd_cotas.Text = "Cotas";
            this.cmd_cotas.UseVisualStyleBackColor = true;
            this.cmd_cotas.Click += new System.EventHandler(this.cmd_cotas_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_cotas);
            this.Controls.Add(this.cmd_Socios);
            this.Controls.Add(this.lb_numSocio);
            this.Controls.Add(this.cmd_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "AppBD (v1.0.0)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Sair;
        private System.Windows.Forms.Label lb_numSocio;
        private System.Windows.Forms.Button cmd_Socios;
        private System.Windows.Forms.Button cmd_cotas;
    }
}

