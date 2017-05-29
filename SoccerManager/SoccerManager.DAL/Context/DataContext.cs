namespace SoccerManager.DAL.Context
{
    using Configurations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClubeConfig());
            modelBuilder.Configurations.Add(new FormacaoTaticaConfig());
            modelBuilder.Configurations.Add(new ImagemConfig());
            modelBuilder.Configurations.Add(new JogadorConfig());
            modelBuilder.Configurations.Add(new PosicaoConfig());
            modelBuilder.Configurations.Add(new TransferenciaConfig());
        }

        public DbSet<Clube> Clubes { get; set; }
        public DbSet<FormacaoTatica> FormacoesTaticas { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }
    }
}