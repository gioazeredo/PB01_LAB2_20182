using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.ApplicationCore.Entity
{
   public class Locacao
    {

        public int LocacaoId { get; set; }

        public int Numero { get; set; }

        public DateTime DataLocacao { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }


    }
}
