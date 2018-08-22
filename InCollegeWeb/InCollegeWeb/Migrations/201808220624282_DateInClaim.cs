namespace InCollegeWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateInClaim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClaimStudents", "DateCreate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ClaimStudents", "DateCreate");
        }
    }
}
