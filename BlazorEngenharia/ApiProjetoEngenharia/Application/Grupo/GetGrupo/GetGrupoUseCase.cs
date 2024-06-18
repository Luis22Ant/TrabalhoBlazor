using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Grupo.GetGrupo
{
    public class GetGrupoUseCase
    {
        private readonly EngenhariaDbContext _context;

        public GetGrupoUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Grupo> Execute(int id)
        {
            var entity = await _context.GRUPOS.FindAsync(id);

            return entity;
        }
    }
}
