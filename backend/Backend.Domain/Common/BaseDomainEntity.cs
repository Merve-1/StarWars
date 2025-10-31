using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Common
{
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public DateTime Created {  get; set; }
        public DateTime Updated { get; set; }
    }
}
