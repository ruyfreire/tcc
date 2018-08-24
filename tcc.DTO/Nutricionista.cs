using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
   public class Nutricionista
    {
        public string email { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public DateTime nascimento { get; set; }
        public string sexo { get; set; }
        public int crn { get; set; }
        public string endereco { get; set; }
        public int cpf_cnpj { get; set; }
    }
}
