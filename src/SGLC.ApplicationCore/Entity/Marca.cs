using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.ApplicationCore.Entity
{
    public class Marca
    {

        public int MarcaId { get; set; }

        public string Descricao { get; set; }

        public List<Veiculo> Veiculo { get; set; }

    }
}
