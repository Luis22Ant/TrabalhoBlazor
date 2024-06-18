using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Grupo.Register
{
    public class RegisterUseCase
    {
        private readonly EngenhariaDbContext _context;

        public RegisterUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Grupo> Execute(GrupoRequest request)
        {
            var entity = new Infra.Models.Grupo
            {
                Descricao = request.Descricao,
                Tipo = request.Tipo
            };

            _context.GRUPOS.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
