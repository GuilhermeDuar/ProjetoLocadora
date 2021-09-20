using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogicalLayer
{
    public class FuncionarioBLL : BaseValidator<Funcionario>, IFuncionarioService
    {
        private FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public SingleResponse<Funcionario> Authenticate(string email, string senha)
        {
            SingleResponse<Funcionario> sr = new SingleResponse<Funcionario>();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                this.AddError("Email deve ser informado.");
            }

            // se chamar o this.Validate(), todas as validações seriam repetidas! Não queremos isso,
            //apenas validar oq esta de parametro no metodo de autenticação e p metodo da classe pai que transforma erros em um response
            Response response = base.Validate(null);
            if (response.Success)
            {
                SingleResponse<Funcionario> responseFuncionario = funcionarioDAL.Authenticate(email, senha);
                if (responseFuncionario.Success)
                {
                    SystemParameters.Authenticate(responseFuncionario.item);
                    return responseFuncionario;
                }
            }
            return new SingleResponse<Funcionario>()
            {
                Message = response.Message,
                Success = false
            };
        }
    }
}
