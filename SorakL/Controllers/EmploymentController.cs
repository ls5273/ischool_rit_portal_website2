using Microsoft.AspNetCore.Mvc;
using SorakL.Services;
using SorakL.Constants;
using SorakL.Models;

namespace SorakL.Controllers
{
    /// <summary>
    /// Handles requests for employment-related information such as
    /// co-op placements and full-time employment statistics.
    /// </summary>
    public class EmploymentController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Constructor that injects the ApiService.
        /// </summary>
        public EmploymentController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Loads the co-op employment table from the API and returns it to the view.
        /// </summary>
        public async Task<IActionResult> Coop()
        {
            // Retrieve the wrapper containing the coopTable list
            var result = await _apiService.GetModelAsync<CoopResponse>(ApiEndpoints.Coop);

            // Pass only the coopTable list to the view
            return View(result?.coopTable?.coopInformation);
        }

        /// <summary>
        /// Loads the professional employment table from the API and displays it.
        /// </summary>
        public async Task<IActionResult> Employment()
        {
            // Fetch the wrapper object that contains the professional employment data.
            var result = await _apiService.GetModelAsync<EmploymentResponse>(ApiEndpoints.Employment);

            // Pass the inner list to the view.
            return View(result?.employmentTable?.professionalEmploymentInformation);
        }
    }
}
