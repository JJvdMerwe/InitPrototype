using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class Entry : BusinessEntity
    {
        public int EntryId { get; set; }
        public ContestantAccount ContestantAccount { get; set; }
        public int ContestantAccountId { get; set; }
        
    }
}