namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlacaModelo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Veiculo", "Placa", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Veiculo", "Placa", c => c.String(maxLength: 100));
        }
    }
}
