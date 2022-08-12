using Collection.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Collection.Data;

public class CollectionContext : DbContext {
   public DbSet<Artist> Artists { get; set; }
      public DbSet<Album> Albums { get; set; }

        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options) {

   }

}