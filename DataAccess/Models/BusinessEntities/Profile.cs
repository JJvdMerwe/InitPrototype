using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class Profile : BusinessEntity
    {
        public int ProfileId { get; set; }
        public User User { get; set; }
        public string DisplayName { get; set; }
    }
}