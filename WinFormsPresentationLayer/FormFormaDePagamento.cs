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
            fp.Descrição = txtFormaDePagamento.Text;

            Response resposta = pagamentoBll.Insert(fp);

            AtualizarGrid();
            MessageBox.Show(resposta.Messagem);
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
                MessageBox.Show(response.Messagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Response r = pagamentoBll.Delete(int.Parse(txtDeletar.Text));
            MessageBox.Show(r.Messagem);
            if (r.Success)
            {
                this.Close();
            }
        }
    }
}
