using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class ChecklistCreate
    {
        public string Id { get; set; }
        public string PartNumber { get; set; }
        public string PartRevision { get; set; }
        public string Operation { get; set; }
        public DateTime Timestamp { get; set; }
        public string InspectorID { get; set; }
        public List<ChecklistItemCreate> Items { get; set; }
    }
}