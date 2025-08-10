using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Traveler
{
    public class Traveler
    {
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string Revision { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<TravelerOperation> Operations { get; set; } = new List<TravelerOperation>();
    }
}