namespace HotelDBAppDEMO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuestRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guest", "GuestRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guest", "GuestRating");
        }
    }
}
