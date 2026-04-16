using Microsoft.AspNetCore.Mvc;
using SorakL.Constants;
using SorakL.Models;
using SorakL.Services;

namespace SorakL.Controllers
{
    /// <summary>
    /// Controller responsible for displaying people-related data such as faculty.
    /// </summary>
    public class PeopleController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Injects ApiService for HTTP requests.
        /// </summary>
        public PeopleController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Retrieves faculty information from the API and displays it in a view.
        /// </summary>
        public async Task<IActionResult> Faculty()
        {
            // Fetch the wrapper object returned by API
            var response = await _apiService.GetModelAsync<FacultyResponse>(ApiEndpoints.Faculty);

            // Extract the faculty list and pass it to the Faculty view
            return View(response?.Faculty);
        }
    }
}
