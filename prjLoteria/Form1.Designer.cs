namespace prjLoteria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnCartela = new System.Windows.Forms.Panel();
            this.rbMegaSena = new System.Windows.Forms.RadioButton();
            this.rbQuina = new System.Windows.Forms.RadioButton();
            this.rbLotoFacil = new System.Windows.Forms.RadioButton();
            this.rbLotoMania = new System.Windows.Forms.RadioButton();
            this.btnCartela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnCartela
            // 
            this.pnCartela.BackColor = System.Drawing.Color.White;
            this.pnCartela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCartela.Location = new System.Drawing.Point(0, 0);
            this.pnCartela.Name = "pnCartela";
            this.pnCartela.Size = new System.Drawing.Size(473, 287);
            this.pnCartela.TabIndex = 0;
            // 
            // rbMegaSena
            // 
            this.rbMegaSena.AutoSize = true;
            this.rbMegaSena.Checked = true;
            this.rbMegaSena.Location = new System.Drawing.Point(39, 346);
            this.rbMegaSena.Name = "rbMegaSena";
            this.rbMegaSena.Size = new System.Drawing.Size(88, 17);
            this.rbMegaSena.TabIndex = 1;
            this.rbMegaSena.TabStop = true;
            this.rbMegaSena.Text = "MEGA SENA";
            this.rbMegaSena.UseVisualStyleBackColor = true;
            // 
            // rbQuina
            // 
            this.rbQuina.AutoSize = true;
            this.rbQuina.Location = new System.Drawing.Point(39, 415);
            this.rbQuina.Name = "rbQuina";
            this.rbQuina.Size = new System.Drawing.Size(59, 17);
            this.rbQuina.TabIndex = 2;
            this.rbQuina.Text = "QUINA";
            this.rbQuina.UseVisualStyleBackColor = true;
            // 
            // rbLotoFacil
            // 
            this.rbLotoFacil.AutoSize = true;
            this.rbLotoFacil.Location = new System.Drawing.Point(39, 392);
            this.rbLotoFacil.Name = "rbLotoFacil";
            this.rbLotoFacil.Size = new System.Drawing.Size(86, 17);
            this.rbLotoFacil.TabIndex = 3;
            this.rbLotoFacil.Text = "LOTO FACIL";
            this.rbLotoFacil.UseVisualStyleBackColor = true;
            // 
            // rbLotoMania
            // 
            this.rbLotoMania.AutoSize = true;
            this.rbLotoMania.Location = new System.Drawing.Point(39, 369);
            this.rbLotoMania.Name = "rbLotoMania";
            this.rbLotoMania.Size = new System.Drawing.Size(91, 17);
            this.rbLotoMania.TabIndex = 4;
            this.rbLotoMania.Text = "LOTO MANIA";
            this.rbLotoMania.UseVisualStyleBackColor = true;
            // 
            // btnCartela
            // 
            this.btnCartela.BackColor = System.Drawing.Color.Gray;
            this.btnCartela.ForeColor = System.Drawing.Color.White;
            this.btnCartela.Location = new System.Drawing.Point(255, 345);
            this.btnCartela.Name = "btnCartela";
            this.btnCartela.Size = new System.Drawing.Size(161, 87);
            this.btnCartela.TabIndex = 5;
            this.btnCartela.Text = "GERAR CARTELA";
            this.btnCartela.UseVisualStyleBackColor = false;
            this.btnCartela.Click += new System.EventHandler(this.btnCartela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(473, 502);
            this.Controls.Add(this.btnCartela);
            this.Controls.Add(this.rbLotoMania);
            this.Controls.Add(this.rbLotoFacil);
            this.Controls.Add(this.rbQuina);
            this.Controls.Add(this.rbMegaSena);
            this.Controls.Add(this.pnCartela);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GERADOR DE CARTELA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnCartela;
        private System.Windows.Forms.RadioButton rbMegaSena;
        private System.Windows.Forms.RadioButton rbQuina;
        private System.Windows.Forms.RadioButton rbLotoFacil;
        private System.Windows.Forms.RadioButton rbLotoMania;
        private System.Windows.Forms.Button btnCartela;
    }
}

