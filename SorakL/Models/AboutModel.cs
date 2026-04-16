namespace SorakL.Models
{
    /// <summary>
    /// Represents the About information returned by the iSchool API.
    /// </summary>
    public class AboutModel
    {
        public string? Title { get; set; }

        public string? Description { get; set; }
  
        public string? Quote { get; set; }

        public string? QuoteAuthor { get; set; }
    }
}
