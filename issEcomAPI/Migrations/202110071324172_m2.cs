namespace issEcom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                        description = c.String(),
                        picture = c.String(maxLength: 500),
                        active = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        orderDetailId = c.Int(nullable: false, identity: true),
                        orderId = c.String(),
                        productId = c.Int(nullable: false),
                        OrderNo = c.String(),
                        price = c.String(),
                        quantity = c.String(),
                        discount = c.String(),
                        total = c.String(),
                        IDSKU = c.String(),
                        size = c.String(),
                        color = c.String(),
                        fulfilled = c.String(),
                        shipDate = c.DateTime(),
                        billDate = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.orderDetailId)
                .ForeignKey("dbo.products", t => t.productId, cascadeDelete: true)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        SKU = c.String(),
                        IDSKU = c.String(),
                        vendorproductId = c.String(),
                        productName = c.String(),
                        productDescription = c.String(),
                        supplierId = c.Int(nullable: false),
                        categoryId = c.Int(nullable: false),
                        quantityPerUnit = c.String(),
                        unitPrice = c.String(),
                        MSRP = c.String(),
                        availableSize = c.String(),
                        availableColors = c.String(),
                        size = c.String(),
                        color = c.String(),
                        discount = c.String(),
                        unitWeight = c.String(),
                        unitslnStok = c.String(),
                        unitsOnOrder = c.String(),
                        recorderLevel = c.String(),
                        productAvailable = c.String(),
                        discountAvailable = c.String(),
                        currentOrder = c.String(),
                        picture = c.String(maxLength: 500),
                        ranking = c.String(),
                        note = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.categories", t => t.categoryId, cascadeDelete: true)
                .ForeignKey("dbo.suppliers", t => t.supplierId, cascadeDelete: true)
                .Index(t => t.supplierId)
                .Index(t => t.categoryId);
            
            CreateTable(
                "dbo.suppliers",
                c => new
                    {
                        supplierId = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        contactFName = c.String(),
                        contactLName = c.String(),
                        contactTitle = c.String(),
                        firstAddress = c.String(),
                        secondAddress = c.String(),
                        city = c.String(),
                        state = c.String(),
                        postalCode = c.String(),
                        country = c.String(),
                        phone = c.String(),
                        fax = c.String(),
                        email = c.String(),
                        URL = c.String(),
                        paymentMethods = c.String(),
                        discountType = c.String(),
                        typeGoods = c.String(),
                        notes = c.String(),
                        discountAvailable = c.String(),
                        currentOrder = c.String(),
                        logo = c.String(maxLength: 500),
                        customerId = c.Int(nullable: false),
                        sizeURL = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.supplierId)
                .ForeignKey("dbo.customers", t => t.customerId, cascadeDelete: true)
                .Index(t => t.customerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        customerId = c.Int(nullable: false),
                        orderNo = c.String(),
                        paymentId = c.Int(nullable: false),
                        orderDate = c.DateTime(),
                        shipDate = c.DateTime(),
                        requiredDate = c.DateTime(),
                        shipperId = c.Int(nullable: false),
                        freight = c.String(),
                        salesTax = c.String(),
                        transactStatus = c.String(),
                        errLoc = c.String(),
                        errMsg = c.String(),
                        timestamp = c.DateTime(),
                        fullfilled = c.String(),
                        deleted = c.String(),
                        paid = c.String(),
                        paymentDate = c.DateTime(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.orderId)
                .ForeignKey("dbo.customers", t => t.customerId, cascadeDelete: true)
                .ForeignKey("dbo.payments", t => t.paymentId, cascadeDelete: true)
                .ForeignKey("dbo.shippers", t => t.shipperId, cascadeDelete: true)
                .Index(t => t.customerId)
                .Index(t => t.paymentId)
                .Index(t => t.shipperId);
            
            CreateTable(
                "dbo.payments",
                c => new
                    {
                        paymentId = c.Int(nullable: false, identity: true),
                        paymentType = c.String(),
                        allowed = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.paymentId);
            
            CreateTable(
                "dbo.shippers",
                c => new
                    {
                        shipperId = c.Int(nullable: false, identity: true),
                        companyName = c.String(),
                        phoneNo = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.shipperId);
            
            AddColumn("dbo.customers", "creditCard", c => c.String());
            AddColumn("dbo.customers", "creditCardTypeId", c => c.String());
            AddColumn("dbo.customers", "cardExpMo", c => c.String());
            AddColumn("dbo.customers", "cardExpYr", c => c.String());
            AddColumn("dbo.customers", "billingAddress", c => c.String());
            AddColumn("dbo.customers", "billingCity", c => c.String());
            AddColumn("dbo.customers", "billingRegion", c => c.String());
            AddColumn("dbo.customers", "billingPostalCode", c => c.String());
            AddColumn("dbo.customers", "billingCountry", c => c.String());
            AddColumn("dbo.customers", "shipAddress", c => c.String());
            AddColumn("dbo.customers", "shipCity", c => c.String());
            AddColumn("dbo.customers", "shipRegion", c => c.String());
            AddColumn("dbo.customers", "shipPostalCode", c => c.String());
            AddColumn("dbo.customers", "shipCountry", c => c.String());
            AddColumn("dbo.customers", "dateEntered", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "shipperId", "dbo.shippers");
            DropForeignKey("dbo.Orders", "paymentId", "dbo.payments");
            DropForeignKey("dbo.Orders", "customerId", "dbo.customers");
            DropForeignKey("dbo.OrderDetails", "productId", "dbo.products");
            DropForeignKey("dbo.products", "supplierId", "dbo.suppliers");
            DropForeignKey("dbo.suppliers", "customerId", "dbo.customers");
            DropForeignKey("dbo.products", "categoryId", "dbo.categories");
            DropIndex("dbo.Orders", new[] { "shipperId" });
            DropIndex("dbo.Orders", new[] { "paymentId" });
            DropIndex("dbo.Orders", new[] { "customerId" });
            DropIndex("dbo.suppliers", new[] { "customerId" });
            DropIndex("dbo.products", new[] { "categoryId" });
            DropIndex("dbo.products", new[] { "supplierId" });
            DropIndex("dbo.OrderDetails", new[] { "productId" });
            DropColumn("dbo.customers", "dateEntered");
            DropColumn("dbo.customers", "shipCountry");
            DropColumn("dbo.customers", "shipPostalCode");
            DropColumn("dbo.customers", "shipRegion");
            DropColumn("dbo.customers", "shipCity");
            DropColumn("dbo.customers", "shipAddress");
            DropColumn("dbo.customers", "billingCountry");
            DropColumn("dbo.customers", "billingPostalCode");
            DropColumn("dbo.customers", "billingRegion");
            DropColumn("dbo.customers", "billingCity");
            DropColumn("dbo.customers", "billingAddress");
            DropColumn("dbo.customers", "cardExpYr");
            DropColumn("dbo.customers", "cardExpMo");
            DropColumn("dbo.customers", "creditCardTypeId");
            DropColumn("dbo.customers", "creditCard");
            DropTable("dbo.shippers");
            DropTable("dbo.payments");
            DropTable("dbo.Orders");
            DropTable("dbo.suppliers");
            DropTable("dbo.products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.categories");
        }
    }
}
