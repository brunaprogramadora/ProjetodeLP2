namespace Projeto
{
    partial class Projeto
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
            this.AddProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddProduto
            // 
            this.AddProduto.Location = new System.Drawing.Point(290, 115);
            this.AddProduto.Name = "AddProduto";
            this.AddProduto.Size = new System.Drawing.Size(112, 23);
            this.AddProduto.TabIndex = 0;
            this.AddProduto.Text = "Novo Produto";
            this.AddProduto.UseVisualStyleBackColor = true;
            this.AddProduto.Click += new System.EventHandler(this.AddProduto_Click);
            // 
            // Projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 349);
            this.Controls.Add(this.AddProduto);
            this.Name = "Projeto";
            this.Text = "Projeto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddProduto;
    }
}