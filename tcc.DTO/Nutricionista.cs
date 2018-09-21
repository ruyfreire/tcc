using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
   public class Nutricionista : Profissional
    {
        public int id_nutricionista { get; set; }
        public string crn { get; set; }
    }
}
