using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Communication.Response;
using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Usuario.Register
{
    public class RegisterUseCase
    {
        private readonly EngenhariaDbContext _context;

        public RegisterUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<ResponseId> Execute(UsuarioRequest request)
        {
            var entity = new Infra.Models.Usuario
            {
                Nome = request.Nome,
                Login = request.Login,
                Senha = request.Senha,
                TipoAcesso = (Infra.Models.TipoAcesso)request.TipoAcesso,
                DataCriacao = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
            };

            _context.USUARIOS.Add(entity);
            await _context.SaveChangesAsync();

            return new ResponseId
            {
                Id = 1
            };
        }
    }
}
