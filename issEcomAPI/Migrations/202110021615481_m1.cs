namespace issEcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        doorNo = c.String(),
                        buliding = c.String(),
                        address1 = c.String(),
                        address2 = c.String(),
                        city = c.String(),
                        state = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        email = c.String(),
                        password = c.String(),
                        userName = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.customerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
        }
    }
}
