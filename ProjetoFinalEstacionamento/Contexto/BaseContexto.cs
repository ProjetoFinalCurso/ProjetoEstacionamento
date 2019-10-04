using ProjetoFinalEstacionamento.Modelo;
using System.Data.Entity;

namespace ProjetoFinalEstacionamento.Contexto
{
    public class BaseContexto : DbContext
    {
        public BaseContexto() : base("name=Conexao")
        {
            base.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<TipoVeiculoModel> TipoVeiculo { get; set; }
        public DbSet<VeiculoModel> Veiculo { get; set; }
        public DbSet<RegistroEntradaSaidaModel> RegistroEntradaSaida { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ClienteVeiculoModel> ClienteVeiculo { get; set; }

    }
}
