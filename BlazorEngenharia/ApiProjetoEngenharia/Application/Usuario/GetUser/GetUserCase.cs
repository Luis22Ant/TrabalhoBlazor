using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Usuario.GetUser
{
    public class GetUserCase
    {
        private readonly EngenhariaDbContext _context;

        public GetUserCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Usuario> Execute(int id)
        {
            var entity = await _context.USUARIOS.FindAsync(id);

            return entity;

        }
    }
}
