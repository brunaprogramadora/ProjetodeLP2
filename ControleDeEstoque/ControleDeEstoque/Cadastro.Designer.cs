namespace ControleDeEstoque
{
    partial class Cadastro
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
            this.Lb_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.lbl_valid = new System.Windows.Forms.Label();
            this.lbl_origem = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.lbl_Func = new System.Windows.Forms.Label();
            this.lbl_Textura = new System.Windows.Forms.Label();
            this.lbl_faixa = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_local = new System.Windows.Forms.Label();
            this.txt_Faixa = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Local = new System.Windows.Forms.TextBox();
            this.txt_Valid = new System.Windows.Forms.TextBox();
            this.txt_Origem = new System.Windows.Forms.TextBox();
            this.txt_Quant = new System.Windows.Forms.TextBox();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Func = new System.Windows.Forms.TextBox();
            this.txt_Textura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lb_Nome
            // 
            this.Lb_Nome.AutoSize = true;
            this.Lb_Nome.Location = new System.Drawing.Point(93, 31);
            this.Lb_Nome.Name = "Lb_Nome";
            this.Lb_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lb_Nome.TabIndex = 0;
            this.Lb_Nome.Text = "Nome";
            this.Lb_Nome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(147, 24);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Location = new System.Drawing.Point(321, 137);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(98, 48);
            this.Btn_Salvar.TabIndex = 2;
            this.Btn_Salvar.Text = "Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_valid
            // 
            this.lbl_valid.AutoSize = true;
            this.lbl_valid.Location = new System.Drawing.Point(80, 101);
            this.lbl_valid.Name = "lbl_valid";
            this.lbl_valid.Size = new System.Drawing.Size(48, 13);
            this.lbl_valid.TabIndex = 3;
            this.lbl_valid.Text = "Validade";
            // 
            // lbl_origem
            // 
            this.lbl_origem.AutoSize = true;
            this.lbl_origem.Location = new System.Drawing.Point(88, 137);
            this.lbl_origem.Name = "lbl_origem";
            this.lbl_origem.Size = new System.Drawing.Size(40, 13);
            this.lbl_origem.TabIndex = 4;
            this.lbl_origem.Text = "Origem";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(91, 277);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_marca.TabIndex = 5;
            this.lbl_marca.Text = "Marca";
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Location = new System.Drawing.Point(66, 172);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(62, 13);
            this.lbl_quant.TabIndex = 6;
            this.lbl_quant.Text = "Quantidade";
            // 
            // lbl_Func
            // 
            this.lbl_Func.AutoSize = true;
            this.lbl_Func.Location = new System.Drawing.Point(49, 66);
            this.lbl_Func.Name = "lbl_Func";
            this.lbl_Func.Size = new System.Drawing.Size(79, 13);
            this.lbl_Func.TabIndex = 7;
            this.lbl_Func.Text = "Funcionalidade";
            // 
            // lbl_Textura
            // 
            this.lbl_Textura.AutoSize = true;
            this.lbl_Textura.Location = new System.Drawing.Point(88, 345);
            this.lbl_Textura.Name = "lbl_Textura";
            this.lbl_Textura.Size = new System.Drawing.Size(43, 13);
            this.lbl_Textura.TabIndex = 8;
            this.lbl_Textura.Text = "Textura";
            // 
            // lbl_faixa
            // 
            this.lbl_faixa.AutoSize = true;
            this.lbl_faixa.Location = new System.Drawing.Point(66, 310);
            this.lbl_faixa.Name = "lbl_faixa";
            this.lbl_faixa.Size = new System.Drawing.Size(62, 13);
            this.lbl_faixa.TabIndex = 9;
            this.lbl_faixa.Text = "Faixa Etaria";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(73, 207);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(55, 13);
            this.lbl_desc.TabIndex = 10;
            this.lbl_desc.Text = "Descrição";
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(64, 242);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(64, 13);
            this.lbl_local.TabIndex = 11;
            this.lbl_local.Text = "Localização";
            // 
            // txt_Faixa
            // 
            this.txt_Faixa.Location = new System.Drawing.Point(147, 303);
            this.txt_Faixa.Name = "txt_Faixa";
            this.txt_Faixa.Size = new System.Drawing.Size(100, 20);
            this.txt_Faixa.TabIndex = 12;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(147, 270);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 20);
            this.txt_Marca.TabIndex = 13;
            // 
            // txt_Local
            // 
            this.txt_Local.Location = new System.Drawing.Point(147, 235);
            this.txt_Local.Name = "txt_Local";
            this.txt_Local.Size = new System.Drawing.Size(100, 20);
            this.txt_Local.TabIndex = 14;
            // 
            // txt_Valid
            // 
            this.txt_Valid.Location = new System.Drawing.Point(147, 94);
            this.txt_Valid.Name = "txt_Valid";
            this.txt_Valid.Size = new System.Drawing.Size(100, 20);
            this.txt_Valid.TabIndex = 15;
            // 
            // txt_Origem
            // 
            this.txt_Origem.Location = new System.Drawing.Point(147, 130);
            this.txt_Origem.Name = "txt_Origem";
            this.txt_Origem.Size = new System.Drawing.Size(100, 20);
            this.txt_Origem.TabIndex = 16;
            // 
            // txt_Quant
            // 
            this.txt_Quant.Location = new System.Drawing.Point(147, 165);
            this.txt_Quant.Name = "txt_Quant";
            this.txt_Quant.Size = new System.Drawing.Size(100, 20);
            this.txt_Quant.TabIndex = 17;
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(147, 200);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(100, 20);
            this.txt_Desc.TabIndex = 18;
            // 
            // txt_Func
            // 
            this.txt_Func.Location = new System.Drawing.Point(147, 59);
            this.txt_Func.Name = "txt_Func";
            this.txt_Func.Size = new System.Drawing.Size(100, 20);
            this.txt_Func.TabIndex = 19;
            // 
            // txt_Textura
            // 
            this.txt_Textura.Location = new System.Drawing.Point(147, 338);
            this.txt_Textura.Name = "txt_Textura";
            this.txt_Textura.Size = new System.Drawing.Size(100, 20);
            this.txt_Textura.TabIndex = 20;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 367);
            this.Controls.Add(this.txt_Textura);
            this.Controls.Add(this.txt_Func);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.txt_Quant);
            this.Controls.Add(this.txt_Origem);
            this.Controls.Add(this.txt_Valid);
            this.Controls.Add(this.txt_Local);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.txt_Faixa);
            this.Controls.Add(this.lbl_local);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_faixa);
            this.Controls.Add(this.lbl_Textura);
            this.Controls.Add(this.lbl_Func);
            this.Controls.Add(this.lbl_quant);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.lbl_origem);
            this.Controls.Add(this.lbl_valid);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.Lb_Nome);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Label lbl_valid;
        private System.Windows.Forms.Label lbl_origem;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.Label lbl_quant;
        private System.Windows.Forms.Label lbl_Func;
        private System.Windows.Forms.Label lbl_Textura;
        private System.Windows.Forms.Label lbl_faixa;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.TextBox txt_Faixa;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Local;
        private System.Windows.Forms.TextBox txt_Valid;
        private System.Windows.Forms.TextBox txt_Origem;
        private System.Windows.Forms.TextBox txt_Quant;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_Func;
        private System.Windows.Forms.TextBox txt_Textura;
    }
}