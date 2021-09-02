using Realms;

namespace src.Domain.Models.Vtr
{
    public class CustoTanque : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; } = System.Guid.NewGuid().ToString();
    }

}
