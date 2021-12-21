namespace MyBills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Label) VALUES (1, 'Utilities')");
            Sql("INSERT INTO Categories (Id, Label) VALUES (2, 'Food')");
            Sql("INSERT INTO Categories (Id, Label) VALUES (3, 'Insurance')");
            Sql("INSERT INTO Categories (Id, Label) VALUES (4, 'Housing')");
            Sql("INSERT INTO Categories (Id, Label) VALUES (5, 'Transportation')");
            Sql("INSERT INTO Categories (Id, Label) VALUES (6, 'Misc')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE Id IN (1, 2, 3, 4, 5, 6)");
        }
    }
}
