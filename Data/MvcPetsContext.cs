using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetcoApp.Models;

    public class MvcPetsContext : DbContext
    {
        public MvcPetsContext (DbContextOptions<MvcPetsContext> options)
            : base(options)
        {
        }

        public DbSet<PetcoApp.Models.Pets> Pets { get; set; }

        public DbSet<PetcoApp.Models.Tipo> Tipo { get; set; }

        public DbSet<PetcoApp.Models.Cadastro> Cadastro { get; set; }
    }
