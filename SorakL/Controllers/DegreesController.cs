using Microsoft.AspNetCore.Mvc;
using SorakL.Services;
using SorakL.Models;
using SorakL.Constants;

namespace SorakL.Controllers
{
    /// <summary>
    /// Handles requests related to academic degree programs offered by the iSchool.
    /// Provides actions for both undergraduate and graduate degree listings.
    /// </summary>
    public class DegreesController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Injects the ApiService for retrieving degree data.
        /// </summary>
        public DegreesController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Loads undergraduate degree data from the API and displays it.
        /// </summary>
        public async Task<IActionResult> Undergraduate()
        {
            // Fetch undergraduate degrees from the API
            var result = await _apiService.GetModelAsync<UndergraduateDegreesResponse>(ApiEndpoints.Undergrad);
            
            // Pass the degree list to the view
            return View(result?.undergraduate);
        }

        /// <summary>
        /// Loads graduate degree data from the API and displays it.
        /// </summary>
        public async Task<IActionResult> Graduate()
        {
            // Fetch graduate degrees from the API
            var result = await _apiService.GetModelAsync<GraduateDegreesResponse>(ApiEndpoints.Graduate);

            // Pass the degree list to the view
            return View(result?.graduate);
        }
    }
}
