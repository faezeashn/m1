namespace MVCProject1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class va : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CountryId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        CountryId = c.Int(),
                        BrandName = c.String(),
                        ModelNo = c.String(),
                        CompanyId = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Countries", t => t.CountryId)
                .Index(t => t.CategoryId)
                .Index(t => t.CountryId)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Products", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Companies", "CountryId", "dbo.Countries");
            DropIndex("dbo.Products", new[] { "CompanyId" });
            DropIndex("dbo.Products", new[] { "CountryId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Companies", new[] { "CountryId" });
            DropTable("dbo.Products");
            DropTable("dbo.Countries");
            DropTable("dbo.Companies");
            DropTable("dbo.Categories");
        }
    }
}
