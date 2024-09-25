using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using danaAbadiTes.Models.Entities;

namespace danaAbadiTes.Context
{
    public class dbContext : DbContext
    {
        private readonly IConfiguration _config;

        public dbContext(DbContextOptions<dbContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<User> user { get; set; }
    }

}
