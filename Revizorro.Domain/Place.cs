using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revizorro.Domain
{
    public class Place
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MainPhoto {get;set;}
        public IEnumerable<string> GalleryPhotos { get; set; }
        public float Rating { get; set; }
    }
}
