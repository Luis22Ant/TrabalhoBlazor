using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Item.Register
{
    public class RegisterUseCase
    {
        private readonly EngenhariaDbContext _context;

        public RegisterUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<bool> Execute(ItemRequest request)
        {
            var entity = new Infra.Models.Item
            {
                Descricao = request.Descricao,
                Marca = request.Marca,
                Cor = request.Cor,
                Ativo = request.Ativo,
                GrupoId = request.GrupoId
            };

            _context.ITENS.Add(entity);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
