using ApiProjetoEngenharia.Infra;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Application.Item.Filter
{
    public class GetItemFilterUseCase
    {
        private readonly EngenhariaDbContext _context;

        public GetItemFilterUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<List<Infra.Models.Item>> Execute(string filtroAtivo)
        {
            var entity = await _context.ITENS.Where(i => i.Ativo == filtroAtivo)
                .Include(i => i.Grupo)
                .ToListAsync();

            return entity;
        }
    }
}
