using System;
using System.Collections.Generic;
using System.Text;

namespace SGLC.ApplicationCore.Entity
{
    public class LocacaoVeiculo
    {

        public int Id { get; set; }

        public int LocacaoId { get; set; }

        public Locacao Locacao { get; set; }

        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }

    }
}
