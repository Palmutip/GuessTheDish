namespace GuessTheDish
{
    partial class FrmStartGame
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStartGame));
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(1, 1);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(250, 54);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Pense em um prato que gosta";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnIniciar.Location = new System.Drawing.Point(87, 69);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "OK";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 45);
            this.panel1.TabIndex = 2;
            // 
            // FrmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(254, 101);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmStartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the dish";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Panel panel1;
    }
}

