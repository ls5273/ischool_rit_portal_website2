using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SorakL.Models;
using SorakL.Constants;
using SorakL.Services;

namespace SorakL.Controllers
{
    /// <summary>
    /// Handles requests for the home page of the application.
    /// Fetches "About" information from the iSchool API and displays it.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Constructor that injects the ApiService used for fetching remote JSON data.
        /// </summary>
        /// <param name="apiService">Service for making HTTP API requests.</param>
        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Loads the About information from the iSchool API and passes it to the Index view.
        /// </summary>
        public async Task<IActionResult> Index()
        {
            // Fetch AboutModel data asynchronously from the API.
            var response = await _apiService.GetModelAsync<AboutModel>(ApiEndpoints.About);

            // Pass the model to the view for rendering.
            return View(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        /// <summary>
        /// Displays an error page with debugging information.
        /// </summary>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
