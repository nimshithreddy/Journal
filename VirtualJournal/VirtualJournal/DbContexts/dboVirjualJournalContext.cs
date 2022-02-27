using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirtualJournal.Models;

namespace VirtualJournal.DbContexts
{
    public class dboVirjualJournalContext : DbContext
    {
        public DbSet<Registration> RegistrationData { get; set; }
        public dboVirjualJournalContext(DbContextOptions<dboVirjualJournalContext> options) : base(options)
        {
        }
    }
}
