using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trabalho_Daniel_5_Termo.Models;

namespace Trabalho_Daniel_5_Termo.Data
{
    public class datacontext : DbContext
    {
        public datacontext(DbContextOptions<datacontext> options):base(options)
        {
            
        }
        public DbSet<Carros> Carros { get; set; }

        public DbSet<Marca> Marcas { get; set; }
    }
}
