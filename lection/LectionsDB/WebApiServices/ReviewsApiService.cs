using Lection0606.Models;
using System.Net.Http.Json;

namespace WebApiServices
{
    public class ReviewsApiService(HttpClient client)
    {
        private readonly HttpClient _client = client;

        public async Task<IEnumerable<Review>?> GetReviewsAsync()
            => await _client.GetFromJsonAsync<IEnumerable<Review>>("reviews");

        public async Task<Review?> GetReviewAsync(int id)
            => await _client.GetFromJsonAsync<Review?>($"reviews/{id}");

        public async Task CreateReviewAsync(Review review)
        {
            var response = await _client.PostAsJsonAsync($"reviews/{review.Id}", review);
            response.EnsureSuccessStatusCode();
        }
        public async Task UpdateReviewAsync(Review review)
        {
            var response = await _client.PutAsJsonAsync($"reviews/{review.Id}", review);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteReviewAsync(int id)
        {
            var response = await _client.DeleteAsync($"reviews/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
