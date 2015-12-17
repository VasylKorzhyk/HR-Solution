namespace HRM.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        ContractID = c.Int(nullable: false),
                        ContractType = c.String(),
                        Hiredate = c.DateTime(nullable: false),
                        Firedate = c.DateTime(nullable: false),
                        Probation = c.DateTime(nullable: false),
                        Salary = c.Double(nullable: false),
                        Person_Id = c.String(maxLength: 128),
                        Post_Id = c.String(maxLength: 128),
                        SalaryType_Id = c.String(maxLength: 128),
                        WorkType_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .ForeignKey("dbo.Posts", t => t.Post_Id)
                .ForeignKey("dbo.SalaryTypes", t => t.SalaryType_Id)
                .ForeignKey("dbo.WorkTypes", t => t.WorkType_Id)
                .Index(t => t.Person_Id)
                .Index(t => t.Post_Id)
                .Index(t => t.SalaryType_Id)
                .Index(t => t.WorkType_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        ThirdName = c.String(),
                        BirthdayDate = c.DateTime(nullable: false),
                        Sex = c.String(),
                        RegistrationAddress = c.String(),
                        PassportID = c.String(),
                        TaxID = c.String(),
                        LivingAddress = c.String(),
                        WorkPhone = c.String(),
                        PersonalPhone = c.String(),
                        Citizenship = c.String(),
                        Disablement = c.String(),
                        Photo = c.String(),
                        CV = c.String(),
                        Army_Id = c.String(maxLength: 128),
                        MaritalStatus_Id = c.String(maxLength: 128),
                        Promotion_Id = c.String(maxLength: 128),
                        WorkerStatus_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Armies", t => t.Army_Id)
                .ForeignKey("dbo.MaritalStatus", t => t.MaritalStatus_Id)
                .ForeignKey("dbo.Promotions", t => t.Promotion_Id)
                .ForeignKey("dbo.WorkerStatus", t => t.WorkerStatus_Id)
                .Index(t => t.Army_Id)
                .Index(t => t.MaritalStatus_Id)
                .Index(t => t.Promotion_Id)
                .Index(t => t.WorkerStatus_Id);
            
            CreateTable(
                "dbo.Armies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Hiredate = c.DateTime(nullable: false),
                        Firedate = c.DateTime(nullable: false),
                        Registration = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        EducationPlace = c.String(),
                        Specialization = c.String(),
                        Qualification = c.String(),
                        EndingDate = c.DateTime(nullable: false),
                        DiplomID = c.String(),
                        EducationType_Id = c.String(maxLength: 128),
                        Person_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationTypes", t => t.EducationType_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.EducationType_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.EducationTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        ThirdName = c.String(),
                        BirthdayDate = c.DateTime(nullable: false),
                        FamilyType_Id = c.String(maxLength: 128),
                        Person_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FamilyTypes", t => t.FamilyType_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.FamilyType_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.FamilyTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Languages",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        KnowledgeLevelType_Id = c.String(maxLength: 128),
                        LanguageType_Id = c.String(maxLength: 128),
                        Person_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeLevelTypes", t => t.KnowledgeLevelType_Id)
                .ForeignKey("dbo.LanguageTypes", t => t.LanguageType_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.KnowledgeLevelType_Id)
                .Index(t => t.LanguageType_Id)
                .Index(t => t.Person_Id);
            
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
            
            CreateTable(
                "dbo.MaritalStatus",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        PromotionType_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkerStatus",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        StatusType_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StatusTypes", t => t.StatusType_Id)
                .Index(t => t.StatusType_Id);
            
            CreateTable(
                "dbo.StatusTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Department_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.SalaryTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkTypes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        WorkCode = c.Int(nullable: false),
                        WorkTime = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "WorkType_Id", "dbo.WorkTypes");
            DropForeignKey("dbo.Employees", "SalaryType_Id", "dbo.SalaryTypes");
            DropForeignKey("dbo.Employees", "Post_Id", "dbo.Posts");
            DropForeignKey("dbo.Posts", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Employees", "Person_Id", "dbo.People");
            DropForeignKey("dbo.People", "WorkerStatus_Id", "dbo.WorkerStatus");
            DropForeignKey("dbo.WorkerStatus", "StatusType_Id", "dbo.StatusTypes");
            DropForeignKey("dbo.People", "Promotion_Id", "dbo.Promotions");
            DropForeignKey("dbo.People", "MaritalStatus_Id", "dbo.MaritalStatus");
            DropForeignKey("dbo.Languages", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Languages", "LanguageType_Id", "dbo.LanguageTypes");
            DropForeignKey("dbo.Languages", "KnowledgeLevelType_Id", "dbo.KnowledgeLevelTypes");
            DropForeignKey("dbo.Families", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Families", "FamilyType_Id", "dbo.FamilyTypes");
            DropForeignKey("dbo.Educations", "Person_Id", "dbo.People");
            DropForeignKey("dbo.Educations", "EducationType_Id", "dbo.EducationTypes");
            DropForeignKey("dbo.People", "Army_Id", "dbo.Armies");
            DropIndex("dbo.Posts", new[] { "Department_Id" });
            DropIndex("dbo.WorkerStatus", new[] { "StatusType_Id" });
            DropIndex("dbo.Languages", new[] { "Person_Id" });
            DropIndex("dbo.Languages", new[] { "LanguageType_Id" });
            DropIndex("dbo.Languages", new[] { "KnowledgeLevelType_Id" });
            DropIndex("dbo.Families", new[] { "Person_Id" });
            DropIndex("dbo.Families", new[] { "FamilyType_Id" });
            DropIndex("dbo.Educations", new[] { "Person_Id" });
            DropIndex("dbo.Educations", new[] { "EducationType_Id" });
            DropIndex("dbo.People", new[] { "WorkerStatus_Id" });
            DropIndex("dbo.People", new[] { "Promotion_Id" });
            DropIndex("dbo.People", new[] { "MaritalStatus_Id" });
            DropIndex("dbo.People", new[] { "Army_Id" });
            DropIndex("dbo.Employees", new[] { "WorkType_Id" });
            DropIndex("dbo.Employees", new[] { "SalaryType_Id" });
            DropIndex("dbo.Employees", new[] { "Post_Id" });
            DropIndex("dbo.Employees", new[] { "Person_Id" });
            DropTable("dbo.WorkTypes");
            DropTable("dbo.SalaryTypes");
            DropTable("dbo.Posts");
            DropTable("dbo.StatusTypes");
            DropTable("dbo.WorkerStatus");
            DropTable("dbo.Promotions");
            DropTable("dbo.MaritalStatus");
            DropTable("dbo.LanguageTypes");
            DropTable("dbo.KnowledgeLevelTypes");
            DropTable("dbo.Languages");
            DropTable("dbo.FamilyTypes");
            DropTable("dbo.Families");
            DropTable("dbo.EducationTypes");
            DropTable("dbo.Educations");
            DropTable("dbo.Armies");
            DropTable("dbo.People");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
