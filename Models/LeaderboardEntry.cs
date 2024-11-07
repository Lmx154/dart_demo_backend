namespace MyBackend.Models
{
    public class LeaderboardEntry
    {
        public int PlayerId { get; set; }
        public required string Username { get; set; }
        public int PlayerScore { get; set; }
    }
}
