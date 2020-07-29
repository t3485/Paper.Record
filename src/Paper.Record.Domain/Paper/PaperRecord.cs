using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Paper.Record.Paper
{
    public class PaperRecord : AggregateRoot<int>
    {
        public string Code { get; set; }
        public string Content { get; set; }
        public string CycleType { get; set; }
    }
}
