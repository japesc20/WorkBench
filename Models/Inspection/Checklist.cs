using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Inspection
{
    public class Checklist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PartNumber { get; set; }
        public string PartRevision { get; set; }
        public string Operation { get; set; }
        public DateTime Timestamp { get; set; }
        public string InspectorID { get; set; }
        // public List<ChecklistItemCreate> Items { get; set; }
        public ICollection<ChecklistItem> Items { get; set; } = new List<ChecklistItem>();

    }
}