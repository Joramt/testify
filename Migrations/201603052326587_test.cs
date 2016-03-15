namespace TPFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedQuizz = c.Int(nullable: false),
                        PassedQuizz = c.Int(nullable: false),
                        TestifyUser_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.TestifyUser_Id)
                .Index(t => t.TestifyUser_Id);

        }
        
        public override void Down()
        {
           
        }
    }
}
