using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

using Xunit;

namespace TestMathLibrary {
    public class TestApi {

        JsonSerializerOptions options = new JsonSerializerOptions() {
            PropertyNameCaseInsensitive = true
        };

        [Fact]
        public async void TestGetAll() {
            var http = new HttpClient();
            var json = await http.GetAsync("http://localhost:5000/api/users")
                                    .Result.Content.ReadAsStringAsync();
            var users = JsonSerializer.Deserialize<List<User>>(json, options);
            Assert.NotEmpty(users);
        }
    }
}
