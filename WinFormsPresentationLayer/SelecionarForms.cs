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
    public partial class SelecionarForms : Form
    {
        public SelecionarForms()
        {
            InitializeComponent();
            this.lblGenero.DoubleClick += LblGenero_DoubleClick;
            this.lblFormasDePagamento.DoubleClick += LblFormasDePagamento_DoubleClick; ;

        }

        private void LblFormasDePagamento_DoubleClick(object sender, EventArgs e)
        {
            FormFormaDePagamento formaDePagamento = new FormFormaDePagamento();
            formaDePagamento.ShowDialog();
        }

        private void LblGenero_DoubleClick(object sender, EventArgs e)
        {
            FormCadastroGenero cadastroGenero = new FormCadastroGenero();
            cadastroGenero.ShowDialog();
        }
       
    }
}
