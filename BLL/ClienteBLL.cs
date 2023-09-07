using ClientesRJRL.DAL;
using ClientesRJRL.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesRJRL.BLL;

public class ClienteBLL{
    private readonly ClientesContext _context;

    public ClienteBLL(ClientesContext context){
        _context = context;
    }

    public bool YaExiste(int ClienteId){
        return _context.Clientes.Any(c => c.ClienteId == ClienteId);
    }

    public bool Insertar(Clientes cliente)
    {
        _context.Clientes.Add(cliente);
        return _context.SaveChanges() > 0;
    }

    public bool Modificar(Clientes cliente){
        _context.Entry(cliente).State = EntityState.Modified;
        return _context.SaveChanges() > 0;
    }

    public bool Guardar(Clientes cliente){
        if(!YaExiste(cliente.ClienteId))
        {
            return this.Insertar(cliente);
        }
        else
        {
            return this.Modificar(cliente);
        }
    }

    public bool Eliminar(Clientes cliente)
    {
        _context.Entry(cliente).State = EntityState.Deleted;
        return _context.SaveChanges() > 0;
    }

    public Clientes? Buscar(int ClienteId)
    {
        return _context.Clientes
            .Where(c => c.ClienteId == ClienteId)
            .AsNoTracking()
            .SingleOrDefault();
    }

    public List<Clientes> GetClientes()
    {
        return _context.Clientes
            .AsNoTracking()
            .ToList();
    }


}