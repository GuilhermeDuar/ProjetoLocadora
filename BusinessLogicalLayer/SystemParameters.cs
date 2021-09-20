using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public static class SystemParameters
    {
        private static Funcionario _funcionario; // static para nunca morrere não precisar ser instanciada
        
        public static void Authenticate(Funcionario funcionario) // não pode usar this. pois não tem objeto, não tem acesso a nada a neão ser oque é static
        {
            _funcionario = funcionario;
        }

        public static void Logout()
        {
            _funcionario = null;
        }

        public static Funcionario GetCurrentFuncionario()
        {
            return _funcionario;
        }

        //Funcionario f = SystemParameters.GetCurrentFuncionario();

    }
}
