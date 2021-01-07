
namespace Eniato
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.statusStripInformacoes = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLicensa = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelLateral = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLancarDespesa = new System.Windows.Forms.Button();
            this.buttonLancarRecebimento = new System.Windows.Forms.Button();
            this.buttonChequesRecebidos = new System.Windows.Forms.Button();
            this.buttonChequesEmitidos = new System.Windows.Forms.Button();
            this.buttonConfiguracao = new System.Windows.Forms.Button();
            this.tableLayoutPanelCentral = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewContasAPagar = new System.Windows.Forms.DataGridView();
            this.panelLancamentoBalcao = new System.Windows.Forms.Panel();
            this.textBoxNumeroConta = new System.Windows.Forms.TextBox();
            this.labelNumeroConta = new System.Windows.Forms.Label();
            this.buttonLancarRecebimentoBalcao = new System.Windows.Forms.Button();
            this.maskedTextBoxDatadoPara = new System.Windows.Forms.MaskedTextBox();
            this.labelDatadoPara = new System.Windows.Forms.Label();
            this.textBoxNumeroCheque = new System.Windows.Forms.TextBox();
            this.textBoxNumeroAgencia = new System.Windows.Forms.TextBox();
            this.textBoxNumeroBanco = new System.Windows.Forms.TextBox();
            this.labelNumeroCheque = new System.Windows.Forms.Label();
            this.labelNumeroAgencia = new System.Windows.Forms.Label();
            this.labelNumeroBanco = new System.Windows.Forms.Label();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.comboBoxMetodoDePagamento = new System.Windows.Forms.ComboBox();
            this.labelMetodoDePagamento = new System.Windows.Forms.Label();
            this.labelNaoPossuaTicket = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.textBoxValorRecebido = new System.Windows.Forms.TextBox();
            this.labelValorRecebido = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.textBoxNumeroTicket = new System.Windows.Forms.TextBox();
            this.labelNumeroDoTicket = new System.Windows.Forms.Label();
            this.subtituloLancamentoBalcao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelTituloSistema = new System.Windows.Forms.Panel();
            this.labelTituloSistema = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStripInformacoes.SuspendLayout();
            this.tableLayoutPanelLateral.SuspendLayout();
            this.tableLayoutPanelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasAPagar)).BeginInit();
            this.panelLancamentoBalcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelTituloSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripInformacoes
            // 
            this.statusStripInformacoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripInformacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLicensa});
            this.statusStripInformacoes.Location = new System.Drawing.Point(0, 868);
            this.statusStripInformacoes.Name = "statusStripInformacoes";
            this.statusStripInformacoes.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripInformacoes.Size = new System.Drawing.Size(1732, 26);
            this.statusStripInformacoes.TabIndex = 0;
            this.statusStripInformacoes.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLicensa
            // 
            this.toolStripStatusLabelLicensa.Name = "toolStripStatusLabelLicensa";
            this.toolStripStatusLabelLicensa.Size = new System.Drawing.Size(371, 20);
            this.toolStripStatusLabelLicensa.Text = "Licenciado para Serviço Notarial e Registral de Altônia";
            // 
            // tableLayoutPanelLateral
            // 
            this.tableLayoutPanelLateral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelLateral.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelLateral.ColumnCount = 1;
            this.tableLayoutPanelLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLateral.Controls.Add(this.buttonLancarDespesa, 0, 1);
            this.tableLayoutPanelLateral.Controls.Add(this.buttonLancarRecebimento, 0, 0);
            this.tableLayoutPanelLateral.Controls.Add(this.buttonChequesRecebidos, 0, 2);
            this.tableLayoutPanelLateral.Controls.Add(this.buttonChequesEmitidos, 0, 3);
            this.tableLayoutPanelLateral.Controls.Add(this.buttonConfiguracao, 0, 4);
            this.tableLayoutPanelLateral.Location = new System.Drawing.Point(0, 89);
            this.tableLayoutPanelLateral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelLateral.Name = "tableLayoutPanelLateral";
            this.tableLayoutPanelLateral.RowCount = 6;
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelLateral.Size = new System.Drawing.Size(58, 780);
            this.tableLayoutPanelLateral.TabIndex = 1;
            // 
            // buttonLancarDespesa
            // 
            this.buttonLancarDespesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLancarDespesa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.buttonLancarDespesa.FlatAppearance.BorderSize = 2;
            this.buttonLancarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarDespesa.Image = global::Eniato.Properties.Resources.Asset_3pagar;
            this.buttonLancarDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLancarDespesa.Location = new System.Drawing.Point(3, 132);
            this.buttonLancarDespesa.Name = "buttonLancarDespesa";
            this.buttonLancarDespesa.Size = new System.Drawing.Size(52, 123);
            this.buttonLancarDespesa.TabIndex = 13;
            this.toolTip.SetToolTip(this.buttonLancarDespesa, "Clique aqui para lançar uma despesa");
            this.buttonLancarDespesa.UseVisualStyleBackColor = true;
            this.buttonLancarDespesa.Click += new System.EventHandler(this.buttonLancarDespesa_Click);
            // 
            // buttonLancarRecebimento
            // 
            this.buttonLancarRecebimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLancarRecebimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            this.buttonLancarRecebimento.FlatAppearance.BorderSize = 2;
            this.buttonLancarRecebimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLancarRecebimento.Image = global::Eniato.Properties.Resources.Asset_2receber;
            this.buttonLancarRecebimento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLancarRecebimento.Location = new System.Drawing.Point(3, 3);
            this.buttonLancarRecebimento.Name = "buttonLancarRecebimento";
            this.buttonLancarRecebimento.Size = new System.Drawing.Size(52, 123);
            this.buttonLancarRecebimento.TabIndex = 12;
            this.toolTip.SetToolTip(this.buttonLancarRecebimento, "Clique aqui para lançar um recebimento");
            this.buttonLancarRecebimento.UseVisualStyleBackColor = true;
            this.buttonLancarRecebimento.Click += new System.EventHandler(this.buttonLancarRecebimento_Click);
            // 
            // buttonChequesRecebidos
            // 
            this.buttonChequesRecebidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChequesRecebidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            this.buttonChequesRecebidos.FlatAppearance.BorderSize = 2;
            this.buttonChequesRecebidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChequesRecebidos.Image = global::Eniato.Properties.Resources.Asset_6cheque_recebido;
            this.buttonChequesRecebidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChequesRecebidos.Location = new System.Drawing.Point(3, 261);
            this.buttonChequesRecebidos.Name = "buttonChequesRecebidos";
            this.buttonChequesRecebidos.Size = new System.Drawing.Size(52, 123);
            this.buttonChequesRecebidos.TabIndex = 14;
            this.buttonChequesRecebidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonChequesRecebidos, "Clique aqui para consultar os cheques recebidos");
            this.buttonChequesRecebidos.UseVisualStyleBackColor = true;
            // 
            // buttonChequesEmitidos
            // 
            this.buttonChequesEmitidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChequesEmitidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.buttonChequesEmitidos.FlatAppearance.BorderSize = 2;
            this.buttonChequesEmitidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChequesEmitidos.Image = global::Eniato.Properties.Resources.Asset_7cheque_emitido;
            this.buttonChequesEmitidos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChequesEmitidos.Location = new System.Drawing.Point(3, 390);
            this.buttonChequesEmitidos.Name = "buttonChequesEmitidos";
            this.buttonChequesEmitidos.Size = new System.Drawing.Size(52, 123);
            this.buttonChequesEmitidos.TabIndex = 15;
            this.buttonChequesEmitidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonChequesEmitidos, "Clique aqui para consultar e lançar cheques emitidos");
            this.buttonChequesEmitidos.UseVisualStyleBackColor = true;
            // 
            // buttonConfiguracao
            // 
            this.buttonConfiguracao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfiguracao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonConfiguracao.FlatAppearance.BorderSize = 2;
            this.buttonConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracao.Image = global::Eniato.Properties.Resources.Asset_8configuracao;
            this.buttonConfiguracao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfiguracao.Location = new System.Drawing.Point(3, 519);
            this.buttonConfiguracao.Name = "buttonConfiguracao";
            this.buttonConfiguracao.Size = new System.Drawing.Size(52, 123);
            this.buttonConfiguracao.TabIndex = 16;
            this.buttonConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonConfiguracao, "Clique aqui para acessar as configurações");
            this.buttonConfiguracao.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCentral
            // 
            this.tableLayoutPanelCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCentral.ColumnCount = 2;
            this.tableLayoutPanelCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.0997F));
            this.tableLayoutPanelCentral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.9003F));
            this.tableLayoutPanelCentral.Controls.Add(this.dataGridViewContasAPagar, 0, 1);
            this.tableLayoutPanelCentral.Controls.Add(this.panelLancamentoBalcao, 0, 0);
            this.tableLayoutPanelCentral.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanelCentral.Location = new System.Drawing.Point(65, 89);
            this.tableLayoutPanelCentral.Name = "tableLayoutPanelCentral";
            this.tableLayoutPanelCentral.RowCount = 2;
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCentral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCentral.Size = new System.Drawing.Size(1655, 780);
            this.tableLayoutPanelCentral.TabIndex = 3;
            // 
            // dataGridViewContasAPagar
            // 
            this.dataGridViewContasAPagar.AllowUserToAddRows = false;
            this.dataGridViewContasAPagar.AllowUserToDeleteRows = false;
            this.dataGridViewContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContasAPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContasAPagar.Location = new System.Drawing.Point(3, 393);
            this.dataGridViewContasAPagar.Name = "dataGridViewContasAPagar";
            this.dataGridViewContasAPagar.ReadOnly = true;
            this.dataGridViewContasAPagar.RowHeadersWidth = 51;
            this.dataGridViewContasAPagar.RowTemplate.Height = 24;
            this.dataGridViewContasAPagar.Size = new System.Drawing.Size(608, 384);
            this.dataGridViewContasAPagar.TabIndex = 1;
            // 
            // panelLancamentoBalcao
            // 
            this.panelLancamentoBalcao.BackColor = System.Drawing.Color.White;
            this.panelLancamentoBalcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLancamentoBalcao.Controls.Add(this.textBoxNumeroConta);
            this.panelLancamentoBalcao.Controls.Add(this.labelNumeroConta);
            this.panelLancamentoBalcao.Controls.Add(this.buttonLancarRecebimentoBalcao);
            this.panelLancamentoBalcao.Controls.Add(this.maskedTextBoxDatadoPara);
            this.panelLancamentoBalcao.Controls.Add(this.labelDatadoPara);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxNumeroCheque);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxNumeroAgencia);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxNumeroBanco);
            this.panelLancamentoBalcao.Controls.Add(this.labelNumeroCheque);
            this.panelLancamentoBalcao.Controls.Add(this.labelNumeroAgencia);
            this.panelLancamentoBalcao.Controls.Add(this.labelNumeroBanco);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxValorTotal);
            this.panelLancamentoBalcao.Controls.Add(this.comboBoxMetodoDePagamento);
            this.panelLancamentoBalcao.Controls.Add(this.labelMetodoDePagamento);
            this.panelLancamentoBalcao.Controls.Add(this.labelNaoPossuaTicket);
            this.panelLancamentoBalcao.Controls.Add(this.labelTroco);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxDesconto);
            this.panelLancamentoBalcao.Controls.Add(this.labelDesconto);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxValorRecebido);
            this.panelLancamentoBalcao.Controls.Add(this.labelValorRecebido);
            this.panelLancamentoBalcao.Controls.Add(this.labelValorTotal);
            this.panelLancamentoBalcao.Controls.Add(this.textBoxNumeroTicket);
            this.panelLancamentoBalcao.Controls.Add(this.labelNumeroDoTicket);
            this.panelLancamentoBalcao.Controls.Add(this.subtituloLancamentoBalcao);
            this.panelLancamentoBalcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLancamentoBalcao.Location = new System.Drawing.Point(3, 3);
            this.panelLancamentoBalcao.Name = "panelLancamentoBalcao";
            this.panelLancamentoBalcao.Size = new System.Drawing.Size(608, 384);
            this.panelLancamentoBalcao.TabIndex = 2;
            // 
            // textBoxNumeroConta
            // 
            this.textBoxNumeroConta.Location = new System.Drawing.Point(212, 195);
            this.textBoxNumeroConta.Name = "textBoxNumeroConta";
            this.textBoxNumeroConta.Size = new System.Drawing.Size(117, 30);
            this.textBoxNumeroConta.TabIndex = 21;
            this.textBoxNumeroConta.Visible = false;
            this.textBoxNumeroConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelNumeroConta
            // 
            this.labelNumeroConta.AutoSize = true;
            this.labelNumeroConta.Location = new System.Drawing.Point(206, 170);
            this.labelNumeroConta.Name = "labelNumeroConta";
            this.labelNumeroConta.Size = new System.Drawing.Size(107, 26);
            this.labelNumeroConta.TabIndex = 22;
            this.labelNumeroConta.Text = "N° da Conta:";
            this.labelNumeroConta.Visible = false;
            // 
            // buttonLancarRecebimentoBalcao
            // 
            this.buttonLancarRecebimentoBalcao.Location = new System.Drawing.Point(8, 186);
            this.buttonLancarRecebimentoBalcao.Name = "buttonLancarRecebimentoBalcao";
            this.buttonLancarRecebimentoBalcao.Size = new System.Drawing.Size(183, 39);
            this.buttonLancarRecebimentoBalcao.TabIndex = 10;
            this.buttonLancarRecebimentoBalcao.Text = "Lançar";
            this.buttonLancarRecebimentoBalcao.UseVisualStyleBackColor = true;
            this.buttonLancarRecebimentoBalcao.Click += new System.EventHandler(this.buttonLancarRecebimentoBalcao_Click);
            // 
            // maskedTextBoxDatadoPara
            // 
            this.maskedTextBoxDatadoPara.Location = new System.Drawing.Point(337, 196);
            this.maskedTextBoxDatadoPara.Mask = "00/00/0000";
            this.maskedTextBoxDatadoPara.Name = "maskedTextBoxDatadoPara";
            this.maskedTextBoxDatadoPara.Size = new System.Drawing.Size(118, 30);
            this.maskedTextBoxDatadoPara.TabIndex = 9;
            this.maskedTextBoxDatadoPara.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDatadoPara.Visible = false;
            // 
            // labelDatadoPara
            // 
            this.labelDatadoPara.AutoSize = true;
            this.labelDatadoPara.Location = new System.Drawing.Point(332, 170);
            this.labelDatadoPara.Name = "labelDatadoPara";
            this.labelDatadoPara.Size = new System.Drawing.Size(111, 26);
            this.labelDatadoPara.TabIndex = 20;
            this.labelDatadoPara.Text = "Datado para:";
            this.labelDatadoPara.Visible = false;
            // 
            // textBoxNumeroCheque
            // 
            this.textBoxNumeroCheque.Location = new System.Drawing.Point(457, 134);
            this.textBoxNumeroCheque.Name = "textBoxNumeroCheque";
            this.textBoxNumeroCheque.Size = new System.Drawing.Size(117, 30);
            this.textBoxNumeroCheque.TabIndex = 8;
            this.textBoxNumeroCheque.Visible = false;
            this.textBoxNumeroCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // textBoxNumeroAgencia
            // 
            this.textBoxNumeroAgencia.Location = new System.Drawing.Point(328, 134);
            this.textBoxNumeroAgencia.Name = "textBoxNumeroAgencia";
            this.textBoxNumeroAgencia.Size = new System.Drawing.Size(117, 30);
            this.textBoxNumeroAgencia.TabIndex = 7;
            this.textBoxNumeroAgencia.Visible = false;
            this.textBoxNumeroAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // textBoxNumeroBanco
            // 
            this.textBoxNumeroBanco.Location = new System.Drawing.Point(211, 134);
            this.textBoxNumeroBanco.Name = "textBoxNumeroBanco";
            this.textBoxNumeroBanco.Size = new System.Drawing.Size(100, 30);
            this.textBoxNumeroBanco.TabIndex = 6;
            this.textBoxNumeroBanco.Visible = false;
            this.textBoxNumeroBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelNumeroCheque
            // 
            this.labelNumeroCheque.AutoSize = true;
            this.labelNumeroCheque.Location = new System.Drawing.Point(451, 109);
            this.labelNumeroCheque.Name = "labelNumeroCheque";
            this.labelNumeroCheque.Size = new System.Drawing.Size(120, 26);
            this.labelNumeroCheque.TabIndex = 16;
            this.labelNumeroCheque.Text = "N° do Cheque:";
            this.labelNumeroCheque.Visible = false;
            // 
            // labelNumeroAgencia
            // 
            this.labelNumeroAgencia.AutoSize = true;
            this.labelNumeroAgencia.Location = new System.Drawing.Point(323, 109);
            this.labelNumeroAgencia.Name = "labelNumeroAgencia";
            this.labelNumeroAgencia.Size = new System.Drawing.Size(122, 26);
            this.labelNumeroAgencia.TabIndex = 15;
            this.labelNumeroAgencia.Text = "N° da Agência:";
            this.labelNumeroAgencia.Visible = false;
            // 
            // labelNumeroBanco
            // 
            this.labelNumeroBanco.AutoSize = true;
            this.labelNumeroBanco.Location = new System.Drawing.Point(206, 109);
            this.labelNumeroBanco.Name = "labelNumeroBanco";
            this.labelNumeroBanco.Size = new System.Drawing.Size(108, 26);
            this.labelNumeroBanco.TabIndex = 14;
            this.labelNumeroBanco.Text = "N° do Banco:";
            this.labelNumeroBanco.Visible = false;
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Location = new System.Drawing.Point(144, 61);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.Size = new System.Drawing.Size(121, 30);
            this.textBoxValorTotal.TabIndex = 2;
            this.textBoxValorTotal.Text = "0,00";
            this.textBoxValorTotal.TextChanged += new System.EventHandler(this.textBoxMascaraMoeda_TextChanged);
            this.textBoxValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // comboBoxMetodoDePagamento
            // 
            this.comboBoxMetodoDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodoDePagamento.FormattingEnabled = true;
            this.comboBoxMetodoDePagamento.Location = new System.Drawing.Point(8, 134);
            this.comboBoxMetodoDePagamento.Name = "comboBoxMetodoDePagamento";
            this.comboBoxMetodoDePagamento.Size = new System.Drawing.Size(183, 34);
            this.comboBoxMetodoDePagamento.TabIndex = 5;
            this.comboBoxMetodoDePagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodoDePagamento_TextUpdate);
            // 
            // labelMetodoDePagamento
            // 
            this.labelMetodoDePagamento.AutoSize = true;
            this.labelMetodoDePagamento.Location = new System.Drawing.Point(3, 109);
            this.labelMetodoDePagamento.Name = "labelMetodoDePagamento";
            this.labelMetodoDePagamento.Size = new System.Drawing.Size(188, 26);
            this.labelMetodoDePagamento.TabIndex = 12;
            this.labelMetodoDePagamento.Text = "Método de pagamento:";
            // 
            // labelNaoPossuaTicket
            // 
            this.labelNaoPossuaTicket.AutoSize = true;
            this.labelNaoPossuaTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelNaoPossuaTicket.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaoPossuaTicket.ForeColor = System.Drawing.Color.Gray;
            this.labelNaoPossuaTicket.Location = new System.Drawing.Point(0, 360);
            this.labelNaoPossuaTicket.Name = "labelNaoPossuaTicket";
            this.labelNaoPossuaTicket.Size = new System.Drawing.Size(512, 22);
            this.labelNaoPossuaTicket.TabIndex = 11;
            this.labelNaoPossuaTicket.Text = "Caso o lançamento não possua ticket no Assina, desconsidere o campo N° do Ticket." +
    "";
            // 
            // labelTroco
            // 
            this.labelTroco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTroco.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTroco.ForeColor = System.Drawing.Color.Red;
            this.labelTroco.Location = new System.Drawing.Point(3, 301);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(575, 59);
            this.labelTroco.TabIndex = 10;
            this.labelTroco.Text = "Atenção: Você precisa retornar {dinheiro.retorno} ao cliente e ter certeza que en" +
    "trou {dinheiro.recebido} no caixa.";
            this.labelTroco.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelTroco.Visible = false;
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(457, 61);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(121, 30);
            this.textBoxDesconto.TabIndex = 4;
            this.textBoxDesconto.Text = "0,00";
            this.textBoxDesconto.TextChanged += new System.EventHandler(this.textBoxMascaraMoeda_TextChanged);
            this.textBoxDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(452, 38);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(87, 26);
            this.labelDesconto.TabIndex = 8;
            this.labelDesconto.Text = "Desconto:";
            // 
            // textBoxValorRecebido
            // 
            this.textBoxValorRecebido.Location = new System.Drawing.Point(302, 61);
            this.textBoxValorRecebido.Name = "textBoxValorRecebido";
            this.textBoxValorRecebido.Size = new System.Drawing.Size(121, 30);
            this.textBoxValorRecebido.TabIndex = 3;
            this.textBoxValorRecebido.Text = "0,00";
            this.textBoxValorRecebido.TextChanged += new System.EventHandler(this.textBoxMascaraMoeda_TextChanged);
            this.textBoxValorRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelValorRecebido
            // 
            this.labelValorRecebido.AutoSize = true;
            this.labelValorRecebido.Location = new System.Drawing.Point(297, 38);
            this.labelValorRecebido.Name = "labelValorRecebido";
            this.labelValorRecebido.Size = new System.Drawing.Size(126, 26);
            this.labelValorRecebido.TabIndex = 5;
            this.labelValorRecebido.Text = "Valor recebido:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(139, 38);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(93, 26);
            this.labelValorTotal.TabIndex = 3;
            this.labelValorTotal.Text = "Valor total:";
            // 
            // textBoxNumeroTicket
            // 
            this.textBoxNumeroTicket.Location = new System.Drawing.Point(8, 61);
            this.textBoxNumeroTicket.Name = "textBoxNumeroTicket";
            this.textBoxNumeroTicket.Size = new System.Drawing.Size(100, 30);
            this.textBoxNumeroTicket.TabIndex = 1;
            this.textBoxNumeroTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoNumero_KeyPress);
            // 
            // labelNumeroDoTicket
            // 
            this.labelNumeroDoTicket.AutoSize = true;
            this.labelNumeroDoTicket.Location = new System.Drawing.Point(3, 38);
            this.labelNumeroDoTicket.Name = "labelNumeroDoTicket";
            this.labelNumeroDoTicket.Size = new System.Drawing.Size(103, 26);
            this.labelNumeroDoTicket.TabIndex = 1;
            this.labelNumeroDoTicket.Text = "N° do Ticket:";
            // 
            // subtituloLancamentoBalcao
            // 
            this.subtituloLancamentoBalcao.BackColor = System.Drawing.Color.White;
            this.subtituloLancamentoBalcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtituloLancamentoBalcao.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtituloLancamentoBalcao.Location = new System.Drawing.Point(0, 0);
            this.subtituloLancamentoBalcao.Name = "subtituloLancamentoBalcao";
            this.subtituloLancamentoBalcao.Size = new System.Drawing.Size(606, 26);
            this.subtituloLancamentoBalcao.TabIndex = 0;
            this.subtituloLancamentoBalcao.Text = "Lançamento de recebimentos no balcão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(617, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 384);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.AutoSize = true;
            this.panelHeader.Controls.Add(this.panelTituloSistema);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1732, 87);
            this.panelHeader.TabIndex = 4;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.painelHeader_paint);
            // 
            // panelTituloSistema
            // 
            this.panelTituloSistema.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelTituloSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTituloSistema.BackColor = System.Drawing.Color.Transparent;
            this.panelTituloSistema.Controls.Add(this.labelTituloSistema);
            this.panelTituloSistema.Location = new System.Drawing.Point(3, 3);
            this.panelTituloSistema.Name = "panelTituloSistema";
            this.panelTituloSistema.Size = new System.Drawing.Size(815, 75);
            this.panelTituloSistema.TabIndex = 1;
            // 
            // labelTituloSistema
            // 
            this.labelTituloSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTituloSistema.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloSistema.Font = new System.Drawing.Font("Poppins SemiBold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloSistema.ForeColor = System.Drawing.Color.White;
            this.labelTituloSistema.Location = new System.Drawing.Point(3, 5);
            this.labelTituloSistema.Name = "labelTituloSistema";
            this.labelTituloSistema.Size = new System.Drawing.Size(809, 63);
            this.labelTituloSistema.TabIndex = 11;
            this.labelTituloSistema.Text = "SISTEMA ENIATO // LIVRO CAIXA";
            this.labelTituloSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip
            // 
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 894);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tableLayoutPanelCentral);
            this.Controls.Add(this.tableLayoutPanelLateral);
            this.Controls.Add(this.statusStripInformacoes);
            this.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Ambiente de Desenvolvimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStripInformacoes.ResumeLayout(false);
            this.statusStripInformacoes.PerformLayout();
            this.tableLayoutPanelLateral.ResumeLayout(false);
            this.tableLayoutPanelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContasAPagar)).EndInit();
            this.panelLancamentoBalcao.ResumeLayout(false);
            this.panelLancamentoBalcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelTituloSistema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripInformacoes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLateral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCentral;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTituloSistema;
        private System.Windows.Forms.Label labelTituloSistema;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLicensa;
        private System.Windows.Forms.Button buttonLancarRecebimento;
        private System.Windows.Forms.Button buttonLancarDespesa;
        private System.Windows.Forms.Button buttonChequesRecebidos;
        private System.Windows.Forms.Button buttonChequesEmitidos;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridViewContasAPagar;
        private System.Windows.Forms.Panel panelLancamentoBalcao;
        private System.Windows.Forms.Label subtituloLancamentoBalcao;
        private System.Windows.Forms.TextBox textBoxValorRecebido;
        private System.Windows.Forms.Label labelValorRecebido;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label labelNumeroDoTicket;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelNaoPossuaTicket;
        private System.Windows.Forms.ComboBox comboBoxMetodoDePagamento;
        private System.Windows.Forms.Label labelMetodoDePagamento;
        private System.Windows.Forms.TextBox textBoxNumeroTicket;
        private System.Windows.Forms.TextBox textBoxValorTotal;
        private System.Windows.Forms.TextBox textBoxNumeroCheque;
        private System.Windows.Forms.TextBox textBoxNumeroAgencia;
        private System.Windows.Forms.TextBox textBoxNumeroBanco;
        private System.Windows.Forms.Label labelNumeroCheque;
        private System.Windows.Forms.Label labelNumeroAgencia;
        private System.Windows.Forms.Label labelNumeroBanco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDatadoPara;
        private System.Windows.Forms.Label labelDatadoPara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLancarRecebimentoBalcao;
        private System.Windows.Forms.Button buttonConfiguracao;
        private System.Windows.Forms.TextBox textBoxNumeroConta;
        private System.Windows.Forms.Label labelNumeroConta;
    }
}

