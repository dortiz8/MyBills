namespace MyBills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CostTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CostTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Label = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Bills", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bills", "Name", c => c.String());
            DropTable("dbo.CostTypes");
        }
    }
}
