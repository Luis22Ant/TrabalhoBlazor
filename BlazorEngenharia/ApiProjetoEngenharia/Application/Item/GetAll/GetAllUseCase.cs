using ApiProjetoEngenharia.Infra;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Application.Item.GetAll
{
    public class GetAllUseCase
    {
        private readonly EngenhariaDbContext _context;

        public GetAllUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<List<Infra.Models.Item>> Execute()
        {
            var entities = await _context.ITENS
                .ToListAsync();

            return entities;
        }
    }
}
