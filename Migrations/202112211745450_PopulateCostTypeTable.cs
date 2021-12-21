namespace MyBills.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCostTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CostTypes (Id, Label) VALUES (1, 'Bi-weekly')");
            Sql("INSERT INTO CostTypes (Id, Label) VALUES (2, 'Monthly')");
            Sql("INSERT INTO CostTypes (Id, Label) VALUES (3, 'Quarterly')");
            Sql("INSERT INTO CostTypes (Id, Label) VALUES (4, 'Yearly')");
            Sql("INSERT INTO CostTypes (Id, Label) VALUES (5, 'Random')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM CostTypes WHERE Id IN (1, 2, 3, 4, 5)"); 
        }
    }
}
