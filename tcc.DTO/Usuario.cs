using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
   public class Usuario
    {
        public int id_usuario { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public DateTime nascimento { get; set; }
        public string sexo { get; set; }
        public Decimal peso { get; set; }
        public Decimal altura { get; set; }
        public string objetivo { get; set; }
        public string id_gym_personal { get; set; }
        public string id_nutricionista { get; set; }
    }
}
