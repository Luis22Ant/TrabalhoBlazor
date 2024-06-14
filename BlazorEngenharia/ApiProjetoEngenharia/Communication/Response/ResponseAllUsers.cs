using ApiProjetoEngenharia.Infra.Models;

namespace ApiProjetoEngenharia.Communication.Response
{
    public class ResponseAllUsers
    {
        public List<Usuario> Users { get; set; } = new List<Usuario>();
    }
}
