namespace ProjetoFinalEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        DataNascimento = c.DateTime(nullable: false),
                        RG = c.String(nullable: false, maxLength: 20),
                        CPF = c.String(nullable: false, maxLength: 14),
                        Celular = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClienteVeiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        VeiculoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Veiculo", t => t.VeiculoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.VeiculoId);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Placa = c.String(nullable: false, maxLength: 20),
                        Celular = c.String(nullable: false, maxLength: 20),
                        TipoVeiculoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoVeiculo", t => t.TipoVeiculoId, cascadeDelete: true)
                .Index(t => t.TipoVeiculoId);
            
            CreateTable(
                "dbo.RegistroEntradaSaida",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoraEntrada = c.DateTime(nullable: false),
                        HoraSaida = c.DateTime(),
                        VeiculoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Veiculo", t => t.VeiculoId, cascadeDelete: true)
                .Index(t => t.VeiculoId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Senha = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoVeiculo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculo = c.String(nullable: false, maxLength: 30),
                        ValorHora = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.TipoVeiculo, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculo", "TipoVeiculoId", "dbo.TipoVeiculo");
            DropForeignKey("dbo.RegistroEntradaSaida", "VeiculoId", "dbo.Veiculo");
            DropForeignKey("dbo.RegistroEntradaSaida", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.ClienteVeiculo", "VeiculoId", "dbo.Veiculo");
            DropForeignKey("dbo.ClienteVeiculo", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.TipoVeiculo", new[] { "TipoVeiculo" });
            DropIndex("dbo.RegistroEntradaSaida", new[] { "UsuarioId" });
            DropIndex("dbo.RegistroEntradaSaida", new[] { "VeiculoId" });
            DropIndex("dbo.Veiculo", new[] { "TipoVeiculoId" });
            DropIndex("dbo.ClienteVeiculo", new[] { "VeiculoId" });
            DropIndex("dbo.ClienteVeiculo", new[] { "ClienteId" });
            DropTable("dbo.TipoVeiculo");
            DropTable("dbo.Usuario");
            DropTable("dbo.RegistroEntradaSaida");
            DropTable("dbo.Veiculo");
            DropTable("dbo.ClienteVeiculo");
            DropTable("dbo.Cliente");
        }
    }
}
