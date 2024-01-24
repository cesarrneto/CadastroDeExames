using Exames_Clinpop.Shared.Modelos;

namespace Exames_Clinpop.Server.Services
{
    public interface IExameService
    {
        
        Task<List<Exame>> GetExames();
        Task<Exame?> GetExameById(int exameId);
        Task<Exame> CreateExame(Exame exame);
        Task<Exame?> UpdateExame(int exameId, Exame exame);
        Task<bool> DeleteExame(int exameId);
    }
}

