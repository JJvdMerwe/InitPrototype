using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class Provider : BusinessEntity
    {
        public int ProviderId { get; set; }
        public User User { get; set; }
    }
}