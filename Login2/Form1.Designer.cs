namespace Login2
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
            this.cmd_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_textEmail = new System.Windows.Forms.TextBox();
            this.text_textSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmd_Enter
            // 
            this.cmd_Enter.Location = new System.Drawing.Point(152, 312);
            this.cmd_Enter.Name = "cmd_Enter";
            this.cmd_Enter.Size = new System.Drawing.Size(104, 34);
            this.cmd_Enter.TabIndex = 2;
            this.cmd_Enter.Text = "Enter";
            this.cmd_Enter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmd_Enter.UseVisualStyleBackColor = true;
            this.cmd_Enter.Click += new System.EventHandler(this.cmd_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // text_textEmail
            // 
            this.text_textEmail.Location = new System.Drawing.Point(103, 115);
            this.text_textEmail.Name = "text_textEmail";
            this.text_textEmail.Size = new System.Drawing.Size(205, 22);
            this.text_textEmail.TabIndex = 0;
            this.text_textEmail.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_textEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_textEmail_KeyDown);
            // 
            // text_textSenha
            // 
            this.text_textSenha.Location = new System.Drawing.Point(103, 229);
            this.text_textSenha.Name = "text_textSenha";
            this.text_textSenha.Size = new System.Drawing.Size(205, 22);
            this.text_textSenha.TabIndex = 1;
            this.text_textSenha.TextChanged += new System.EventHandler(this.text_textChanged);
            this.text_textSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_textSenha_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 455);
            this.Controls.Add(this.text_textSenha);
            this.Controls.Add(this.text_textEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_Enter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_textEmail;
        private System.Windows.Forms.TextBox text_textSenha;
    }
}

