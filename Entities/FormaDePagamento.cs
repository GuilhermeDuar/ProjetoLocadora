using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class FormaDePagamento
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public override string ToString()
        {
            return string.Format("ID: {0} - Forma de pagamento: {1}", ID, Descricao);
        }
    }
}
