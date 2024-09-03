using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03092024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtIncluir_Click(object sender, EventArgs e)
        {
            DgAlunos.Rows.Add(CTNome.Text , CTCurso.Text);
            CTNome.Clear();
            CTCurso.Clear();
            CtmTotal.Text = DgAlunos.RowCount.ToString();

            MessageBox.Show("Aluno Incluido com sucesso", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if(DgAlunos.RowCount > 0)
            {
                DgAlunos.Rows.RemoveAt(DgAlunos.CurrentRow.Index);
                CtmTotal.Text = DgAlunos.RowCount.ToString();

                MessageBox.Show("Aluno Excluido com sucesso", "Exclusão",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {   if(CtAlterar.Text != "")
            {
                DgAlunos.CurrentRow.Cells[0].Value = CtAlterar.Text;

                MessageBox.Show("Aluno Modificado com sucesso", "Modificação",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                CtAlterar.Clear();
            } 
        }

        private void DgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DgAlunos.RowCount > 0)
            {
                CtAlterar.Text = DgAlunos.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void BtExcluTodos_Click(object sender, EventArgs e)
        {
            DgAlunos.RowCount = 0;
            CtmTotal.Text = DgAlunos.RowCount.ToString();
        }

        private void BtFechaSistem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
