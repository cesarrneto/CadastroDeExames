using Exames_Clinpop.Shared.Modelos;

namespace Exames_Clinpop.Client.Services
{
    public interface IExameService
    {
        List<Exame> Exames { get; set; }
        Task GetExames();
        Task<Exame?> GetExameById(int id);
        Task CreateExame(Exame exame);
        Task UpdateExame(int id, Exame exame);
        Task DeleteExame(int id);
    }
}
