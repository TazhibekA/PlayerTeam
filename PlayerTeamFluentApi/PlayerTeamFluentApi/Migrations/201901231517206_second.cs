namespace PlayerTeamFluentApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Name", c => c.String());
            DropColumn("dbo.Players", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Players", "FullName", c => c.String());
            DropColumn("dbo.Players", "Name");
        }
    }
}
