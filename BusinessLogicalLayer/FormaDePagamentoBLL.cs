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
    public class FormaDePagamentoBLL : BaseValidator<FormaDePagamento>, IFormaDePagamentoService
    {
        FormaDePagamentoDAL pagamentoDAL = new FormaDePagamentoDAL();

        public override Response Validate(FormaDePagamento item)
        {
            if (string.IsNullOrWhiteSpace(item.Descricao))
            {
                this.AddError("A forma de pagamento deve ser informada!");
            }
            else
            {
                item.Descricao = Normatizacao.NormatizeString(item.Descricao);
                if (item.Descricao.Length < 3 || item.Descricao.Length > 30)
                {
                    this.AddError("A forma de pagamento deve conter entre 3 a 30 caracteres.");
                }
            }
            return base.Validate(item);
        }

        public Response Insert(FormaDePagamento fp)
        {
            Response resposta = this.Validate(fp);
            if (!resposta.Success)
            {
                return resposta;
            }
            return pagamentoDAL.Insert(fp);
        }

        public DataResponse<FormaDePagamento> GetAll()
        {
            return pagamentoDAL.GetAll();
        }

        public Response UpDate(FormaDePagamento fp)
        {
            Response resposta = this.Validate(fp);
            if (!resposta.Success)
            {
                return resposta;
            }
            return pagamentoDAL.UpDate(fp);
        }

        public Response Delete(int id)
        {
            return pagamentoDAL.Delete(id);
        }

    }
}
