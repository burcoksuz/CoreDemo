using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRayting
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int TotalScore { get; set; }
        public int RaytingCount { get; set; }
    }
}
