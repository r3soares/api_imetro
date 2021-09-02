using Realms;

namespace src.Domain.Models.Vtr
{
    public class Agenda : RealmObject
    {
        [PrimaryKey]
        public long Data { get; set; }
    }

}