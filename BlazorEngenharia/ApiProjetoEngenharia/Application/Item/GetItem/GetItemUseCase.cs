using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Item.GetItem
{
    public class GetItemUseCase
    {
        private readonly EngenhariaDbContext _context;

        public GetItemUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Item> Execute(int idItem)
        {
            var entity = await _context.ITENS.FindAsync(idItem);

            return entity;
        }
    }
}
