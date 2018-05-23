namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_MembershipTypeModel : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes set Name='PayAsYouGo' where Id=1");
            Sql("update MembershipTypes set Name='Monthly' where Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
