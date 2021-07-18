using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    public class ClientDbContext:DbContext
    {
        public ClientDbContext(DbContextOptions<ClientDbContext>options):base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    

    }
}
