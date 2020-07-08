namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.compras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false),
                        clienteid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.clientes", t => t.clienteid, cascadeDelete: true)
                .Index(t => t.clienteid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.compras", "clienteid", "dbo.clientes");
            DropIndex("dbo.compras", new[] { "clienteid" });
            DropTable("dbo.compras");
        }
    }
}
