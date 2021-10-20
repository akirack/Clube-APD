
namespace ClubeAPD
{
    partial class frmSocios_Editar
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_morada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_codigo_postal_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_masculino = new System.Windows.Forms.RadioButton();
            this.radio_feminino = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.text_codigo_postal_2 = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pic_fotografia = new System.Windows.Forms.PictureBox();
            this.cmd_remover_foto = new System.Windows.Forms.Button();
            this.cmd_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotografia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome ";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(166, 89);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(419, 23);
            this.text_nome.TabIndex = 1;
            // 
            // text_morada
            // 
            this.text_morada.Location = new System.Drawing.Point(166, 165);
            this.text_morada.Name = "text_morada";
            this.text_morada.Size = new System.Drawing.Size(419, 23);
            this.text_morada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Morada";
            // 
            // text_codigo_postal_1
            // 
            this.text_codigo_postal_1.Location = new System.Drawing.Point(166, 247);
            this.text_codigo_postal_1.Name = "text_codigo_postal_1";
            this.text_codigo_postal_1.Size = new System.Drawing.Size(117, 23);
            this.text_codigo_postal_1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo postal";
            // 
            // radio_masculino
            // 
            this.radio_masculino.AutoSize = true;
            this.radio_masculino.Checked = true;
            this.radio_masculino.Location = new System.Drawing.Point(166, 303);
            this.radio_masculino.Name = "radio_masculino";
            this.radio_masculino.Size = new System.Drawing.Size(80, 19);
            this.radio_masculino.TabIndex = 6;
            this.radio_masculino.TabStop = true;
            this.radio_masculino.Text = "Masculino";
            this.radio_masculino.UseVisualStyleBackColor = true;
            // 
            // radio_feminino
            // 
            this.radio_feminino.AutoSize = true;
            this.radio_feminino.Location = new System.Drawing.Point(166, 328);
            this.radio_feminino.Name = "radio_feminino";
            this.radio_feminino.Size = new System.Drawing.Size(75, 19);
            this.radio_feminino.TabIndex = 7;
            this.radio_feminino.Text = "Feminino";
            this.radio_feminino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de nascimento";
            // 
            // dtp_Data
            // 
            this.dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Data.Location = new System.Drawing.Point(166, 401);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(117, 23);
            this.dtp_Data.TabIndex = 9;
            // 
            // text_codigo_postal_2
            // 
            this.text_codigo_postal_2.Location = new System.Drawing.Point(289, 247);
            this.text_codigo_postal_2.Name = "text_codigo_postal_2";
            this.text_codigo_postal_2.Size = new System.Drawing.Size(296, 23);
            this.text_codigo_postal_2.TabIndex = 10;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(496, 461);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(89, 40);
            this.cmd_cancelar.TabIndex = 11;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_fotografia
            // 
            this.pic_fotografia.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pic_fotografia.Location = new System.Drawing.Point(22, 58);
            this.pic_fotografia.Name = "pic_fotografia";
            this.pic_fotografia.Size = new System.Drawing.Size(117, 145);
            this.pic_fotografia.TabIndex = 13;
            this.pic_fotografia.TabStop = false;
            this.pic_fotografia.Click += new System.EventHandler(this.pic_fotografia_Click);
            // 
            // cmd_remover_foto
            // 
            this.cmd_remover_foto.Location = new System.Drawing.Point(33, 216);
            this.cmd_remover_foto.Name = "cmd_remover_foto";
            this.cmd_remover_foto.Size = new System.Drawing.Size(88, 33);
            this.cmd_remover_foto.TabIndex = 14;
            this.cmd_remover_foto.Text = "Remover";
            this.cmd_remover_foto.UseVisualStyleBackColor = true;
            this.cmd_remover_foto.Click += new System.EventHandler(this.cmd_remover_foto_Click);
            // 
            // cmd_novo
            // 
            this.cmd_novo.Location = new System.Drawing.Point(271, 461);
            this.cmd_novo.Name = "cmd_novo";
            this.cmd_novo.Size = new System.Drawing.Size(89, 40);
            this.cmd_novo.TabIndex = 15;
            this.cmd_novo.Text = "Novo";
            this.cmd_novo.UseVisualStyleBackColor = true;
            this.cmd_novo.Click += new System.EventHandler(this.cmd_novo_Click);
            // 
            // frmSocios_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(610, 513);
            this.Controls.Add(this.cmd_novo);
            this.Controls.Add(this.cmd_remover_foto);
            this.Controls.Add(this.pic_fotografia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.text_codigo_postal_2);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radio_feminino);
            this.Controls.Add(this.radio_masculino);
            this.Controls.Add(this.text_codigo_postal_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_morada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSocios_Editar";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotografia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_morada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_codigo_postal_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_masculino;
        private System.Windows.Forms.RadioButton radio_feminino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.TextBox text_codigo_postal_2;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pic_fotografia;
        private System.Windows.Forms.Button cmd_remover_foto;
        private System.Windows.Forms.Button cmd_novo;
    }
}