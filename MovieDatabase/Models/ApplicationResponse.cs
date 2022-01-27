namespace MovieDatabase.Models
{
    internal class ApplicationResponse
    {
        public int ApplicationID { get; internal set; }
        public string Category { get; internal set; }
        public string Title { get; internal set; }
        public int Year { get; internal set; }
        public string Director { get; internal set; }
        public string Rating { get; internal set; }
    }
}