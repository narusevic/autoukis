namespace Autoukis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Daviklis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BaterijosLygis = c.Double(nullable: false),
                        Prieinamumas = c.Boolean(nullable: false),
                        TechninePriemone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TechninePriemone", t => t.TechninePriemone_Id)
                .Index(t => t.TechninePriemone_Id);
            
            CreateTable(
                "dbo.TechninePriemone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position_Id = c.Int(),
                        Uzklausa_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pozicija", t => t.Position_Id)
                .ForeignKey("dbo.Uzklausa", t => t.Uzklausa_Id)
                .Index(t => t.Position_Id)
                .Index(t => t.Uzklausa_Id);
            
            CreateTable(
                "dbo.Pozicija",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        X = c.Double(nullable: false),
                        Y = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dronas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BaterijosLygis = c.Double(nullable: false),
                        Prieinamumas = c.Boolean(nullable: false),
                        TechninePriemone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TechninePriemone", t => t.TechninePriemone_Id)
                .Index(t => t.TechninePriemone_Id);
            
            CreateTable(
                "dbo.Gyvulys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Svoris = c.Double(nullable: false),
                        Aukstis = c.Double(nullable: false),
                        GimimoData = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Robotas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BaterijosLygis = c.Double(nullable: false),
                        Prieinamumas = c.Boolean(nullable: false),
                        TechninePriemone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TechninePriemone", t => t.TechninePriemone_Id)
                .Index(t => t.TechninePriemone_Id);
            
            CreateTable(
                "dbo.Sesija",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pradzia = c.DateTime(nullable: false),
                        Pabaiga = c.DateTime(nullable: false),
                        VarotojoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Signalas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LaikoLimitas = c.Int(nullable: false),
                        Laikas = c.DateTime(nullable: false),
                        TechninePriemone_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TechninePriemone", t => t.TechninePriemone_Id)
                .Index(t => t.TechninePriemone_Id);
            
            CreateTable(
                "dbo.Uzklausa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Siuntejas_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sesija", t => t.Siuntejas_Id)
                .Index(t => t.Siuntejas_Id);
            
            CreateTable(
                "dbo.ZemesPlotas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RugstingumoLygis = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechninePriemone", "Uzklausa_Id", "dbo.Uzklausa");
            DropForeignKey("dbo.Uzklausa", "Siuntejas_Id", "dbo.Sesija");
            DropForeignKey("dbo.Signalas", "TechninePriemone_Id", "dbo.TechninePriemone");
            DropForeignKey("dbo.Robotas", "TechninePriemone_Id", "dbo.TechninePriemone");
            DropForeignKey("dbo.Dronas", "TechninePriemone_Id", "dbo.TechninePriemone");
            DropForeignKey("dbo.Daviklis", "TechninePriemone_Id", "dbo.TechninePriemone");
            DropForeignKey("dbo.TechninePriemone", "Position_Id", "dbo.Pozicija");
            DropIndex("dbo.Uzklausa", new[] { "Siuntejas_Id" });
            DropIndex("dbo.Signalas", new[] { "TechninePriemone_Id" });
            DropIndex("dbo.Robotas", new[] { "TechninePriemone_Id" });
            DropIndex("dbo.Dronas", new[] { "TechninePriemone_Id" });
            DropIndex("dbo.TechninePriemone", new[] { "Uzklausa_Id" });
            DropIndex("dbo.TechninePriemone", new[] { "Position_Id" });
            DropIndex("dbo.Daviklis", new[] { "TechninePriemone_Id" });
            DropTable("dbo.ZemesPlotas");
            DropTable("dbo.Uzklausa");
            DropTable("dbo.Signalas");
            DropTable("dbo.Sesija");
            DropTable("dbo.Robotas");
            DropTable("dbo.Gyvulys");
            DropTable("dbo.Dronas");
            DropTable("dbo.Pozicija");
            DropTable("dbo.TechninePriemone");
            DropTable("dbo.Daviklis");
        }
    }
}
