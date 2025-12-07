namespace DotaPlayerStats.Models
{
    public class RecentMatch
    {
        public long match_id { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int duration { get; set; }
        public int hero_id { get; set; }
        public bool radiant_win { get; set; }
    }
}
