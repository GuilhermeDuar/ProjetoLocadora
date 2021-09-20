using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class BaseValidator<T> // obj qualquer
    {
        
        private StringBuilder erros = new StringBuilder();

        protected void AddError(string error)
        {
            if (!string.IsNullOrWhiteSpace(error))
            {
                this.erros.AppendLine(error);
            }
        }

        public virtual Response Validate(T item)
        {
            Response r = new Response();
            if (this.erros.Length != 0)
            {
                r.Success = false;
                r.Message = this.erros.ToString();
                this.erros.Clear();
                return r;
            }
            r.Success = true;
            r.Message = "Validação realizada com sucesso!";
            return r;
        }
    }
}
