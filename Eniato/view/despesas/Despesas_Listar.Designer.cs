
namespace Eniato.view.despesas
{
    partial class FormDespesas
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
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(338, 86);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerFinal.TabIndex = 29;
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(191, 85);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerInicial.TabIndex = 28;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(1176, 81);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(35, 31);
            this.buttonBuscar.TabIndex = 27;
            this.buttonBuscar.Text = "🔎";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlanoDeReceitas
            // 
            this.comboBoxPlanoDeReceitas.FormattingEnabled = true;
            this.comboBoxPlanoDeReceitas.Location = new System.Drawing.Point(923, 81);
            this.comboBoxPlanoDeReceitas.Name = "comboBoxPlanoDeReceitas";
            this.comboBoxPlanoDeReceitas.Size = new System.Drawing.Size(247, 31);
            this.comboBoxPlanoDeReceitas.TabIndex = 26;
            // 
            // labelPlanoDeReceitas
            // 
            this.labelPlanoDeReceitas.AutoSize = true;
            this.labelPlanoDeReceitas.Location = new System.Drawing.Point(782, 84);
            this.labelPlanoDeReceitas.Name = "labelPlanoDeReceitas";
            this.labelPlanoDeReceitas.Size = new System.Drawing.Size(135, 25);
            this.labelPlanoDeReceitas.TabIndex = 25;
            this.labelPlanoDeReceitas.Text = "Plano de receitas:";
            // 
            // labelAte
            // 
            this.labelAte.AutoSize = true;
            this.labelAte.Location = new System.Drawing.Point(301, 88);
            this.labelAte.Name = "labelAte";
            this.labelAte.Size = new System.Drawing.Size(35, 25);
            this.labelAte.TabIndex = 24;
            this.labelAte.Text = "até";
            // 
            // labelSelecionarPeriodo
            // 
            this.labelSelecionarPeriodo.AutoSize = true;
            this.labelSelecionarPeriodo.Location = new System.Drawing.Point(12, 84);
            this.labelSelecionarPeriodo.Name = "labelSelecionarPeriodo";
            this.labelSelecionarPeriodo.Size = new System.Drawing.Size(176, 25);
            this.labelSelecionarPeriodo.TabIndex = 23;
            this.labelSelecionarPeriodo.Text = "Selecionar vencimento:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(94, 46);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(613, 27);
            this.textBoxDescricao.TabIndex = 22;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(12, 46);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(85, 25);
            this.labelDescricao.TabIndex = 21;
            this.labelDescricao.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.Image = global::Eniato.Properties.Resources.icons8_delete_file_32;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.Location = new System.Drawing.Point(1136, 4);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 72);
            this.buttonExcluir.TabIndex = 19;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Image = global::Eniato.Properties.Resources.icons8_edit_file_32;
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonModificar.Location = new System.Drawing.Point(1055, 4);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 72);
            this.buttonModificar.TabIndex = 18;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poppins", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Eniato.Properties.Resources.icons8_add_file_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(974, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 647);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicial);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxPlanoDeReceitas);
            this.Controls.Add(this.labelPlanoDeReceitas);
            this.Controls.Add(this.labelAte);
            this.Controls.Add(this.labelSelecionarPeriodo);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDespesas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas // Listar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ComboBox comboBoxPlanoDeReceitas;
        private System.Windows.Forms.Label labelPlanoDeReceitas;
        private System.Windows.Forms.Label labelAte;
        private System.Windows.Forms.Label labelSelecionarPeriodo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button button1;
    }
}