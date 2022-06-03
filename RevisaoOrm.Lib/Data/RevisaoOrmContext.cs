using Microsoft.EntityFrameworkCore;
using revisaoOrm.Classes;

namespace RevisaoOrm.Lib.Data
{
    public class RevisaoOrmContext : DbContext
    {
        public RevisaoOrmContext(DbContext context) : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedidos>().ToTable("Pedidos");
            modelBuilder.Entity<Pedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<Pedidos>().HasOne(x => x.Transportadora).WithMany(x => x.Pedidos).HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Pedidos>().HasOne(x => x.Usuario).WithMany(x => x.PegarPedidos).HasForeignKey(x => x.IdUsuario);
            modelBuilder.Entity<Pedidos>().HasMany(x => x.Produtos_X_Pedidos).WithOne(x => x.Pedido);

            modelBuilder.Entity<Produtos>().ToTable("Produtos");
            modelBuilder.Entity<Produtos>().HasKey(key => key.Id);
            modelBuilder.Entity<Produtos>().HasOne(x => x.Vendedor).WithMany(x => x.ListaProdutos).HasForeignKey(x => x.IdVendedor);

            modelBuilder.Entity<Produtos_X_Pedidos>().ToTable("Produtos_X_Pedidos");
            modelBuilder.Entity<Produtos_X_Pedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<Produtos_X_Pedidos>().HasOne(x => x.Produto).WithMany(x => x.Produtos_X_Pedidos).HasForeignKey(x => x.IdProduto);
                                                                                                       
            modelBuilder.Entity<Produtos_X_Pedidos>().ToTable("Produtos_X_Pedidos");
            modelBuilder.Entity<Produtos_X_Pedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<Produtos_X_Pedidos>().HasOne(x => x.Pedido).WithMany(x => x.Produtos_X_Pedidos).HasForeignKey(x => x.IdPedido);                                       

            modelBuilder.Entity<Transportadores>().ToTable("Transportadores");
            modelBuilder.Entity<Transportadores>().HasKey(key => key.Id);
            modelBuilder.Entity<Transportadores>().HasMany(x => x.Pedidos).WithOne(x => x.Transportadora);

            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Usuarios>().HasKey(key => key.Id);
            modelBuilder.Entity<Usuarios>().HasMany(x => x.PegarPedidos).WithOne(x => x.Usuario);

            modelBuilder.Entity<Vendedores>().ToTable("Vendedores");
            modelBuilder.Entity<Vendedores>().HasKey(key => key.Id);
            modelBuilder.Entity<Vendedores>().HasMany(x => x.ListaProdutos).WithOne(x => x.Vendedor);
        }

        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Transportadores> Transportadores { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Produtos_X_Pedidos> Produtos_X_Pedidos { get; set; }
    }
}