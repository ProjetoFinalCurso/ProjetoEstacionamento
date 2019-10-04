namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColunaDesconto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RegistroEntradaSaida", "Desconto", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RegistroEntradaSaida", "Desconto");
        }
    }
}
