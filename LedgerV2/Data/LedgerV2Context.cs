using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LedgerV2.Model;

namespace LedgerV2.Data
{
    public class LedgerV2Context : DbContext
    {
        public LedgerV2Context (DbContextOptions<LedgerV2Context> options)
            : base(options)
        {
        }

        public DbSet<LedgerV2.Model.Ledger> Ledger { get; set; } = default!;
        public DbSet<LedgerV2.Model.User> User { get; set; } = default!;
    }
}
