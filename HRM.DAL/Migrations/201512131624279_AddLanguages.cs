namespace HRM.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLanguages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KnowledgeLevelTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LanguageTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Languages", "KnowledgeLevelType_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Languages", "LanguageType_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Languages", "KnowledgeLevelType_Id");
            CreateIndex("dbo.Languages", "LanguageType_Id");
            AddForeignKey("dbo.Languages", "KnowledgeLevelType_Id", "dbo.KnowledgeLevelTypes", "Id");
            AddForeignKey("dbo.Languages", "LanguageType_Id", "dbo.LanguageTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Languages", "LanguageType_Id", "dbo.LanguageTypes");
            DropForeignKey("dbo.Languages", "KnowledgeLevelType_Id", "dbo.KnowledgeLevelTypes");
            DropIndex("dbo.Languages", new[] { "LanguageType_Id" });
            DropIndex("dbo.Languages", new[] { "KnowledgeLevelType_Id" });
            DropColumn("dbo.Languages", "LanguageType_Id");
            DropColumn("dbo.Languages", "KnowledgeLevelType_Id");
            DropTable("dbo.LanguageTypes");
            DropTable("dbo.KnowledgeLevelTypes");
        }
    }
}
