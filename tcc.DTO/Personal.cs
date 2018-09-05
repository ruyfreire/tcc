using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
   public class Personal
    {
        public string senha { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime nascimento { get; set; }
        public string sexo { get; set; }
        public string crea { get; set; }
        public string endereco { get; set; }
        public string cpf_cnpj { get; set; }
    }
}
