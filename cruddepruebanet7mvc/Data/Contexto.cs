using cruddepruebanet7mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace cruddepruebanet7mvc.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>opciones):base(opciones)
        { 
        }
        
        //MODELOS
        public DbSet<Contacto> Contacto { get; set; }

    }
}
