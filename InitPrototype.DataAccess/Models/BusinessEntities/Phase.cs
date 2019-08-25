using System;
using InitPrototype.DataAccess.Models.Generic;

namespace InitPrototype.DataAccess.Models
{
    public class Phase : BusinessEntity
    {
        public int PhaseId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Contest Contest { get; set; }
    }
}