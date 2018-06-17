namespace TwitterSharp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "DateJoined", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "DateJoined", c => c.DateTime(nullable: false));
        }
    }
}
