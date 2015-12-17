namespace HRM.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class workType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkTypes", "WorkTime", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkTypes", "WorkTime", c => c.Double(nullable: false));
        }
    }
}
