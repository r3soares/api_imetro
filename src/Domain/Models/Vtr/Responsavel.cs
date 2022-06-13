using System;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Newtonsoft.Json;
using Realms;

namespace src.Domain.Models.Vtr
{
    [ValidateNever]
    [JsonObject(MemberSerialization.OptIn)]
    public class Responsavel : RealmObject
    {
        [PrimaryKey]
        [Required]
        [JsonProperty]
        public string ID { get; set; }
        [Indexed]
        public string Nome { get; set; }
        [JsonProperty]
        public string Telefone { get; set; }
        [JsonProperty]
        public string Email { get; set; }
        [JsonProperty]
        public string Empresa { get; set; }
        [JsonProperty]
        public string Obs { get; set; }

        public static string GetNovoID => Guid.NewGuid().ToString();
    }
}