using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Gruppe1_Assignment_1_F22.DB
{
    public partial class Gruppe1_DebtBookContext : DbContext
    {
        public Gruppe1_DebtBookContext()
        {
        }

        public Gruppe1_DebtBookContext(DbContextOptions<Gruppe1_DebtBookContext> options)
            : base(options)
        {
        }        
    }
}

