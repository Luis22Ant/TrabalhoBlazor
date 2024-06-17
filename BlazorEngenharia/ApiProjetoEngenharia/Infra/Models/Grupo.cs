using System.Text.Json.Serialization;

namespace ApiProjetoEngenharia.Infra.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;

     
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
