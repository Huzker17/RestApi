using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revizorro.Domain
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public Guid PlaceId { get; set; }
        public DateTime PostedTime { get; set; }
        public string Description { get; set; }
        public float Mark { get; set; }
    }
}
