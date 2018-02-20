using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Entidades
{
    public class Context :DbContext
    {
      
        public DbSet<Banco> Bancos { get; set; }
       
        private static IConfigurationRoot Configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FTVDIB4\\WESKLEYSQL;Database=dbLP2;User Id=sa;Password=123456");
        }
    }
}

