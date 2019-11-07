using System;
using DataAccess.Models.Generic;

namespace DataAccess.Models
{
    public class Phase : BusinessEntity
    {
        public int PhaseId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Contest Contest { get; set; }
    }
}