using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Usuario.Delete
{
    public class DeleteUseCase
    {
        private readonly EngenhariaDbContext _context;

        public DeleteUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<bool> Execute(int id)
        {
            var entity = await _context.USUARIOS.FindAsync(id);

            if (entity == null)
            {
                return false;
            }

            _context.USUARIOS.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
