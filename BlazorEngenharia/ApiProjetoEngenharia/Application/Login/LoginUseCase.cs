using ApiProjetoEngenharia.Communication.Request;
using ApiProjetoEngenharia.Communication.Response;
using ApiProjetoEngenharia.Infra;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ApiProjetoEngenharia.Application.Login
{
    public class LoginUseCase
    {
        private readonly EngenhariaDbContext _context;

        public LoginUseCase()
        {
            _context = new EngenhariaDbContext();
        }

        public async Task<Infra.Models.Usuario> Execute(LoginRequest request)
        {
            var entity = await _context.USUARIOS.SingleOrDefaultAsync(u => u.Login == request.Login && u.Senha == request.Senha);

            if (entity is null)
                return entity;

            entity.UltimoAcesso = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            _context.USUARIOS.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
