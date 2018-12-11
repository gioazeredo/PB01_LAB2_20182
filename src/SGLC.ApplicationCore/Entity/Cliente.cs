using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.ApplicationCore.Entity
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        public string  Nome { get; set; }

        public string Email { get; set; }

        public List<Locacao> Locacao { get; set; }

        public Endereco Endereco { get; set; }

    }
}
