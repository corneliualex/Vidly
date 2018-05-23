namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_CustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Bitrhdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Bitrhdate");
        }
    }
}
