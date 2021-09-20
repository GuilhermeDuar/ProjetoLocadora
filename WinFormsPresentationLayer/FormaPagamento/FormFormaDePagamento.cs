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
    public partial class FormFormaDePagamento : Form
    {
        FormaDePagamentoBLL pagamentoBll = new FormaDePagamentoBLL();

        public FormFormaDePagamento()
        {
            InitializeComponent();
            this.Load += FormFormaDePagamento_Load;
            this.dgvFormaDePagamento.CellDoubleClick += DgvFormaDePagamento_CellDoubleClick;
        }

        private void DgvFormaDePagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormaDePagamento fp = (FormaDePagamento)this.dgvFormaDePagamento.Rows[e.RowIndex].DataBoundItem;
            FormEditarFormaPagamento editarFormaPagmento = new FormEditarFormaPagamento(fp);
            editarFormaPagmento.ShowDialog();

            this.AtualizarGrid();
        }

        private void FormFormaDePagamento_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCadastrarPagamento_Click(object sender, EventArgs e)
        {
            FormaDePagamento fp = new FormaDePagamento();
            fp.Descricao = txtFormaDePagamento.Text;

            Response resposta = pagamentoBll.Insert(fp);

            AtualizarGrid();
            MessageBox.Show(resposta.Message);
        }

        private void AtualizarGrid()
        {
            DataResponse<FormaDePagamento> response = pagamentoBll.GetAll(); 
            if (response.Success)
            {
                this.dgvFormaDePagamento.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

    }
}
