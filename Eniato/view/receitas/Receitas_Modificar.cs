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
    public partial class Receitas_Modificar : Form
    {
        private bool cheque;
        private int idCheque;
        private int idDaReceita;
        private FormReceitas receitasLista;


        public Receitas_Modificar(int idReceita, FormReceitas receitasListar)
        {
            InitializeComponent();
            idDaReceita = idReceita;
            receitasLista = receitasListar;
            DataRow dados = Database.GetReceita(idReceita).Rows[0];
            comboBoxMetodoDePagamento.DataSource = Database.GetMetodosPagamento();
            comboBoxMetodoDePagamento.ValueMember = "codigo_tipo_pagamento";
            comboBoxMetodoDePagamento.DisplayMember = "descricao";
            comboBoxPlanoDeReceitas.DataSource = Database.GetPlanoDeContasReceitas();
            comboBoxPlanoDeReceitas.ValueMember = "codigo_receita";
            comboBoxPlanoDeReceitas.DisplayMember = "nome_receita";
            labelTitulo.Text = "Modificando receita n° " + idReceita;
            textBoxDescricao.Text = dados["descrição"].ToString();
            comboBoxMetodoDePagamento.SelectedIndex = comboBoxMetodoDePagamento.FindStringExact(dados["metodo_de_pagamento"].ToString());
            Decimal valor = Decimal.Parse(dados["valor"].ToString());
            comboBoxPlanoDeReceitas.SelectedIndex = comboBoxPlanoDeReceitas.FindStringExact(dados["categoria"].ToString());
            textBoxValorTotal.Text = valor.ToString("F2");

            if (this.comboBoxMetodoDePagamento.Text == "Cheque")
            {
                popularCamposCheques(idReceita);
                labelNumeroBanco.Visible = true;
                labelNumeroAgencia.Visible = true;
                labelNumeroConta.Visible = true;
                labelNumeroCheque.Visible = true;
                labelDatadoPara.Visible = true;
                textBoxNumeroBanco.Visible = true;
                textBoxNumeroAgencia.Visible = true;
                textBoxNumeroConta.Visible = true;
                textBoxNumeroCheque.Visible = true;
                dateTimePickerDatadoPara.Visible = true;
                cheque = true;
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

        // Função que pega as informações do cheque e popula os campos

        private void popularCamposCheques(int idReceita)
        {
            idCheque = Database.GetChequeDaReceita(idReceita);
            DataRow dados = Database.GetCheque(idCheque).Rows[0];
            textBoxNumeroBanco.Text = dados["codigo_banco"].ToString();
            textBoxNumeroAgencia.Text = dados["codigo_agencia"].ToString();
            textBoxNumeroCheque.Text = dados["numero_cheque"].ToString();
            textBoxNumeroConta.Text = dados["numero_conta"].ToString();
            dateTimePickerDatadoPara.Value = Util.StringParaData(dados["bom_para"].ToString());
        }

        private void buttonModificarReceita_Click(object sender, EventArgs e)
        {
            String descricao = textBoxDescricao.Text;
            int metodoPagamento = Util.StringParaInt(comboBoxMetodoDePagamento.SelectedValue.ToString());
            Decimal valor = decimal.Parse(textBoxValorTotal.Text);
            int categoria = Util.StringParaInt(comboBoxPlanoDeReceitas.SelectedValue.ToString());
            int codigoBanco = -1;
            int codigoAgencia = -1;
            int numeroCheque = -1;
            int numeroConta = -1;
            String bomPara = "";
            if (comboBoxMetodoDePagamento.Text == "Cheque")
            {
                codigoBanco = int.Parse(textBoxNumeroBanco.Text);
                codigoAgencia = int.Parse(textBoxNumeroAgencia.Text);
                numeroCheque = int.Parse(textBoxNumeroCheque.Text);
                numeroConta = int.Parse(textBoxNumeroConta.Text);
                bomPara = DateTime.Parse(dateTimePickerDatadoPara.Text).ToString("yyyy'-'MM'-'dd");
            }
            if (cheque == true && comboBoxMetodoDePagamento.Text != "Cheque")
            {
                DialogResult result;
                result = MessageBox.Show("Você está modificando o método de pagamento de Cheque\npara " + comboBoxMetodoDePagamento.Text + ", ao fazer isso, o cheque anteriormente criado " +
                    "será deletado do sistema, você deseja continuar?", "Atenção", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Database.DeletarCheque(idCheque);
                    Database.DeletarRelacaoChequeReceita(idDaReceita, idCheque);
                    Database.ModificarReceita(idDaReceita, descricao, metodoPagamento, valor, categoria);
                    receitasLista.AtualizarDataset();

                }
            } else if (cheque == true && comboBoxMetodoDePagamento.Text == "Cheque")
            {
                Database.ModificarReceita(idDaReceita, descricao, metodoPagamento, valor, categoria);
                Database.ModificarCheque(idCheque, codigoBanco, codigoAgencia, numeroCheque, numeroConta, bomPara, valor);
            } else if (cheque == false && comboBoxMetodoDePagamento.Text == "Cheque")
            {
                Database.ModificarReceita(idDaReceita, descricao, metodoPagamento, valor, categoria);
                Database.LancarCheque(codigoBanco, codigoAgencia, numeroCheque, numeroConta, bomPara, valor);
                Database.LigarChequeReceita(Database.GetCodigoUltimoCheque(), idDaReceita);
            }
            else if (cheque == false && comboBoxMetodoDePagamento.Text != "Cheque")
            {
                Database.ModificarReceita(idDaReceita, descricao, metodoPagamento, valor, categoria);
            }
            receitasLista.AtualizarDataset();
            this.Close();
        }

        private void comboBoxMetodoDePagamento_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBoxMetodoDePagamento.Text != "Cheque")
            {
                labelNumeroBanco.Visible = false;
                labelNumeroAgencia.Visible = false;
                labelNumeroConta.Visible = false;
                labelNumeroCheque.Visible = false;
                labelDatadoPara.Visible = false;
                textBoxNumeroBanco.Visible = false;
                textBoxNumeroAgencia.Visible = false;
                textBoxNumeroConta.Visible = false;
                textBoxNumeroCheque.Visible = false;
                dateTimePickerDatadoPara.Visible = false;
            } else
            {
                labelNumeroBanco.Visible = true;
                labelNumeroAgencia.Visible = true;
                labelNumeroConta.Visible = true;
                labelNumeroCheque.Visible = true;
                labelDatadoPara.Visible = true;
                textBoxNumeroBanco.Visible = true;
                textBoxNumeroAgencia.Visible = true;
                textBoxNumeroConta.Visible = true;
                textBoxNumeroCheque.Visible = true;
                dateTimePickerDatadoPara.Visible = true;
            }

        }
    }
}
