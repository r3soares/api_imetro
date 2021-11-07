using Newtonsoft.Json;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Models.Municipios
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Municipio : RealmObject
    {
        [JsonProperty]
        public Estado UnfId { get; set; }
        [JsonProperty]
        public int MunId { get; set; }
        [JsonProperty]
        [PrimaryKey]
        public int CdMunicipio { get; set; }
        [JsonProperty]
        public string NoMunicipio { get; set; }
        public int AoInativo { get; set; }
    }
}
