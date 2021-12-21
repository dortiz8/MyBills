namespace MyBills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bills", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Bills", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "Category");
            DropColumn("dbo.Bills", "Type");
            DropTable("dbo.Categories");
        }
    }
}
