﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc.DTO
{
   public class Treino
    {
        public int id_treino { get; set; }
        public int id_exercicio { get; set; }
        public int serie { get; set; }
        public DateTimeOffset duracao { get; set; }
    }
}
