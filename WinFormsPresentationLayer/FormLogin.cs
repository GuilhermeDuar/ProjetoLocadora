using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicalLayer;
using Entities;
using Shared;

namespace WinFormsPresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SingleResponse<Funcionario> response =
                funcionarioBLL.Authenticate(txtEmail.Text, txtSenha.Text);
            if (response.Success)
            {
                FormMenu frm = new FormMenu();
                frm.Visible = true;

            }
        }
    }
}
