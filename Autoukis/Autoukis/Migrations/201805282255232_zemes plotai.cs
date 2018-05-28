namespace Autoukis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zemesplotai : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ZemesPlotas", "Pozicija1_Id", c => c.Int());
            AddColumn("dbo.ZemesPlotas", "Pozicija2_Id", c => c.Int());
            AddColumn("dbo.ZemesPlotas", "Pozicija3_Id", c => c.Int());
            AddColumn("dbo.ZemesPlotas", "Pozicija4_Id", c => c.Int());
            CreateIndex("dbo.ZemesPlotas", "Pozicija1_Id");
            CreateIndex("dbo.ZemesPlotas", "Pozicija2_Id");
            CreateIndex("dbo.ZemesPlotas", "Pozicija3_Id");
            CreateIndex("dbo.ZemesPlotas", "Pozicija4_Id");
            AddForeignKey("dbo.ZemesPlotas", "Pozicija1_Id", "dbo.Pozicija", "Id");
            AddForeignKey("dbo.ZemesPlotas", "Pozicija2_Id", "dbo.Pozicija", "Id");
            AddForeignKey("dbo.ZemesPlotas", "Pozicija3_Id", "dbo.Pozicija", "Id");
            AddForeignKey("dbo.ZemesPlotas", "Pozicija4_Id", "dbo.Pozicija", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZemesPlotas", "Pozicija4_Id", "dbo.Pozicija");
            DropForeignKey("dbo.ZemesPlotas", "Pozicija3_Id", "dbo.Pozicija");
            DropForeignKey("dbo.ZemesPlotas", "Pozicija2_Id", "dbo.Pozicija");
            DropForeignKey("dbo.ZemesPlotas", "Pozicija1_Id", "dbo.Pozicija");
            DropIndex("dbo.ZemesPlotas", new[] { "Pozicija4_Id" });
            DropIndex("dbo.ZemesPlotas", new[] { "Pozicija3_Id" });
            DropIndex("dbo.ZemesPlotas", new[] { "Pozicija2_Id" });
            DropIndex("dbo.ZemesPlotas", new[] { "Pozicija1_Id" });
            DropColumn("dbo.ZemesPlotas", "Pozicija4_Id");
            DropColumn("dbo.ZemesPlotas", "Pozicija3_Id");
            DropColumn("dbo.ZemesPlotas", "Pozicija2_Id");
            DropColumn("dbo.ZemesPlotas", "Pozicija1_Id");
        }
    }
}
