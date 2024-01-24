using Exames_Clinpop.Shared.Modelos;
using Microsoft.AspNetCore.Components;
using System.Net;
using System.Net.Http.Json;

namespace Exames_Clinpop.Client.Services
{
    public class ExameService : IExameService
    {
        private readonly HttpClient _http;
        private readonly NavigationManager _navigationManger;

        public ExameService(HttpClient http, NavigationManager navigationManger)
        {
            _http = http;
            _navigationManger = navigationManger;
        }

        public List<Exame> Exames { get; set; } = new List<Exame>();



        public async Task CreateExame(Exame exame)
        {
            await _http.PostAsJsonAsync("api/exame", exame);
            _navigationManger.NavigateTo("exame");
        }

        public async Task DeleteExame(int id)
        {
            var result = await _http.DeleteAsync($"api/exame/{id}");
            _navigationManger.NavigateTo("exame");
        }

        public async Task<Exame?> GetExameById(int id)
        {
            var result = await _http.GetAsync($"api/exame/{id}");
            if (result.StatusCode == HttpStatusCode.OK)
            {
                return await result.Content.ReadFromJsonAsync<Exame>();
            }
            return null;
        }

        public async Task GetExames()
        {
            var result = await _http.GetFromJsonAsync<List<Exame>>("api/exame");
            if (result is not null)
                Exames = result;
        }

        public async Task UpdateExame(int id, Exame exame)
        {
            await _http.PutAsJsonAsync($"api/exame/{id}", exame);
            _navigationManger.NavigateTo("exame");
        }
    }
}

