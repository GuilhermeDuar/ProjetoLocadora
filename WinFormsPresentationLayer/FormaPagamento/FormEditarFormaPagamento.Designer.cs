
namespace WinFormsPresentationLayer
{
    partial class FormEditarFormaPagamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDFormaPagamento = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditFormaPagamento = new System.Windows.Forms.TextBox();
            this.txtIDExcluir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID";
            // 
            // txtIDFormaPagamento
            // 
            this.txtIDFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDFormaPagamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIDFormaPagamento.Enabled = false;
            this.txtIDFormaPagamento.Location = new System.Drawing.Point(13, 39);
            this.txtIDFormaPagamento.Name = "txtIDFormaPagamento";
            this.txtIDFormaPagamento.Size = new System.Drawing.Size(198, 15);
            this.txtIDFormaPagamento.TabIndex = 13;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Info;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Location = new System.Drawing.Point(163, 114);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 22);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(163, 87);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 22);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Forma de Pagamento";
            // 
            // txtEditFormaPagamento
            // 
            this.txtEditFormaPagamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEditFormaPagamento.Location = new System.Drawing.Point(12, 87);
            this.txtEditFormaPagamento.Name = "txtEditFormaPagamento";
            this.txtEditFormaPagamento.Size = new System.Drawing.Size(145, 22);
            this.txtEditFormaPagamento.TabIndex = 9;
            // 
            // txtIDExcluir
            // 
            this.txtIDExcluir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDExcluir.Location = new System.Drawing.Point(12, 115);
            this.txtIDExcluir.Name = "txtIDExcluir";
            this.txtIDExcluir.Size = new System.Drawing.Size(145, 22);
            this.txtIDExcluir.TabIndex = 15;
            // 
            // FormEditarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 218);
            this.Controls.Add(this.txtIDExcluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDFormaPagamento);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditFormaPagamento);
            this.Name = "FormEditarFormaPagamento";
            this.Text = "FormEditarFormaPagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDFormaPagamento;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditFormaPagamento;
        private System.Windows.Forms.TextBox txtIDExcluir;
    }
}