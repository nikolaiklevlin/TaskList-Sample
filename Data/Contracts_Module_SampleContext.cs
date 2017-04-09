using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contracts_Module_Sample.Models;

namespace Contracts_Module_Sample.Models
{
    public class Contracts_Module_SampleContext : DbContext
    {
        public Contracts_Module_SampleContext (DbContextOptions<Contracts_Module_SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Contracts_Module_Sample.Models.Contract> Contract { get; set; }

        public DbSet<Contracts_Module_Sample.Models.Contractor> Contractor { get; set; }

        public DbSet<Contracts_Module_Sample.Models.CMSTask> Task { get; set; }

        public DbSet<Contracts_Module_Sample.Models.Attachment> Attachment { get; set; }
    }
}
