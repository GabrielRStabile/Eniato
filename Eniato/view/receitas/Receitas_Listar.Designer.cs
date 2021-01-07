
namespace Eniato
{
    partial class FormReceitas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.comboBoxPlanoDeReceitas = new System.Windows.Forms.ComboBox();
            this.labelPlanoDeReceitas = new System.Windows.Forms.Label();
            this.labelAte = new System.Windows.Forms.Label();
            this.labelSelecionarPeriodo = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResultadoDaBusca = new System.Windows.Forms.DataGridView();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoDaBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerFinal);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePickerInicial);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxPlanoDeReceitas);
            this.splitContainer1.Panel1.Controls.Add(this.labelPlanoDeReceitas);
            this.splitContainer1.Panel1.Controls.Add(this.labelAte);
            this.splitContainer1.Panel1.Controls.Add(this.labelSelecionarPeriodo);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.labelDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExcluir);
            this.splitContainer1.Panel1.Controls.Add(this.buttonModificar);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewResultadoDaBusca);
            this.splitContainer1.Size = new System.Drawing.Size(963, 708);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(304, 85);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerFinal.TabIndex = 16;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(157, 85);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerInicial.TabIndex = 15;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(916, 81);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(35, 31);
            this.buttonBuscar.TabIndex = 14;
            this.buttonBuscar.Text = "🔎";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // comboBoxPlanoDeReceitas
            // 
            this.comboBoxPlanoDeReceitas.FormattingEnabled = true;
            this.comboBoxPlanoDeReceitas.Location = new System.Drawing.Point(548, 81);
            this.comboBoxPlanoDeReceitas.Name = "comboBoxPlanoDeReceitas";
            this.comboBoxPlanoDeReceitas.Size = new System.Drawing.Size(362, 31);
            this.comboBoxPlanoDeReceitas.TabIndex = 13;
            // 
            // labelPlanoDeReceitas
            // 
            this.labelPlanoDeReceitas.AutoSize = true;
            this.labelPlanoDeReceitas.Location = new System.Drawing.Point(417, 84);
            this.labelPlanoDeReceitas.Name = "labelPlanoDeReceitas";
            this.labelPlanoDeReceitas.Size = new System.Drawing.Size(135, 25);
            this.labelPlanoDeReceitas.TabIndex = 12;
            this.labelPlanoDeReceitas.Text = "Plano de receitas:";
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(267, 85);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(35, 25);
            this.labelAte.TabIndex = 11;
            this.labelAte.Text = "até";
            // 
            // labelSelecionarPeriodo
            // 
            this.labelSelecionarPeriodo.AutoSize = true;
            this.labelSelecionarPeriodo.Location = new System.Drawing.Point(13, 84);
            this.labelSelecionarPeriodo.Name = "labelSelecionarPeriodo";
            this.labelSelecionarPeriodo.Size = new System.Drawing.Size(145, 25);
            this.labelSelecionarPeriodo.TabIndex = 8;
            this.labelSelecionarPeriodo.Text = "Selecionar período:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(95, 46);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(613, 27);
            this.textBoxDescricao.TabIndex = 5;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(13, 46);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(85, 25);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // dataGridViewResultadoDaBusca
            // 
            this.dataGridViewResultadoDaBusca.AllowUserToAddRows = false;
            this.dataGridViewResultadoDaBusca.AllowUserToDeleteRows = false;
            this.dataGridViewResultadoDaBusca.AllowUserToResizeRows = false;
            this.dataGridViewResultadoDaBusca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewResultadoDaBusca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoDaBusca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResultadoDaBusca.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultadoDaBusca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewResultadoDaBusca.Name = "dataGridViewResultadoDaBusca";
            this.dataGridViewResultadoDaBusca.ReadOnly = true;
            this.dataGridViewResultadoDaBusca.RowHeadersWidth = 51;
            this.dataGridViewResultadoDaBusca.Size = new System.Drawing.Size(963, 584);
            this.dataGridViewResultadoDaBusca.TabIndex = 0;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = global::Eniato.Properties.Resources.icons8_delete_file_32;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.Location = new System.Drawing.Point(876, 4);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 72);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Image = global::Eniato.Properties.Resources.icons8_edit_file_32;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModificar.Location = new System.Drawing.Point(795, 4);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 72);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Eniato.Properties.Resources.icons8_add_file_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(714, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 708);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceitas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas // Listar Lançamentos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoDaBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewResultadoDaBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label labelSelecionarPeriodo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.ComboBox comboBoxPlanoDeReceitas;
        private System.Windows.Forms.Label labelPlanoDeReceitas;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
    }
}