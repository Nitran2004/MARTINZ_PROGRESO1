using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MZ_PROGRESO1.Models;

namespace MZ_PROGRESO1.Data
{
    public class MZ_PROGRESO1Context : DbContext
    {
        public MZ_PROGRESO1Context (DbContextOptions<MZ_PROGRESO1Context> options)
            : base(options)
        {
        }

        public DbSet<MZ_PROGRESO1.Models.ZUMARRAGA> ZUMARRAGA { get; set; } = default!;
    }
}
