namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoVeiculoModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veiculo", "Marca", c => c.String(maxLength: 100));
            AddColumn("dbo.Veiculo", "Modelo", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Veiculo", "Cor", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Veiculo", "Placa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Veiculo", "Placa", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Veiculo", "Cor");
            DropColumn("dbo.Veiculo", "Modelo");
            DropColumn("dbo.Veiculo", "Marca");
        }
    }
}
