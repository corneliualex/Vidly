namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed_GenreModel : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Genres(Name) values ('Comedy'),('Action'),('Family'),('Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
