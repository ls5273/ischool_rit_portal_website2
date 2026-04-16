namespace SorakL.Models
{
    /// <summary>
    /// Root response object returned by the Co-op API.
    /// </summary>
    public class CoopResponse
    {
        /// <summary>
        /// Wrapper containing the full Co-op table data.
        /// </summary>
        public CoopTable? coopTable { get; set; }
    }

    /// <summary>
    /// Represents the table structure containing Co-op data.
    /// </summary>
    public class CoopTable
    {
        /// <summary>
        /// Title of the Co-op data section.
        /// </summary>
        public string? title { get; set; }

        /// <summary>
        /// List of Co-op placement records.
        /// </summary>
        public List<CoopModel>? coopInformation { get; set; }
    }

    /// <summary>
    /// Represents a single Co-op placement entry.
    /// </summary>
    public class CoopModel
    {
        public string? Employer { get; set; }
        public string? Degree { get; set; }
        public string? City { get; set; }
        public string? Term { get; set; }
    }
}
