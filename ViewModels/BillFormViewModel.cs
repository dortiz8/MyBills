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
        public string Name { get; set; }
        [Required]
        public double Cost { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        //Records set or fluid (changing month/m) cost
        public int Type { get; set; }
        public int Category { get; set; }
        public IEnumerable<Models.Category> Categories { get; set; }
        public IEnumerable<Models.CostType> CostTypes { get; set; }

    }
}