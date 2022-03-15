#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab1_DataAnnotations_Hotel.Models;

namespace Lab1_DataAnnotations_Hotel.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext (DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public DbSet<Lab1_DataAnnotations_Hotel.Models.Client> Client { get; set; }
        public DbSet<Lab1_DataAnnotations_Hotel.Models.Room> Room { get; set; }
    }
}
