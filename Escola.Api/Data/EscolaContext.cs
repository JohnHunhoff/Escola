using Escola.Api.Model;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

namespace Escola.Api.Data
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
            
        }

        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
