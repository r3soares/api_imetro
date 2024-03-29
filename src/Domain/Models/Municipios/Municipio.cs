﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Municipios
{
    [ValidateNever]
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
