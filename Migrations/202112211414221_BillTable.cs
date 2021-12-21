namespace MyBills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BillTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
