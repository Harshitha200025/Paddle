namespace Paddle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Book_id = c.Int(nullable: false, identity: true),
                        cust_id = c.Int(nullable: false),
                        courtid = c.Int(nullable: false),
                        timing = c.DateTime(nullable: false),
                        no_of_hrs = c.Int(nullable: false),
                        payment = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Book_id)
                .ForeignKey("dbo.Courts", t => t.courtid, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.cust_id, cascadeDelete: true)
                .Index(t => t.cust_id)
                .Index(t => t.courtid);
            
            CreateTable(
                "dbo.Courts",
                c => new
                    {
                        c_id = c.Int(nullable: false, identity: true),
                        loc_id = c.Int(nullable: false),
                        price = c.Single(nullable: false),
                        avail_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.c_id)
                .ForeignKey("dbo.Locations", t => t.loc_id, cascadeDelete: true)
                .Index(t => t.loc_id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        locid = c.Int(nullable: false, identity: true),
                        locname = c.String(),
                        no_of_courts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.locid);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        cust_id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Email_id = c.String(),
                        phone_no = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cust_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "cust_id", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "courtid", "dbo.Courts");
            DropForeignKey("dbo.Courts", "loc_id", "dbo.Locations");
            DropIndex("dbo.Courts", new[] { "loc_id" });
            DropIndex("dbo.Bookings", new[] { "courtid" });
            DropIndex("dbo.Bookings", new[] { "cust_id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Locations");
            DropTable("dbo.Courts");
            DropTable("dbo.Bookings");
        }
    }
}
