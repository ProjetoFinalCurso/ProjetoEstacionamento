namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNomeTabelaVeiculo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Veiculo", "Nome");
            DropColumn("dbo.Veiculo", "Celular");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Veiculo", "Celular", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Veiculo", "Nome", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
