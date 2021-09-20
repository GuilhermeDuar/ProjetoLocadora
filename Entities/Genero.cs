using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Genero
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return string.Format("ID: {0} - Nome: {1}", ID, Nome);
        }
    }
    
}
