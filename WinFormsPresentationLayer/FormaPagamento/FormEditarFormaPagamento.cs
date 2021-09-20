using BusinessLogicalLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPresentationLayer
{
    public partial class FormEditarFormaPagamento : Form
    {
        FormaDePagamentoBLL formaPagamentoBLL = new FormaDePagamentoBLL();
        public FormEditarFormaPagamento(FormaDePagamento fp)
        {
            InitializeComponent();
            this.txtIDFormaPagamento.Text = fp.ID.ToString();
            this.txtEditFormaPagamento.Text = fp.Descricao;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Response r = formaPagamentoBLL.UpDate(new FormaDePagamento() 
            {
                ID = int.Parse(txtIDFormaPagamento.Text),
                Descricao = txtEditFormaPagamento.Text
            });
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Response r = formaPagamentoBLL.Delete(int.Parse(txtIDExcluir.Text));
            MessageBox.Show(r.Message);
            if (r.Success)
            {
                this.Close();
            }
        }
    }
}
