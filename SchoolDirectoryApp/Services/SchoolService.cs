using System.Net.Http.Json;
using SchoolDirectoryApp.Models;

namespace SchoolDirectoryApp.Services
{
    public class SchoolService
    {
        private readonly HttpClient _httpClient;

        public SchoolService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<School>?> GetSchoolsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<School>>(
                "https://edutots.net/api/school"
            );
        }
    }
}