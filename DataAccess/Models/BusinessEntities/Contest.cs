using System.Collections.Generic;
using InitPrototype.DataAccess.Models.Generic;

namespace InitPrototype.DataAccess.Models
{
    public class Contest : BusinessEntity
    {
        public int ContestId { get; set; }
        public Provider Provider { get; set; }
        public virtual ICollection<ContestantAccount> ContestantAccounts { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }
    }
}