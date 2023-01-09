namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "AuthorId", c => c.Int());
            CreateIndex("dbo.Headings", "AuthorId");
            AddForeignKey("dbo.Headings", "AuthorId", "dbo.Authors", "AuthorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Headings", new[] { "AuthorId" });
            DropColumn("dbo.Headings", "AuthorId");
        }
    }
}
