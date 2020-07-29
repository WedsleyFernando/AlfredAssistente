namespace Alfred
{
    partial class adicionarComando
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
            this.NomeDoComando = new System.Windows.Forms.Label();
            this.txtNomeDoComando = new System.Windows.Forms.TextBox();
            this.lblComando = new System.Windows.Forms.Label();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomeDoComando
            // 
            this.NomeDoComando.AutoSize = true;
            this.NomeDoComando.Location = new System.Drawing.Point(26, 55);
            this.NomeDoComando.Name = "NomeDoComando";
            this.NomeDoComando.Size = new System.Drawing.Size(106, 13);
            this.NomeDoComando.TabIndex = 0;
            this.NomeDoComando.Text = "Nome Do Comando: ";
            // 
            // txtNomeDoComando
            // 
            this.txtNomeDoComando.Location = new System.Drawing.Point(135, 52);
            this.txtNomeDoComando.Name = "txtNomeDoComando";
            this.txtNomeDoComando.Size = new System.Drawing.Size(181, 20);
            this.txtNomeDoComando.TabIndex = 1;
            // 
            // lblComando
            // 
            this.lblComando.AutoSize = true;
            this.lblComando.Location = new System.Drawing.Point(74, 90);
            this.lblComando.Name = "lblComando";
            this.lblComando.Size = new System.Drawing.Size(55, 13);
            this.lblComando.TabIndex = 2;
            this.lblComando.Text = "Comando:";
            // 
            // txtComando
            // 
            this.txtComando.Location = new System.Drawing.Point(135, 87);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(181, 20);
            this.txtComando.TabIndex = 3;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(77, 124);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = "Resposta:";
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(135, 121);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(181, 20);
            this.txtResposta.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adicionar Comando";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // adicionarComando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 230);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtComando);
            this.Controls.Add(this.lblComando);
            this.Controls.Add(this.txtNomeDoComando);
            this.Controls.Add(this.NomeDoComando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adicionarComando";
            this.Text = "adicionarComando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeDoComando;
        private System.Windows.Forms.TextBox txtNomeDoComando;
        private System.Windows.Forms.Label lblComando;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}