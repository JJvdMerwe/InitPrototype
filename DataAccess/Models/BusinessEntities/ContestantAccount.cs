using System.Collections.Generic;
using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class ContestantAccount : BusinessEntity
    {
        public int ContestantAccountId { get; set; }
        public User User { get; set; }
        public Contest Contest { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}