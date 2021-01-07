using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eniato
{
    public partial class Receitas_Adicionar : Form
    {
        private FormReceitas receitasLista;

        public Receitas_Adicionar(FormReceitas receitasListar)
        {
            InitializeComponent();
            comboBoxMetodoDePagamento.DataSource = Database.GetMetodosPagamento();
            comboBoxMetodoDePagamento.ValueMember = "codigo_tipo_pagamento";
            comboBoxMetodoDePagamento.DisplayMember = "descricao";
            comboBoxPlanoDeReceitas.DataSource = Database.GetPlanoDeContasReceitas();
            comboBoxPlanoDeReceitas.ValueMember = "codigo_receita";
            comboBoxPlanoDeReceitas.DisplayMember = "nome_receita";
            receitasLista = receitasListar;
        }

        private void comboBoxMetodoDePagamento_TextUpdate(object sender, EventArgs e)
        {
            if (this.comboBoxMetodoDePagamento.Text == "Cheque")
            {
                textBoxNumeroBanco.Visible = true;
                textBoxNumeroAgencia.Visible = true;
                textBoxNumeroCheque.Visible = true;
                dateTimePickerDatadoPara.Visible = true;
                textBoxNumeroConta.Visible = true;
                labelNumeroBanco.Visible = true;
                labelNumeroAgencia.Visible = true;
                labelNumeroCheque.Visible = true;
                labelDatadoPara.Visible = true;
                labelNumeroConta.Visible = true;
            }
            else
            {
                textBoxNumeroBanco.Visible = false;
                textBoxNumeroAgencia.Visible = false;
                textBoxNumeroCheque.Visible = false;
                dateTimePickerDatadoPara.Visible = false;
                textBoxNumeroConta.Visible = false;
                labelNumeroBanco.Visible = false;
                labelNumeroAgencia.Visible = false;
                labelNumeroCheque.Visible = false;
                labelDatadoPara.Visible = false;
                labelNumeroConta.Visible = false;
            }


        }

        // Função de mascara de moedas
        private void textBoxMascaraMoeda_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            Util.Moeda(ref txt);
        }

        // Fim Função de mascara de moedas

        // Faz com que só aceite números
        private void textBoxSoNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            Util.SoNumeros(ref txt, e);
        }
        // Fim faz com que só aceite números

        private void buttonLancarRecebimentoBalcao_Click(object sender, EventArgs e)
        {
            String descricao;
            decimal valorReceita;
            int idPagamento;
            int idPlanoDeRecebimento;
            bool result1 = int.TryParse(comboBoxMetodoDePagamento.SelectedValue.ToString(), out idPagamento);
            bool result2 = int.TryParse(comboBoxPlanoDeReceitas.SelectedValue.ToString(), out idPlanoDeRecebimento);


            if (textBoxDescricao.Text == "")
            {
                MessageBox.Show("Você não preencheu o campo descrição");
                textBoxDescricao.Focus();
            } else if (textBoxValorTotal.Text == "" || textBoxValorTotal.Text == "0,00")
            {
                MessageBox.Show("Você não preencheu o campo Valor ou deixou ele zerado");
                textBoxValorTotal.Focus();
            } else if (comboBoxMetodoDePagamento.Text == "")
            {
                MessageBox.Show("Você não escolheu o método de pagamento");
                comboBoxMetodoDePagamento.Focus();
            }
            else if (comboBoxMetodoDePagamento.Text == "Cheque")
            {
                if (textBoxNumeroBanco.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo Nº do Banco");
                    textBoxNumeroBanco.Focus();
                }
                else if (textBoxNumeroAgencia.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo Nº da Agência");
                    textBoxNumeroAgencia.Focus();
                }
                else if (textBoxNumeroCheque.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo Nº do Cheque");
                    textBoxNumeroCheque.Focus();
                }
                else if (textBoxNumeroConta.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo N° da Conta");
                    textBoxNumeroConta.Focus();
                }
                else
                {
                    int numeroBanco = Util.StringParaInt(textBoxNumeroBanco.Text);
                    int numeroAgencia = Util.StringParaInt(textBoxNumeroAgencia.Text);
                    int numeroCheque = Util.StringParaInt(textBoxNumeroCheque.Text);
                    int numeroConta = Util.StringParaInt(textBoxNumeroConta.Text);
                    descricao = textBoxDescricao.Text;
                    String bomPara = DateTime.Parse(dateTimePickerDatadoPara.Text).ToString("yyyy'-'MM'-'dd");
                    String valorTotal = textBoxValorTotal.Text.Replace(".", "");
                    valorReceita = decimal.Parse(valorTotal.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    Database.LancarRecebimento(descricao, idPagamento, valorReceita, idPlanoDeRecebimento);
                    Database.LancarCheque(numeroBanco, numeroAgencia, numeroCheque, numeroConta, bomPara, valorReceita);
                    Database.LigarChequeReceita(Database.GetCodigoUltimoCheque(), Database.GetCodigoUltimaReceita());
                    receitasLista.AtualizarDataset();
                    ContinuarAdicionando();
                }
            }
            else
            {
                descricao = textBoxDescricao.Text;
                String valorTotal = textBoxValorTotal.Text.Replace(".", "");

                valorReceita = decimal.Parse(valorTotal.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                Database.LancarRecebimento(descricao, idPagamento, valorReceita, idPlanoDeRecebimento);
                receitasLista.AtualizarDataset();
                ContinuarAdicionando();
            }
        }

        private void ContinuarAdicionando()
        {
            string message = "Você quer adicionar mais valores com a mesma descrição?";
            string caption = "Continuidade";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                textBoxDescricao.Clear();
                textBoxValorTotal.Clear();
                textBoxNumeroAgencia.Clear();
                textBoxNumeroBanco.Clear();
                textBoxNumeroCheque.Clear();
                textBoxNumeroConta.Clear();
                textBoxDescricao.Focus();
            }
        }
    }

}
