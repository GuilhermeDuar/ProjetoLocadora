using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class GeneroBLL : BaseValidator<Genero>, IGeneroService
    {
        private GeneroDAL generoDAL = new GeneroDAL();

        public override Response Validate(Genero item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                this.AddError("Genero deve ser informado!");
            }
            else
            {
                item.Nome = Normatizacao.NormatizeString(item.Nome);
                if (item.Nome.Length < 3 || item.Nome.Length > 30)
                {
                    this.AddError("Genero deve conter entre 3 a 30 caracteres.");
                }
            }
            return base.Validate(item); // converte em response
        }

        public Response Insert(Genero g)
        {
            Response resposta = this.Validate(g);
            if (!resposta.Success)
            {
                return resposta;
            }
            return generoDAL.Insert(g);
        }
        public DataResponse<Genero> GetAll()
        { // se remover as mascaras do cpf, aqui colocaria novamente, ou informar que não achou nd
            return generoDAL.GetAll();
        }

        public Response UpDate(Genero g)
        {
            Response resposta = this.Validate(g);
            if (!resposta.Success)
            {
                return resposta;
            }
            return generoDAL.UpDate(g);
        }

        public Response Delete(int id)
        {
            return generoDAL.Delete(id);
        }
    }
}
