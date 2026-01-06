using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Udrea_Carina_Lab2.Models;

namespace Udrea_Carina_Lab2.Data
{
    public class Udrea_Carina_Lab2Context : DbContext
    {
        public Udrea_Carina_Lab2Context (DbContextOptions<Udrea_Carina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Udrea_Carina_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Udrea_Carina_Lab2.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Udrea_Carina_Lab2.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Udrea_Carina_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
