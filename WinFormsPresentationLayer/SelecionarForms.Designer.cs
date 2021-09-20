
namespace WinFormsPresentationLayer
{
    partial class SelecionarForms
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
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFormasDePagamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(12, 29);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(145, 31);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "-> Gêneros";
            // 
            // lblFormasDePagamento
            // 
            this.lblFormasDePagamento.AutoSize = true;
            this.lblFormasDePagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFormasDePagamento.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasDePagamento.Location = new System.Drawing.Point(12, 89);
            this.lblFormasDePagamento.Name = "lblFormasDePagamento";
            this.lblFormasDePagamento.Size = new System.Drawing.Size(309, 31);
            this.lblFormasDePagamento.TabIndex = 1;
            this.lblFormasDePagamento.Text = "-> Formas De Pagamento";
            // 
            // SelecionarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormasDePagamento);
            this.Controls.Add(this.lblGenero);
            this.Name = "SelecionarForms";
            this.Text = "SelecionarForms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFormasDePagamento;
    }
}