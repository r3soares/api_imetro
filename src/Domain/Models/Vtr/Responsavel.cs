using System;
using Newtonsoft.Json;
using Realms;
using src.Domain.Models.Vtr;

public class Responsavel : RealmObject
{
    [PrimaryKey]
    [Realms.Required]
    [JsonProperty]
    public string ID { get; set; }
    [Realms.Indexed]
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