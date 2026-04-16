namespace SorakL.Services
{
    /// <summary>
    /// Provides helper methods for making HTTP requests to the iSchool API.
    /// Handles JSON deserialization into strongly typed models.
    /// </summary>
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Injects an HttpClient instance used for sending requests.
        /// </summary>
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Sends a GET request to the specified URI and deserializes the JSON response.
        /// </summary>
        /// <typeparam name="T">The model type to deserialize into.</typeparam>
        /// <param name="uri">The API endpoint URL.</param>
        /// <returns>A deserialized model of type T, or null if the request fails.</returns>
        public async Task<T?> GetModelAsync<T>(string uri)
        {
            return await _httpClient.GetFromJsonAsync<T>(uri);
        }
    }
}
