namespace ApiProjetoEngenharia.Communication.Request
{
    public class ItemRequest
    {
        public string Descricao { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Ativo { get; set; } = string.Empty;

        public int GrupoId { get; set; }
    }
}
