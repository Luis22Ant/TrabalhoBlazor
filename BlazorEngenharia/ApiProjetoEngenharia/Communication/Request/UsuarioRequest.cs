namespace ApiProjetoEngenharia.Communication.Request
{
    public class UsuarioRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public TipoAcesso TipoAcesso { get; set; }
    }

    public enum TipoAcesso
    {
        Admin = 0,
        Usuario = 1
    }

}
