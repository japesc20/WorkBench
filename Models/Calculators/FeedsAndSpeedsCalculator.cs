using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Calculators
{
    public class FeedsAndSpeedsCalculator
    {
        public string Id { get; set; }
        public string ToolMaterial { get; set; }
        public string WorkPieceMaterial { get; set; }
        public string Diameter { get; set; }
        public string SurfaceSpeed { get; set; }
        public string ChipLoad { get; set; }
        public string Flutes { get; set; }

        public double RPM { get; set; }
        public double FeedRate { get; set; }
        public DateTime CalculatedAt { get; set; }
        
    }
}