namespace DataAccess.Models.BusinessEntities
{
    public class Contestant
    {
        public int ContestantId { get; set; }
        public User User { get; set; }
    }
}