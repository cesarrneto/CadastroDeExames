using Exames_Clinpop.Server.Services;
using Exames_Clinpop.Shared.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Exames_Clinpop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        public class ProductController : ControllerBase
        {
            private readonly IExameService _exameService;

            public ProductController(IExameService exameService)
            {
                _exameService = exameService;
            }

            [HttpGet]
            public async Task<List<Exame>> GetExames()
            {
                return await _exameService.GetExames();
            }

            [HttpGet("{id}")]
            public async Task<Exame?> GetExameById(int id)
            {
                return await _exameService.GetExameById(id);
            }

            [HttpPost]
            public async Task<Exame?> CreateExame(Exame exame)
            {
                return await _exameService.CreateExame(exame);
            }

            [HttpPut("{id}")]
            public async Task<Exame?> UpdateExame(int id, Exame exame)
            {
                return await _exameService.UpdateExame(id, exame);
            }

            [HttpDelete("{id}")]
            public async Task<bool> DeleteExame(int id)
            {
                return await _exameService.DeleteExame(id);
            }
        }
    }
}
