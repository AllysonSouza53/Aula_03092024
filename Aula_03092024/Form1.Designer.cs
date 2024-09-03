namespace Aula_03092024
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CTNome = new System.Windows.Forms.TextBox();
            this.CTCurso = new System.Windows.Forms.TextBox();
            this.CtAlterar = new System.Windows.Forms.TextBox();
            this.CtmTotal = new System.Windows.Forms.Label();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtIncluir = new System.Windows.Forms.Button();
            this.BtAlterar = new System.Windows.Forms.Button();
            this.BtFechaSistem = new System.Windows.Forms.Button();
            this.BtExcluTodos = new System.Windows.Forms.Button();
            this.DgAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 533);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alterar Alunos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 586);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Alunos:";
            // 
            // CTNome
            // 
            this.CTNome.Location = new System.Drawing.Point(116, 57);
            this.CTNome.Margin = new System.Windows.Forms.Padding(4);
            this.CTNome.Name = "CTNome";
            this.CTNome.Size = new System.Drawing.Size(380, 23);
            this.CTNome.TabIndex = 4;
            // 
            // CTCurso
            // 
            this.CTCurso.Location = new System.Drawing.Point(116, 92);
            this.CTCurso.Margin = new System.Windows.Forms.Padding(4);
            this.CTCurso.Name = "CTCurso";
            this.CTCurso.Size = new System.Drawing.Size(380, 23);
            this.CTCurso.TabIndex = 5;
            // 
            // CtAlterar
            // 
            this.CtAlterar.Location = new System.Drawing.Point(132, 529);
            this.CtAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.CtAlterar.Name = "CtAlterar";
            this.CtAlterar.Size = new System.Drawing.Size(327, 23);
            this.CtAlterar.TabIndex = 6;
            // 
            // CtmTotal
            // 
            this.CtmTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CtmTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CtmTotal.Location = new System.Drawing.Point(126, 580);
            this.CtmTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CtmTotal.Name = "CtmTotal";
            this.CtmTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CtmTotal.Size = new System.Drawing.Size(28, 34);
            this.CtmTotal.TabIndex = 7;
            this.CtmTotal.Text = "0";
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(334, 146);
            this.BtRemover.Margin = new System.Windows.Forms.Padding(4);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(125, 52);
            this.BtRemover.TabIndex = 8;
            this.BtRemover.Text = "Remover";
            this.BtRemover.UseVisualStyleBackColor = true;
            this.BtRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // BtIncluir
            // 
            this.BtIncluir.Location = new System.Drawing.Point(167, 146);
            this.BtIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.BtIncluir.Name = "BtIncluir";
            this.BtIncluir.Size = new System.Drawing.Size(119, 52);
            this.BtIncluir.TabIndex = 9;
            this.BtIncluir.Text = "Incluir";
            this.BtIncluir.UseVisualStyleBackColor = true;
            this.BtIncluir.Click += new System.EventHandler(this.BtIncluir_Click);
            // 
            // BtAlterar
            // 
            this.BtAlterar.Location = new System.Drawing.Point(468, 527);
            this.BtAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.BtAlterar.Name = "BtAlterar";
            this.BtAlterar.Size = new System.Drawing.Size(123, 28);
            this.BtAlterar.TabIndex = 10;
            this.BtAlterar.Text = "Alterar";
            this.BtAlterar.UseVisualStyleBackColor = true;
            this.BtAlterar.Click += new System.EventHandler(this.BtAlterar_Click);
            // 
            // BtFechaSistem
            // 
            this.BtFechaSistem.Location = new System.Drawing.Point(467, 573);
            this.BtFechaSistem.Margin = new System.Windows.Forms.Padding(4);
            this.BtFechaSistem.Name = "BtFechaSistem";
            this.BtFechaSistem.Size = new System.Drawing.Size(123, 43);
            this.BtFechaSistem.TabIndex = 11;
            this.BtFechaSistem.Text = "Fechar Sistema";
            this.BtFechaSistem.UseVisualStyleBackColor = true;
            this.BtFechaSistem.Click += new System.EventHandler(this.BtFechaSistem_Click);
            // 
            // BtExcluTodos
            // 
            this.BtExcluTodos.Location = new System.Drawing.Point(339, 573);
            this.BtExcluTodos.Margin = new System.Windows.Forms.Padding(4);
            this.BtExcluTodos.Name = "BtExcluTodos";
            this.BtExcluTodos.Size = new System.Drawing.Size(120, 43);
            this.BtExcluTodos.TabIndex = 12;
            this.BtExcluTodos.Text = "Excluir Todos";
            this.BtExcluTodos.UseVisualStyleBackColor = true;
            this.BtExcluTodos.Click += new System.EventHandler(this.BtExcluTodos_Click);
            // 
            // DgAlunos
            // 
            this.DgAlunos.AllowUserToAddRows = false;
            this.DgAlunos.AllowUserToDeleteRows = false;
            this.DgAlunos.AllowUserToOrderColumns = true;
            this.DgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Curso});
            this.DgAlunos.Location = new System.Drawing.Point(29, 220);
            this.DgAlunos.Name = "DgAlunos";
            this.DgAlunos.ReadOnly = true;
            this.DgAlunos.Size = new System.Drawing.Size(563, 279);
            this.DgAlunos.TabIndex = 13;
            this.DgAlunos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgAlunos_CellClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 674);
            this.Controls.Add(this.DgAlunos);
            this.Controls.Add(this.BtExcluTodos);
            this.Controls.Add(this.BtFechaSistem);
            this.Controls.Add(this.BtAlterar);
            this.Controls.Add(this.BtIncluir);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.CtmTotal);
            this.Controls.Add(this.CtAlterar);
            this.Controls.Add(this.CTCurso);
            this.Controls.Add(this.CTNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CTNome;
        private System.Windows.Forms.TextBox CTCurso;
        private System.Windows.Forms.TextBox CtAlterar;
        private System.Windows.Forms.Label CtmTotal;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtIncluir;
        private System.Windows.Forms.Button BtAlterar;
        private System.Windows.Forms.Button BtFechaSistem;
        private System.Windows.Forms.Button BtExcluTodos;
        private System.Windows.Forms.DataGridView DgAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
    }
}

