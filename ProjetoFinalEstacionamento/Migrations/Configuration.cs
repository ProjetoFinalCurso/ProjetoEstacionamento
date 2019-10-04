namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoFinalEstacionamento.Contexto.BaseContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjetoFinalEstacionamento.Contexto.BaseContexto";
        }

        protected override void Seed(ProjetoFinalEstacionamento.Contexto.BaseContexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
