namespace SorakL.Models
{
    /// <summary>
    /// Root response object returned by the Employment API.
    /// </summary>
    public class EmploymentResponse
    {
        public EmploymentTable? employmentTable { get; set; }
    }

    /// <summary>
    /// Represents the table structure containing professional employment data.
    /// </summary>
    public class EmploymentTable
    {
        public string? title { get; set; }
        public List<EmploymentModel>? professionalEmploymentInformation { get; set; }
    }

    /// <summary>
    /// Represents a single professional employment record.
    /// </summary>
    public class EmploymentModel
    {
        public string? employer { get; set; }
        public string? degree { get; set; }
        public string? city { get; set; }
        public string? title { get; set; }
        public string? startDate { get; set; }
    }
}
