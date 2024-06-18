using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Grupo.Update
{
    public class UpdateUseCase
    {

        private readonly EngenhariaDbContext _context;

        public UpdateUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Grupo> Execute(GrupoRequest request, int id)
        {
            var entity = await _context.GRUPOS.FindAsync(id);

            entity.Descricao = request.Descricao;
            entity.Tipo = request.Tipo;

            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
