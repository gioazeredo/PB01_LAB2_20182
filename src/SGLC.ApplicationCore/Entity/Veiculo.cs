using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.ApplicationCore.Entity
{
    public class Veiculo
    {

        public int VeiculoId { get; set; }

        public string Descricao { get; set; }

        public string Placa { get; set; }

        public int MarcaId { get; set; }

        public Marca Marca { get; set; }
    }
}
