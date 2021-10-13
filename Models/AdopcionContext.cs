using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PC03_Simulacro.Models;

namespace efdemo.Models
{
    public class AdopcionContext : DbContext
    {
        public DbSet<SolicitudCompra> SolicitudesCompra { get; set; }
        public AdopcionContext(DbContextOptions dco) : base(dco) {

        }
    }
}