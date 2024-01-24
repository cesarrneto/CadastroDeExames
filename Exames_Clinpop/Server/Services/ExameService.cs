using Exames_Clinpop.Server.Data;
using Exames_Clinpop.Shared.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Exames_Clinpop.Server.Services
{
    public class ExameService : IExameService
    {
        private readonly DataContext _context;

        public ExameService(DataContext context)
        {
            _context = context;
        }

        public async Task<Exame> CreateExame(Exame exame)
        {
            try 
            { 
            _context.Add(exame);
            await _context.SaveChangesAsync();
            return exame;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> DeleteExame(int exameId)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
            if (dbExame == null)
            {
                return false;
            }

            _context.Remove(dbExame);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<Exame?> GetExameById(int exameId)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
            return dbExame;
        }

        public async Task<List<Exame>> GetExames()
        {
            try
            {
                return await _context.Exames.ToListAsync();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Exame?> UpdateExame(int exameId, Exame exame)
        {
            var dbExame = await _context.Exames.FindAsync(exameId);
            if (dbExame != null)
            {
                dbExame.NomeExame = exame.NomeExame;
                dbExame.DescricaoExame = exame.DescricaoExame;
                dbExame.Preco = exame.Preco;

                await _context.SaveChangesAsync();
            }

            return dbExame;
        }
    }
}
