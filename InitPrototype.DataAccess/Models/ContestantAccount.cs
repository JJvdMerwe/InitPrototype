using System.Collections.Generic;

namespace InitPrototype.DataAccess.Models
{
    public class ContestantAccount
    {
        public int ContestantAccountId { get; set; }
        public User User { get; set; }
        public Contest Contest { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}