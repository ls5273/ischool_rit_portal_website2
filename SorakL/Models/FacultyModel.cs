namespace SorakL.Models
{
    /// <summary>
    /// Root response object returned by the Faculty API.
    /// </summary>
    public class FacultyResponse
    {
        /// <summary>
        /// List of all faculty members returned by the API.
        /// </summary>
        public List<FacultyModel>? Faculty { get; set; }
    }

    /// <summary>
    /// Represents a single faculty member and their profile information.
    /// </summary>
    public class FacultyModel
    {
        public string? Username { get; set; }
        public string? Name { get; set; }
        public string? Tagline { get; set; }
        public string? ImagePath { get; set; }
        public string? Title { get; set; }
        public string? InterestArea { get; set; }
        public string? Office { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
