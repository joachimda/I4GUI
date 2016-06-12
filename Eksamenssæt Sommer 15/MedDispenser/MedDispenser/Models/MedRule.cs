using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedDispenser.Models
{
    public class MedRule
    {
        public string MedicineType { get; set; }
        public string Comment { get; set; }
        public string TimeToTake { get; set; }
    }
}