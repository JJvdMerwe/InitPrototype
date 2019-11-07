using System.Collections.Generic;
using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class Contest : BusinessEntity
    {
        public int ContestId { get; set; }
        public Provider Provider { get; set; }
        public virtual ICollection<ContestantAccount> ContestantAccounts { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }
    }
}