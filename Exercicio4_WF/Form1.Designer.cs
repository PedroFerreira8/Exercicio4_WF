
namespace Exercicio4_WF
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(43, 67);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(43, 113);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(37, 13);
            this.lbl_idade.TabIndex = 1;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(43, 159);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_curso.TabIndex = 2;
            this.lbl_curso.Text = "Curso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(74, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Formulário IPCA ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(89, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submeter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(266, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

