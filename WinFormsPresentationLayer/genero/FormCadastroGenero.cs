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
    public partial class FormCadastroGenero : Form
    {
        private GeneroBLL generoBLL = new GeneroBLL();

        public FormCadastroGenero()
        {
            InitializeComponent();
            this.Load += FormCadastroGenero_Load;
            this.dgvGeneros.CellDoubleClick += DgvGeneros_CellDoubleClick;
        }

        private void DgvGeneros_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //o 'e' aponta para o evento 
        {
            Genero g = (Genero)this.dgvGeneros.Rows[e.RowIndex].DataBoundItem; // obtem o objeto que popula a linha no index
            FormEditDeleteGenero frm = new FormEditDeleteGenero(g);
            frm.ShowDialog();

            this.AtualizarGrid();

            // se tiver colection é um vetor ou lista
            //string nome = Convert.ToString(this.dgvGeneros.Rows[e.RowIndex].Cells[1].Value);
            //this.txtGenero.Text = nome;
        }

        private void FormCadastroGenero_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Genero g = new Genero();
            g.Nome = txtGenero.Text;
            Response resposta = generoBLL.Insert(g);
            MessageBox.Show(resposta.Message);
            AtualizarGrid();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            DataResponse<Genero> response = generoBLL.GetAll(); // posso estanciar assim pois o metodo retorna um objeto do tipo DataResponse
            if (response.Success)
            {
                this.dgvGeneros.DataSource = response.Data; //PROBLEMA AQUI
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        
    }
}
