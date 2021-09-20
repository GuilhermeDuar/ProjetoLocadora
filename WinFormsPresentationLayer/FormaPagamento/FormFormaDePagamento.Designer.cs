
namespace WinFormsPresentationLayer
{
    partial class FormFormaDePagamento
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvFormaDePagamento = new System.Windows.Forms.DataGridView();
            this.btnCadastrarPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormaDePagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaDePagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Location = new System.Drawing.Point(267, 218);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 26);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvFormaDePagamento
            // 
            this.dgvFormaDePagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormaDePagamento.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFormaDePagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormaDePagamento.Location = new System.Drawing.Point(12, 60);
            this.dgvFormaDePagamento.Name = "dgvFormaDePagamento";
            this.dgvFormaDePagamento.RowHeadersVisible = false;
            this.dgvFormaDePagamento.RowHeadersWidth = 51;
            this.dgvFormaDePagamento.RowTemplate.Height = 24;
            this.dgvFormaDePagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormaDePagamento.Size = new System.Drawing.Size(342, 152);
            this.dgvFormaDePagamento.TabIndex = 8;
            // 
            // btnCadastrarPagamento
            // 
            this.btnCadastrarPagamento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastrarPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarPagamento.Location = new System.Drawing.Point(12, 218);
            this.btnCadastrarPagamento.Name = "btnCadastrarPagamento";
            this.btnCadastrarPagamento.Size = new System.Drawing.Size(87, 26);
            this.btnCadastrarPagamento.TabIndex = 7;
            this.btnCadastrarPagamento.Text = "Cadastrar";
            this.btnCadastrarPagamento.UseVisualStyleBackColor = false;
            this.btnCadastrarPagamento.Click += new System.EventHandler(this.btnCadastrarPagamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forma de Pagamento";
            // 
            // txtFormaDePagamento
            // 
            this.txtFormaDePagamento.Location = new System.Drawing.Point(12, 30);
            this.txtFormaDePagamento.Name = "txtFormaDePagamento";
            this.txtFormaDePagamento.Size = new System.Drawing.Size(342, 22);
            this.txtFormaDePagamento.TabIndex = 5;
            // 
            // FormFormaDePagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 332);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvFormaDePagamento);
            this.Controls.Add(this.btnCadastrarPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormaDePagamento);
            this.Name = "FormFormaDePagamento";
            this.Text = "FormFormaDePagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormaDePagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvFormaDePagamento;
        private System.Windows.Forms.Button btnCadastrarPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormaDePagamento;
    }
}