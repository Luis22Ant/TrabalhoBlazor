using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Usuario.Update
{
    public class UpdateUseCase
    {
        private readonly EngenhariaDbContext _context;

        public UpdateUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Usuario> Execute(int id, Infra.Models.Usuario user)
        {
            var entity = await _context.USUARIOS.FindAsync(id);

            entity.Login = user.Login;
            entity.Senha = user.Senha;
            entity.Nome = user.Nome;
            //entity.TipoAcesso = user.TipoAcesso;

            _context.USUARIOS.Update(entity);
            await _context.SaveChangesAsync();
            return new Infra.Models.Usuario
            {
                Id = id
            };
        }
    }
}
