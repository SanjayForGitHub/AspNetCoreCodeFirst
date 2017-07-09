using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTest.Models
{
    public class Budgets
    {
        [Key]
        public int BudgetId { get; set; }
        public string Name { get; set; }
        public int BudgetOwnerIdentityNumber { get; set; }

        //[ForeignKey("BudgetOwnerIdentityNumber")]
        public virtual ApplicationUser BudgetOwner { get; set; }
    }
}
