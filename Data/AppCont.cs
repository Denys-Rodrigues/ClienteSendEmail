using ClienteSendEmail.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteSendEmail.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
