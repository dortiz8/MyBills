using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBills.ViewModels
{
    public class BillFormViewModel
    {
        [Required]
        public string BillName { get; set; }
        [Required]
        public double BillCost { get; set; }
        [Required]
        public DateTime BillDate { get; set; }
        [Required]
        //Records set or fluid (changing month/m) cost
        public byte BillCostType { get; set; }

        public IEnumerable<Models.CostType> BillCostTypes { get; set; }

    }
}