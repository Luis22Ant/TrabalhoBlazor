using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Item.Delete
{
    public class DeleteUseCase
    {
        private readonly EngenhariaDbContext _context;

        public DeleteUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<bool> Execute(int idItem)
        {
            var entity = await _context.ITENS.FindAsync(idItem);

            if (entity is null)
                return false;

            _context.Remove(entity);
            await _context.SaveChangesAsync();

            return true;



        }
    }
}
