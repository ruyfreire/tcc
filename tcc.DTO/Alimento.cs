using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
    public class Alimento
    {
        public int id_alimento { get; set; }
        public string nome { get; set; }
        public string grupo_nutricional { get; set; }
        public int calorias { get; set; }
        public int porcao { get; set; }
    }
}
