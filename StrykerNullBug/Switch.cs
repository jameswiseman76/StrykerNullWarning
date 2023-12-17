using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrykerNullBug
{
    public class Switch
    {
        public Guid Id { get; set; }

        public string AccountNumber { get; set; }

        public string IncrementNumber { get; set; }

        public DateTime EffectiveDate { get; set; }
    }
}
