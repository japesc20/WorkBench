using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Traveler
{
    public class TravelerOperation
    {
        public string Id { get; set; }
        public string OperationNumber { get; set; }
        public string OperationName { get; set; }
        public string WorkCenter { get; set; }
        public string Instructions { get; set; }
        public string TravelerId { get; set; }
        public Traveler Traveler { get; set; }
    }
}