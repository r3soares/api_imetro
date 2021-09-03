using Realms;
using System.Collections;
using System.Collections.Generic;

namespace src.Domain.Models.Vtr
{
    public class Agenda : RealmObject
    {
        [PrimaryKey]
        public string Data { get; set; } //DD/MM/YYYY
        public IList<string> TanquesAgendados { get;}
        public int Status { get; set; }
    }

}