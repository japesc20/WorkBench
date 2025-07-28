using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class ChecklistItemCreate
    {
        public string Characteristic { get; set; }
        public double UpperTolerance { get; set; }
        public double LowerTolerance { get; set; }
        public string Measurement { get; set; }
        public string Gage { get; set; }
        public MeasurementStatus MeasurementStatus { get; set; }
        public string Comment { get; set; }
    }
}