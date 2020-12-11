
namespace Exercicio4_WF
{
    partial class Form2
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(90, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(90, 91);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(34, 13);
            this.lbl_idade.TabIndex = 1;
            this.lbl_idade.Text = "Idade";
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(90, 149);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(34, 13);
            this.lbl_curso.TabIndex = 2;
            this.lbl_curso.Text = "Curso";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 197);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_curso;
    }
}