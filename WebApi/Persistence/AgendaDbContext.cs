using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class AgendaDbContext : DbContext
    {
        public DbSet<Agenda> Agenda { get; set; }
        public AgendaDbContext(DbContextOptions<AgendaDbContext> options)
            : base(options)
        { }
    }
}
