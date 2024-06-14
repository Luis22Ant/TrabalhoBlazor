namespace ApiProjetoEngenharia.Infra.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public TipoAcesso TipoAcesso { get; set; }
        public string UltimoAcesso { get; set; } = string.Empty;
        public string DataCriacao { get; set; } = string.Empty;
    }

    public enum TipoAcesso
    {
        Admin = 0,
        Usuario = 1
    }
}
