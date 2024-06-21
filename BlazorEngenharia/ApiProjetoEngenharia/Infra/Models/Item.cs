namespace ApiProjetoEngenharia.Infra.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Ativo { get; set; } = string.Empty;

        public int GrupoId { get; set; }
        public Grupo? Grupo { get; set; }
    }
}
