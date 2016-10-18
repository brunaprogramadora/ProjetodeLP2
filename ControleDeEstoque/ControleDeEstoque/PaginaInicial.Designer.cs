namespace ControleDeEstoque
{
    partial class PaginaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Novo
            // 
            this.btn_Novo.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Image")));
            this.btn_Novo.Location = new System.Drawing.Point(418, 236);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(196, 77);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "NOVO CADASTRO";
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Font = new System.Drawing.Font("Linux Biolinum G", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consulta.Image = ((System.Drawing.Image)(resources.GetObject("btn_Consulta.Image")));
            this.btn_Consulta.Location = new System.Drawing.Point(418, 353);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(196, 74);
            this.btn_Consulta.TabIndex = 1;
            this.btn_Consulta.Text = "CONSULTA\r\n";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 585);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Novo);
            this.Name = "PaginaInicial";
            this.Text = "Pagina Inicial";
            this.Load += new System.EventHandler(this.PaginaInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Consulta;
    }
}

