using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class FeedsAndSpeedsRequest
    {
        public double SFM { get; set; }
        public double ToolDiameter { get; set; }
        public double ChipLoad { get; set; }
        public int Flutes { get; set; }
    }
}