namespace BartenderApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cocktails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CocktailName = c.String(),
                        OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(),
                        CocktailId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cocktails", t => t.CocktailId)
                .Index(t => t.CocktailId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderedBy = c.String(),
                        OrderTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cocktails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Ingredients", "CocktailId", "dbo.Cocktails");
            DropIndex("dbo.Ingredients", new[] { "CocktailId" });
            DropIndex("dbo.Cocktails", new[] { "OrderId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Cocktails");
        }
    }
}
