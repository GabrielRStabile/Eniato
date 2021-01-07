using System;
using System.Windows.Forms;

namespace Eniato
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            comboBoxPlanoDeReceitas.DataSource = Database.GetPlanoDeContasReceitas();
            comboBoxPlanoDeReceitas.ValueMember = "codigo_receita";
            comboBoxPlanoDeReceitas.DisplayMember = "nome_receita";
            AtualizarDataset();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int idCodigoPlanoDeReceitas;
            bool result = int.TryParse(comboBoxPlanoDeReceitas.SelectedValue.ToString(), out idCodigoPlanoDeReceitas);
            dataGridViewResultadoDaBusca.DataSource = Database.BuscarReceitas(dateTimePickerInicial.Value.Date, dateTimePickerFinal.Value.Date, textBoxDescricao.Text, idCodigoPlanoDeReceitas);
            dataGridViewResultadoDaBusca.Columns["valor"].DefaultCellStyle.Format = "C";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receitas_Adicionar formAdicionarReceita = new Receitas_Adicionar(this);
            formAdicionarReceita.ShowDialog();
        }

        public void AtualizarDataset()
        {
            dataGridViewResultadoDaBusca.DataSource = Database.BuscarTodasReceitas();
            dataGridViewResultadoDaBusca.Columns["valor"].DefaultCellStyle.Format = "C";
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewResultadoDaBusca.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Você deseja deletar o(s) registro(s) selecionado(s) ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow r in dataGridViewResultadoDaBusca.SelectedRows)
                    {
                        int idReceita = int.Parse(r.Cells[0].Value.ToString());
                        // Verifica se a receita foi feita com cheque, se for, deleta o cheque e a relação
                        if (r.Cells[3].Value.ToString() == "Cheque")
                        {
                            int idCheque = Database.GetChequeDaReceita(idReceita);
                            Database.DeletarCheque(idCheque);
                            Database.DeletarRelacaoChequeReceita(idReceita, idCheque);
                        }
                        Database.DeletarReceita(idReceita);
                    }
                    AtualizarDataset();
                }
            } else
            {
                MessageBox.Show("Você não selecionou nenhum registro. \nPara selecionar, você precisa clicar na primeira célula da tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if(dataGridViewResultadoDaBusca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Você não selecionou nenhum registro. \nPara selecionar, você precisa clicar na primeira célula da tabela.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dataGridViewResultadoDaBusca.SelectedRows.Count > 1)
            {
                MessageBox.Show("Você selecionou vários registros. \nPara modificar, só pode ser selecionado um.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                DataGridViewRow linha = dataGridViewResultadoDaBusca.SelectedRows[0];
                int id = int.Parse(linha.Cells[0].Value.ToString());
                Receitas_Modificar formularioDeModificacao = new Receitas_Modificar(id, this);
                formularioDeModificacao.ShowDialog();
            }
        }
    }
}
