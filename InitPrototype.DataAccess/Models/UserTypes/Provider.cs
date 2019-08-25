using InitPrototype.DataAccess.Models.Generic;

namespace InitPrototype.DataAccess.Models
{
    public class Provider : BusinessEntity
    {
        public int ProviderId { get; set; }
        public User User { get; set; }
    }
}