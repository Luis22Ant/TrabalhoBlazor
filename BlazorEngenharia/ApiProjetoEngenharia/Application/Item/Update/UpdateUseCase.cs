using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Infra;

namespace ApiProjetoEngenharia.Application.Item.Update
{
    public class UpdateUseCase
    {
        private readonly EngenhariaDbContext _context;

        public UpdateUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Item> Execute(int itemId, ItemRequest request)
        {
            var entity = await _context.ITENS.FindAsync(itemId);

            if (entity != null)
            {
                entity.Ativo = request.Ativo;
                entity.Cor = request.Cor;
                entity.Descricao = request.Descricao;
                entity.GrupoId = request.GrupoId;
                entity.Marca = request.Marca;


                _context.Update(entity);
                await _context.SaveChangesAsync();
            }

            return entity;


        }
    }
}
