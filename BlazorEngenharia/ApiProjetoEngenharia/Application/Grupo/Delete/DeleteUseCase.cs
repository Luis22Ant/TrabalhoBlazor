using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Grupo.Delete
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
            var entity = await _context.GRUPOS.FindAsync(id);

            if (entity != null)
            {
                _context.GRUPOS.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
