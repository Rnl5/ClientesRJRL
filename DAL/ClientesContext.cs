using ClientesRJRL.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesRJRL.DAL;

public class ClientesContext : DbContext
{
    public ClientesContext(DbContextOptions<ClientesContext> options) : base(options) { }

    public DbSet<Clientes> Clientes {get; set;}
}