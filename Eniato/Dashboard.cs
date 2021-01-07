using Eniato.view.despesas;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Eniato
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.textBoxValorRecebido.TextChanged += (s, e) => TextBoxValorRecebido_KeyPress();
            this.textBoxDesconto.TextChanged += (s, e) => TextBoxDesconto_KeyPress();
            comboBoxMetodoDePagamento.DataSource = Database.GetMetodosPagamento();
            comboBoxMetodoDePagamento.ValueMember = "codigo_tipo_pagamento";
            comboBoxMetodoDePagamento.DisplayMember = "descricao";
        }


        // Background Gradiente
        private void painelHeader_paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linearGradientBrush =
            new LinearGradientBrush(panelHeader.ClientRectangle, Color.FromArgb(57, 106, 252), Color.FromArgb(41, 72, 255), 45);

            ColorBlend cblend = new ColorBlend(3);
            cblend.Colors = new Color[2] { Color.FromArgb(57, 106, 252), Color.FromArgb(41, 72, 255) };
            cblend.Positions = new float[2] { 0f, 1f };

            linearGradientBrush.InterpolationColors = cblend;

            e.Graphics.FillRectangle(linearGradientBrush, panelHeader.ClientRectangle);
        }
        // Fim Background Gradiente

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

        private void comboBoxMetodoDePagamento_TextUpdate(object sender, EventArgs e)
        {
            if (this.comboBoxMetodoDePagamento.Text == "Cheque")
            {
                textBoxNumeroBanco.Visible = true;
                textBoxNumeroAgencia.Visible = true;
                textBoxNumeroCheque.Visible = true;
                maskedTextBoxDatadoPara.Visible = true;
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
                maskedTextBoxDatadoPara.Visible = false;
                textBoxNumeroConta.Visible = false;
                labelNumeroBanco.Visible = false;
                labelNumeroAgencia.Visible = false;
                labelNumeroCheque.Visible = false;
                labelDatadoPara.Visible = false;
                labelNumeroConta.Visible = false;
            }


        }

        private void buttonLancarRecebimentoBalcao_Click(object sender, EventArgs e)
        {
            // Primeiro passo: Checar se tem ou não número do ticket no atendimento
            String descricao;
            decimal valorReceita;
            int idPagamento;
            bool result = int.TryParse(comboBoxMetodoDePagamento.SelectedValue.ToString(), out idPagamento);

            if (textBoxNumeroTicket.Text != "")
            {
                descricao = "Ticket n°: " + textBoxNumeroTicket.Text;
            }
            else
            {
                descricao = "Atendimento sem geração de ticket";
            }

            // Segundo passo: Checar se todos os campos foram preenchidos
            if (textBoxValorTotal.Text == "" || textBoxValorTotal.Text == "0,00")
            {
                MessageBox.Show("Você não preencheu o campo Valor Total ou deixou ele zerado");
                textBoxValorTotal.Focus();
            }
            else if (textBoxValorRecebido.Text == "" || textBoxValorRecebido.Text == "0,00")
            {
                MessageBox.Show("Você não preencheu o campo Valor recebido, se houve 100% de desconto deixe este campo e o campo de desconto igual ao valor total.");
                textBoxValorRecebido.Focus();
            }
            else if (comboBoxMetodoDePagamento.Text == "")
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
                else if (maskedTextBoxDatadoPara.MaskCompleted == false)
                {
                    MessageBox.Show("Você não preencheu o campo Datado para");
                    maskedTextBoxDatadoPara.Focus();
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
                    String bomPara = DateTime.Parse(maskedTextBoxDatadoPara.Text).ToString("yyyy'-'MM'-'dd");
                    String valorRecebido = textBoxValorRecebido.Text.Replace(".", "");
                    String valorTotal = textBoxValorTotal.Text.Replace(".", "");
                    Decimal valorCheque = decimal.Parse(valorRecebido.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                    valorReceita = decimal.Parse(valorTotal.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) - decimal.Parse(textBoxDesconto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    Database.LancarRecebimento(descricao, idPagamento, valorReceita, 1);
                    Database.LancarCheque(numeroBanco, numeroAgencia, numeroCheque, numeroConta, bomPara, valorCheque);
                    Database.LigarChequeReceita(Database.GetCodigoUltimoCheque(), Database.GetCodigoUltimaReceita());
                    LimparCampos();
                }
            }
            else
            {
                String valorTotal = textBoxValorTotal.Text.Replace(".", "");
                valorReceita = decimal.Parse(valorTotal.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture) - decimal.Parse(textBoxDesconto.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                Database.LancarRecebimento(descricao, idPagamento, valorReceita, 1);
                LimparCampos();
                textBoxNumeroTicket.Focus();
            }
        }

        private void LimparCampos()
        {
            textBoxNumeroTicket.Clear();
            textBoxValorTotal.Clear();
            textBoxValorRecebido.Clear();
            textBoxDesconto.Clear();
            comboBoxMetodoDePagamento.SelectedItem = null;
            textBoxNumeroBanco.Clear();
            textBoxNumeroAgencia.Clear();
            textBoxNumeroCheque.Clear();
            textBoxNumeroConta.Clear();
            maskedTextBoxDatadoPara.Clear();
        }

        private void TextBoxValorRecebido_KeyPress()
        {
            if (textBoxValorRecebido.Text != "")
            {
                labelTroco.Visible = true;
                labelTroco.Text = "Atenção: Você precisa retornar " + Util.CalcularTroco(textBoxValorTotal.Text, textBoxValorRecebido.Text, textBoxDesconto.Text)
                + " ao cliente.";
            }
        }
        private void TextBoxDesconto_KeyPress()
        {
            labelTroco.Text = "Atenção: Você precisa retornar " + Util.CalcularTroco(textBoxValorTotal.Text, textBoxValorRecebido.Text, textBoxDesconto.Text)
            + " ao cliente.";
        }

        private void buttonLancarRecebimento_Click(object sender, EventArgs e)
        {
            FormReceitas formReceitas = new FormReceitas();
            formReceitas.ShowDialog();
            
        }

        private void buttonLancarDespesa_Click(object sender, EventArgs e)
        {
            FormDespesas formDespesas = new FormDespesas();
            formDespesas.ShowDialog();
        }
    }
}
