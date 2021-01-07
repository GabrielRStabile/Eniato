
namespace Eniato
{
    partial class Receitas_Adicionar
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.comboBoxPlanoDeReceitas = new System.Windows.Forms.ComboBox();
            this.labelPlanoDeReceitas = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.comboBoxMetodoDePagamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.textBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.labelNumeroConta = new System.Windows.Forms.Label();
            this.labelDatadoPara = new System.Windows.Forms.Label();
            this.textBoxNumeroCheque = new System.Windows.Forms.TextBox();
            this.textBoxNumeroAgencia = new System.Windows.Forms.TextBox();
            this.textBoxNumeroBanco = new System.Windows.Forms.TextBox();
            this.labelNumeroCheque = new System.Windows.Forms.Label();
            this.labelNumeroAgencia = new System.Windows.Forms.Label();
            this.labelNumeroBanco = new System.Windows.Forms.Label();
            this.buttonLancarReceita = new System.Windows.Forms.Button();
            this.dateTimePickerDatadoPara = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(164, 30);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Adicionar receita";
            // 
            // comboBoxPlanoDeReceitas
            // 
            this.comboBoxPlanoDeReceitas.FormattingEnabled = true;
            this.comboBoxPlanoDeReceitas.Location = new System.Drawing.Point(145, 72);
            this.comboBoxPlanoDeReceitas.Name = "comboBoxPlanoDeReceitas";
            this.comboBoxPlanoDeReceitas.Size = new System.Drawing.Size(268, 24);
            this.comboBoxPlanoDeReceitas.TabIndex = 17;
            // 
            // labelPlanoDeReceitas
            // 
            this.labelPlanoDeReceitas.AutoSize = true;
            this.labelPlanoDeReceitas.Location = new System.Drawing.Point(14, 75);
            this.labelPlanoDeReceitas.Name = "labelPlanoDeReceitas";
            this.labelPlanoDeReceitas.Size = new System.Drawing.Size(122, 17);
            this.labelPlanoDeReceitas.TabIndex = 16;
            this.labelPlanoDeReceitas.Text = "Plano de receitas:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(95, 43);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(693, 22);
            this.textBoxDescricao.TabIndex = 15;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(14, 43);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(75, 17);
            this.labelDescricao.TabIndex = 14;
            this.labelDescricao.Text = "Descrição:";
            // 
            // comboBoxMetodoDePagamento
            // 
            this.comboBoxMetodoDePagamento.FormattingEnabled = true;
            this.comboBoxMetodoDePagamento.Location = new System.Drawing.Point(579, 72);
            this.comboBoxMetodoDePagamento.Name = "comboBoxMetodoDePagamento";
            this.comboBoxMetodoDePagamento.Size = new System.Drawing.Size(209, 24);
            this.comboBoxMetodoDePagamento.TabIndex = 20;
            this.comboBoxMetodoDePagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodoDePagamento_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Método de pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor:";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(65, 103);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(111, 22);
            this.textBoxValorTotal.TabIndex = 22;
            this.textBoxValorTotal.Text = "0,00";
            this.textBoxValorTotal.TextChanged += new System.EventHandler(this.textBoxMascaraMoeda_TextChanged);
            this.textBoxValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.Location = new System.Drawing.Point(668, 103);
            this.textBoxNumeroConta.Name = "textBoxNumeroConta";
            this.textBoxNumeroConta.Size = new System.Drawing.Size(120, 22);
            this.textBoxNumeroConta.TabIndex = 31;
            this.textBoxNumeroConta.Visible = false;
            this.textBoxNumeroConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelNumeroConta
            // 
            this.labelNumeroConta.AutoSize = true;
            this.labelNumeroConta.Location = new System.Drawing.Point(577, 107);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(89, 17);
            this.labelNumeroConta.TabIndex = 32;
            this.labelNumeroConta.Text = "N° da Conta:";
            this.labelNumeroConta.Visible = false;
            // 
            // labelDatadoPara
            // 
            this.labelDatadoPara.AutoSize = true;
            this.labelDatadoPara.Location = new System.Drawing.Point(258, 138);
            this.labelDatadoPara.Name = "labelDatadoPara";
            this.labelDatadoPara.Size = new System.Drawing.Size(91, 17);
            this.labelDatadoPara.TabIndex = 30;
            this.labelDatadoPara.Text = "Datado para:";
            this.labelDatadoPara.Visible = false;
            // 
            // textBoxNumeroCheque
            // 
            this.textBoxNumeroCheque.Location = new System.Drawing.Point(124, 135);
            this.textBoxNumeroCheque.Name = "textBoxNumeroCheque";
            this.textBoxNumeroCheque.Size = new System.Drawing.Size(117, 22);
            this.textBoxNumeroCheque.TabIndex = 25;
            this.textBoxNumeroCheque.Visible = false;
            this.textBoxNumeroCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // textBoxNumeroAgencia
            // 
            this.textBoxNumeroAgencia.Location = new System.Drawing.Point(487, 103);
            this.textBoxNumeroAgencia.Name = "textBoxNumeroAgencia";
            this.textBoxNumeroAgencia.Size = new System.Drawing.Size(72, 22);
            this.textBoxNumeroAgencia.TabIndex = 24;
            this.textBoxNumeroAgencia.Visible = false;
            this.textBoxNumeroAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // textBoxNumeroBanco
            // 
            this.textBoxNumeroBanco.Location = new System.Drawing.Point(288, 103);
            this.textBoxNumeroBanco.Name = "textBoxNumeroBanco";
            this.textBoxNumeroBanco.Size = new System.Drawing.Size(73, 22);
            this.textBoxNumeroBanco.TabIndex = 23;
            this.textBoxNumeroBanco.Visible = false;
            this.textBoxNumeroBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelNumeroCheque
            // 
            this.labelNumeroCheque.AutoSize = true;
            this.labelNumeroCheque.Location = new System.Drawing.Point(14, 138);
            this.labelNumeroCheque.Name = "labelNumeroCheque";
            this.labelNumeroCheque.Size = new System.Drawing.Size(101, 17);
            this.labelNumeroCheque.TabIndex = 29;
            this.labelNumeroCheque.Text = "N° do Cheque:";
            this.labelNumeroCheque.Visible = false;
            // 
            // labelNumeroAgencia
            // 
            this.labelNumeroAgencia.AutoSize = true;
            this.labelNumeroAgencia.Location = new System.Drawing.Point(378, 107);
            this.labelNumeroAgencia.Name = "labelNumeroAgencia";
            this.labelNumeroAgencia.Size = new System.Drawing.Size(103, 17);
            this.labelNumeroAgencia.TabIndex = 28;
            this.labelNumeroAgencia.Text = "N° da Agência:";
            this.labelNumeroAgencia.Visible = false;
            // 
            // labelNumeroBanco
            // 
            this.labelNumeroBanco.AutoSize = true;
            this.labelNumeroBanco.Location = new System.Drawing.Point(190, 107);
            this.labelNumeroBanco.Name = "labelNumeroBanco";
            this.labelNumeroBanco.Size = new System.Drawing.Size(92, 17);
            this.labelNumeroBanco.TabIndex = 27;
            this.labelNumeroBanco.Text = "N° do Banco:";
            this.labelNumeroBanco.Visible = false;
            // 
            // buttonLancarReceita
            // 
            this.buttonLancarReceita.Location = new System.Drawing.Point(668, 135);
            this.buttonLancarReceita.Name = "buttonLancarReceita";
            this.buttonLancarReceita.Size = new System.Drawing.Size(120, 26);
            this.buttonLancarReceita.TabIndex = 33;
            this.buttonLancarReceita.Text = "Lançar receita";
            this.buttonLancarReceita.UseVisualStyleBackColor = true;
            this.buttonLancarReceita.Click += new System.EventHandler(this.buttonLancarRecebimentoBalcao_Click);
            // 
            // dateTimePickerDatadoPara
            // 
            this.dateTimePickerDatadoPara.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDatadoPara.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatadoPara.Location = new System.Drawing.Point(355, 135);
            this.dateTimePickerDatadoPara.Name = "dateTimePickerDatadoPara";
            this.dateTimePickerDatadoPara.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerDatadoPara.TabIndex = 34;
            // 
            // Receitas_Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 169);
            this.Controls.Add(this.dateTimePickerDatadoPara);
            this.Controls.Add(this.buttonLancarReceita);
            this.Controls.Add(this.textBoxNumeroConta);
            this.Controls.Add(this.labelNumeroConta);
            this.Controls.Add(this.labelDatadoPara);
            this.Controls.Add(this.textBoxNumeroCheque);
            this.Controls.Add(this.textBoxNumeroAgencia);
            this.Controls.Add(this.textBoxNumeroBanco);
            this.Controls.Add(this.labelNumeroCheque);
            this.Controls.Add(this.labelNumeroAgencia);
            this.Controls.Add(this.labelNumeroBanco);
            this.Controls.Add(this.textBoxValorTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxMetodoDePagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPlanoDeReceitas);
            this.Controls.Add(this.labelPlanoDeReceitas);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Receitas_Adicionar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas // Adicionar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ComboBox comboBoxPlanoDeReceitas;
        private System.Windows.Forms.Label labelPlanoDeReceitas;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.ComboBox comboBoxMetodoDePagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxNumeroConta;
        private System.Windows.Forms.Label labelNumeroConta;
        private System.Windows.Forms.Label labelDatadoPara;
        private System.Windows.Forms.TextBox textBoxNumeroCheque;
        private System.Windows.Forms.TextBox textBoxNumeroAgencia;
        private System.Windows.Forms.TextBox textBoxNumeroBanco;
        private System.Windows.Forms.Label labelNumeroCheque;
        private System.Windows.Forms.Label labelNumeroAgencia;
        private System.Windows.Forms.Label labelNumeroBanco;
        private System.Windows.Forms.Button buttonLancarReceita;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatadoPara;
    }
}