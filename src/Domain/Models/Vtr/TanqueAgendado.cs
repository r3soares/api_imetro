using System;

namespace src.Domain.Models.Vtr
{
    public class TanqueAgendado : Realms.RealmObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }

}