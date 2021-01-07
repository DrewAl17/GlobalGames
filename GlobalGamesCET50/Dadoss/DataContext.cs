using GlobalGamesCET50.Dadoss.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Dadoss
{
    public class DataContext : DbContext
    {
        public DbSet<Servicos> Servicos { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
