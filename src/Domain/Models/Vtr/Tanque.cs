using System;
using System.Collections.Generic;
using Realms;

namespace src.Domain.Models.Vtr
{
    public class Tanque : RealmObject
    {
        [PrimaryKey]
        public int CodInmetro { get; set; }
        [Indexed]
        public string Placa { get; set; }
        public IList<Compartimento> Compartimentos { get; }
        public int Proprietario { get; set; }
        public DateTimeOffset DataRegistro { get; set; }
        public DateTimeOffset DataUltimaAlteracao { get; set; }
        public string AgendaTanque { get; set; }
        public int Status { get; set; }
        public string Custo { get; set; }
    }

}