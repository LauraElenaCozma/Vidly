namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdateOfCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1999-06-23' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
