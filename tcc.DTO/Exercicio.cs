using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
    public class Exercicio
    {
        public int id_exercicio { get; set; }
        public string nome { get; set; }
        public string grupo_muscular { get; set; }
        public string execucao { get; set; }
        public int queima_calorica { get; set; }
        public int tempo { get; set; }
    }
}
