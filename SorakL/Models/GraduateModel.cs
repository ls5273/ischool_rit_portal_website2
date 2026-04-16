namespace SorakL.Models
{
    /// <summary>
    /// Root response object returned by the Graduate Degrees API.
    /// </summary>
    public class GraduateDegreesResponse
    {
        /// <summary>
        /// List of graduate degree programs returned by the API.
        /// </summary>
        public List<GraduateModel>? graduate { get; set; }
    }

    /// <summary>
    /// Represents a single graduate degree program offered by the iSchool.
    /// </summary>
    public class GraduateModel
    {
        public string? degreeName { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }

        public List<string>? concentrations { get; set; }
        public List<string>? availableCertificates { get; set; }
    }

}
