using ApiProjetoEngenharia.Infra;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Application.Grupo.GetAll
{
    public class GetAllUseCase
    {
        private readonly EngenhariaDbContext _context;

        public GetAllUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<List<Infra.Models.Grupo>> Execute()
        {
            var entity = await _context.GRUPOS.ToListAsync();

            return entity;

        }
    }
}
