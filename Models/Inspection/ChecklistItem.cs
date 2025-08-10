using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using backend.Dtos;

namespace backend.Models.Inspection
{
    public class ChecklistItem
    {
        public string Id { get; set; }
        public string Characteristic { get; set; }
        public string FeatureName { get; set; }
        public double NominalValue { get; set; }
        public double UpperTolerance { get; set; }
        public double LowerTolerance { get; set; }
        public string Unit { get; set; }
        public string Measurement { get; set; }
        public string MeasurementType { get; set; }
        public string Gage { get; set; }
        public MeasurementStatus MeasurementStatus { get; set; }
        public string Comment { get; set; }
        public string ChecklistId { get; set; }
        public Checklist Checklist { get; set; }

    }
}
