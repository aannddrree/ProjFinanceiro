using Microsoft.EntityFrameworkCore;
using ProjFinanceiro.Models;

namespace ProjFinanceiro.Dal
{
    public class FinanceiroContext : DbContext
    {
        public FinanceiroContext(DbContextOptions<FinanceiroContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ContaCorrente> ContaCorrente { get; set; }
    }
}