using InitPrototype.DataAccess.Models.Generic;

namespace InitPrototype.DataAccess.Models
{
    public class Entry : BusinessEntity
    {
        public int EntryId { get; set; }
        public ContestantAccount ContestantAccount { get; set; }
        public int ContestantAccountId { get; set; }
        
    }
}