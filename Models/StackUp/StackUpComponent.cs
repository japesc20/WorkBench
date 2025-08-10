using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.StackUp
{
    public class StackUpComponent
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Nominal { get; set; }
        public double UpperTolerance { get; set; }
        public double LowerTolerance { get; set; }
        public int StackUpId { get; set; }
        public StackUp StackUp { get; set; }
    }
}