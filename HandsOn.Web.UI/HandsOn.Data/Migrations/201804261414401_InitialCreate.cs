namespace HandsOn.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Scenario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 50),
                        Discriminator = c.String(nullable: false, maxLength: 50),
                        Discriminator1 = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);

            //DropColumn("dbo.Scenario", "Discrimitator1");
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Scenario");
        }
    }
}
