namespace CodeFirstWithMigrations.Migrations
{

    using System.Data.Entity.Migrations;

    public partial class AddNewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Partners",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PartnerTeams",
                c => new
                {
                    Partner_Id = c.Int(nullable: false),
                    Team_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Partner_Id, t.Team_Id })
                .ForeignKey("dbo.Partners", t => t.Partner_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Partner_Id)
                .Index(t => t.Team_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.PartnerTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.PartnerTeams", "Partner_Id", "dbo.Partners");
            DropIndex("dbo.PartnerTeams", new[] { "Team_Id" });
            DropIndex("dbo.PartnerTeams", new[] { "Partner_Id" });
            DropTable("dbo.PartnerTeams");
            DropTable("dbo.Partners");
        }
    }
}
