using Realms;
using System;

namespace src.Domain.Models.Vtr
{
    public class CustoTanque : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
        public int Tanque { get; set; }
        public DateTimeOffset DataCalculo { get; set; }
        public double Custo { get; set; }
    }

}
