using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PatientPortal.Models;

namespace PatientPortal.Data
{
    public class PatientPortalContext : DbContext
    {
        public PatientPortalContext (DbContextOptions<PatientPortalContext> options)
            : base(options)
        {
        }

        public DbSet<PatientPortal.Models.Patient> Patient { get; set; }

        public DbSet<PatientPortal.Models.Referral> Referral { get; set; }
    }
}
