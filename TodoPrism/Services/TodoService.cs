using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TodoPrism.Models;

namespace TodoPrism.Services {
    public class TodoService {
        private async Task<T> GetAsync<T>(Uri uri) {
            using (var client = new HttpClient()) {
                var response = await client.GetAsync(uri);
                var json = await response.Content.ReadAsStringAsync();
                T result = JsonConvert.DeserializeObject<T>(json);
                return result;
            }
        }

        //https://bmetodoservice.azurewebsites.net

        //API-tól kérjük le a TODO elemek listáját.
        private readonly Uri _serverUrl = new Uri("https://bmetodoservice.azurewebsites.net");
        public async Task<List<TodoItem>> GetTodosAsync() {
            return await GetAsync<List<TodoItem>>(new Uri(_serverUrl, "api/Todo"));
        }
    }
}
