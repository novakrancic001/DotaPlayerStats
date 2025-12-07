namespace DotaPlayerStats.Models
{
    public class Player
    {
        public Profile profile { get; set; }
        public int? solo_competitive_rank { get; set; }
        public int? competitive_rank { get; set; }
        public int? rank_tier { get; set; }
    }

    public class Profile
    {
        public long account_id { get; set; }
        public string personaname { get; set; }
        public string avatarfull { get; set; }
        public string steamid { get; set; }
    }
}
