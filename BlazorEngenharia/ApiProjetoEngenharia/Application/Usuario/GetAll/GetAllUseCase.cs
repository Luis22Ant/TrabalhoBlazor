using ApiProjetoEngenharia.Communication.Response;
using ApiProjetoEngenharia.Infra;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Application.Usuario.GetAll
{
    public class GetAllUseCase
    {

        private readonly EngenhariaDbContext _context;

        public GetAllUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<List<Infra.Models.Usuario>> Execute()
        {
            var entity = await _context.USUARIOS.ToListAsync();

            return entity;
        }
    }
}
