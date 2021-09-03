using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    public class AgendaTanque : Realms.RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Agenda { get; set; }
        public int Tanque { get; set; }
        public int StatusConfirmacao { get; set; }
        public int StatusPagamento { get; set; }
        public string Responsavel { get; set; }
    }

}