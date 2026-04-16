namespace SorakL.Models
{
    /// <summary>
    /// Root response object returned by the Undergraduate Degrees API.
    /// </summary>
    public class UndergraduateDegreesResponse
    {
        /// <summary>
        /// List of undergraduate degree programs returned by the API.
        /// </summary>
        public List<UndergraduateModel>? undergraduate { get; set; }
    }

    /// <summary>
    /// Represents a single undergraduate degree program offered by the iSchool.
    /// </summary>
    public class UndergraduateModel
    {
        public string? degreeName { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public List<string>? concentrations { get; set; }
    }
}