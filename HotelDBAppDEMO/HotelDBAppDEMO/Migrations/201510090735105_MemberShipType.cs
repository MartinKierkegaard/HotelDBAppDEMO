namespace HotelDBAppDEMO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipType",
                c => new
                    {
                        GuestRating = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        SumBookings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GuestRating);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MemberShipType");
        }
    }
}
