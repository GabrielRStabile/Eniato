using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eniato
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

            if (this.comboBoxMetodoDePagamento.SelectedItem.ToString() == "Cheque") {
                textBoxNumeroBanco.Visible = true;
                textBoxNumeroAgencia.Visible = true;
                textBoxNumeroCheque.Visible = true;
                maskedTextBoxDatadoPara.Visible = true;
                labelNumeroBanco.Visible = true;
                labelNumeroAgencia.Visible = true;
                labelNumeroCheque.Visible = true;
                labelDatadoPara.Visible = true;
            } else
            {
                textBoxNumeroBanco.Visible = false;
                textBoxNumeroAgencia.Visible = false;
                textBoxNumeroCheque.Visible = false;
                maskedTextBoxDatadoPara.Visible = false;
                labelNumeroBanco.Visible = false;
                labelNumeroAgencia.Visible = false;
                labelNumeroCheque.Visible = false;
                labelDatadoPara.Visible = false;
            }

            
        }

        private void buttonLancarRecebimentoBalcao_Click(object sender, EventArgs e)
        {
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
                } else if (textBoxNumeroAgencia.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo Nº da Agência");
                    textBoxNumeroAgencia.Focus();
                } else if (textBoxNumeroCheque.Text == "")
                {
                    MessageBox.Show("Você não preencheu o campo Nº do Cheque");
                    textBoxNumeroCheque.Focus();
                } else if (maskedTextBoxDatadoPara.MaskCompleted == false)
                {
                    MessageBox.Show("Você não preencheu o campo Datado para");
                    maskedTextBoxDatadoPara.Focus();
                } else
                {
                    MessageBox.Show("Passou no cheque");
                }
            }
            else
            {
                MessageBox.Show("Passou");
            }
        }
    }
}
