using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreTest.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Budgets = new HashSet<Budgets>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserIdentityNumber { get; set; }
        public virtual ICollection<Budgets> Budgets { get; set; }
    }
}
